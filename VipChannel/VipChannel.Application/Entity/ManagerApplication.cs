using System;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.Entity
{
    public class ManagerApplication : GenericClass<VipChannel_CollectionEntities, Manager>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public ManagerApplication()
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
