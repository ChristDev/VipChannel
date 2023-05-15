using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;

namespace VipChannel.Application
{
    public class QueryServerApplication : ClassServer<VipChannel_CollectionEntities>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public QueryServerApplication()
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
