using System;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.Entity
{
    public class AvenueApplication : GenericClass<VipChannel_CollectionEntities, Avenue>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public AvenueApplication()
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
