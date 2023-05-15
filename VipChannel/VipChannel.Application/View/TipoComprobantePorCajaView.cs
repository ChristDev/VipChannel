using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.View
{
    public class TipoComprobantePorCajaView : ViewGeneric<VipChannel_CollectionEntities, vTipoComprobantePorCaja>
    {
        private VipChannel_CollectionEntities _dataContext;

        public TipoComprobantePorCajaView()
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
