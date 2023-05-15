using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.View
{
    public class PlanCableView : ViewGeneric<VipChannel_CollectionEntities, vPlanCable>
    {
        private VipChannel_CollectionEntities _dataContext;

        public PlanCableView()
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
