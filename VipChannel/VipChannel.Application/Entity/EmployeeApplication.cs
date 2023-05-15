using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.Entity
{
    public class EmployeeApplication : GenericClass<VipChannel_CollectionEntities, Employee>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public EmployeeApplication()
        {
            _dataContext = new VipChannel_CollectionEntities();
        }

        public void Dispose()
        {
            if (_dataContext == null) return;
            _dataContext.Dispose();
            _dataContext = null;
        }
        
        public byte[] GetPasswordByIdUsuario(Guid id)
        {
            var e = _dataContext.Employees.SingleOrDefault(item => item.EmployeeId == id);
            return e != null ? e.Password : new byte[] { };
        }
    }
}
