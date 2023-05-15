using System;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.Entity
{
    public class ZoneApplication : GenericClass<VipChannel_CollectionEntities, Zone>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public ZoneApplication()
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
