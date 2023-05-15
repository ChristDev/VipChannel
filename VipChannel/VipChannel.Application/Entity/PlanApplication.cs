using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;
using VipChannel.Enums.MasterTables;

namespace VipChannel.Application.Entity
{
    public class PlanApplication : GenericClass<VipChannel_CollectionEntities, Plan>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public PlanApplication()
        {
            _dataContext = new VipChannel_CollectionEntities();
        }

        public void Dispose()
        {
            if (_dataContext == null) return;
            _dataContext.Dispose();
            _dataContext = null;
        }

        public string GenerarCodigoInterno()
        {
            var rows = _dataContext.Plans.Count(x=>x.RecordStatus == ConstantBase.Active);
            var codigo = (rows + 1).ToString("D10");
            return codigo;
        }
    }
}
