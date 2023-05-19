using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.Entity
{
    public class RoleApplication : GenericClass<VipChannel_CollectionEntities, Role>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public RoleApplication()
        {
            _dataContext = new VipChannel_CollectionEntities();
        }

        public void Dispose()
        {
            if (_dataContext == null) return;
            _dataContext.Dispose();
            _dataContext = null;
        }

        public void ActualizarPermisos(Guid idRol, string cadenapermisos)
        {
            var entity = _dataContext.Roles.FirstOrDefault(x => x.RoleId == idRol);
            if (entity != null)
            {
                entity.Permissions = cadenapermisos;
                _dataContext.Roles.Add(entity);
                _dataContext.Entry(entity).State = EntityState.Modified;
            }
            _dataContext.SaveChanges();
        }
    }
}
