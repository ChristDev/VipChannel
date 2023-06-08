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
    public class ManagerZoneApplication : GenericClass<VipChannel_CollectionEntities, ManagerZone>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public ManagerZoneApplication()
        {
            _dataContext = new VipChannel_CollectionEntities();
        }

        public void Dispose()
        {
            if (_dataContext == null) return;
            _dataContext.Dispose();
            _dataContext = null;
        }
    }
}
