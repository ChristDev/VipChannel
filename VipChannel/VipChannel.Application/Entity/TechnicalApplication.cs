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
    public class TechnicalApplication : GenericClass<VipChannel_CollectionEntities, Technical>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public TechnicalApplication()
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
            var e = _dataContext.Technicals.SingleOrDefault(item => item.TechnicalId == id);
            return e != null ? e.Password : new byte[] { };
        }
    }
}
