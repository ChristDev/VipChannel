using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.View
{
    public class CobradorPorZonaView : ViewGeneric<VipChannel_CollectionEntities, vCobradorPorZona>
    {
        private VipChannel_CollectionEntities _dataContext;

        public CobradorPorZonaView()
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
