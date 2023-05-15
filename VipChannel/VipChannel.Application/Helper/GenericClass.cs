using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace VipChannel.Application.Helper
{
    public class GenericClass<T, TEntity> where T : DbContext, new() where TEntity : class
    {
        public TEntity SelectSingle(Expression<Func<TEntity, bool>> predicate, bool detach = false)
        {
            T db = new T();
            var query = db.Set<TEntity>().Where(predicate);
            var entity = query.SingleOrDefault();
            if (entity != null && detach)
                ((IObjectContextAdapter)db).ObjectContext.Detach(entity);
            return entity;
        }

        public int SelectCount(Expression<Func<TEntity, bool>> predicate, bool detach = false)
        {
            T db = new T();
            var query = db.Set<TEntity>().Where(predicate);
            var entity = query.ToList().Count;
            if (detach)
                ((IObjectContextAdapter)db).ObjectContext.Detach(entity);
            return entity;
        }

        public List<TEntity> SelectList(Expression<Func<TEntity, bool>> predicate = null, bool detach = false)
        {
            T db = new T();
            var query = db.Set<TEntity>().AsQueryable();
            if (predicate != null)
                query = query.Where(predicate);
            var entityList = query.ToList();
            if (entityList.Count > 0 && detach)
            {
                foreach (var e in entityList)
                {
                    ((IObjectContextAdapter)db).ObjectContext.Detach(e);
                }
            }
            return entityList;
        }

        public bool Insert(TEntity entity)
        {
            bool success = false;
            try
            {
                using (T db = new T())
                {
                    db.Set(typeof(TEntity)).Add(entity);
                    ((IObjectContextAdapter)db).ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Added);
                    
                    success = db.SaveChanges() > 0;
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            return success;
        }

        public bool Update(TEntity entity)
        {
            bool success = false;
            try
            {
                using (T db = new T())
                {
                    db.Set(typeof(TEntity)).Add(entity);
                    ((IObjectContextAdapter)db).ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                    success = db.SaveChanges() > 0;
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            return success;
        }

        public bool Delete(TEntity entity)
        {
            bool success = false;
            using (T db = new T())
            {
                db.Set(typeof(TEntity)).Add(entity);
                ((IObjectContextAdapter)db).ObjectContext.ObjectStateManager.ChangeObjectState(entity, EntityState.Deleted);

                success = db.SaveChanges() > 0;
            }
            return success;
        }
    }
}
