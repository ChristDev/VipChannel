using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace VipChannel.Application.Helper
{
    public class ViewGeneric<T, TEntity> where T : DbContext, new() where TEntity : class
    {
        public List<TEntity> SelectListView(Expression<Func<TEntity, bool>> predicate = null, bool detach = false)
        {
            T db = new T();
            var query = db.Set<TEntity>().AsQueryable();
            if (predicate != null)
                query = query.Where(predicate);

            var entityList = query.ToList();
            if (entityList.Count <= 0 || !detach) return entityList;
            foreach (var e in entityList)
            {
                ((IObjectContextAdapter)db).ObjectContext.Detach(e);
            }
            return entityList;
        }
    }
}