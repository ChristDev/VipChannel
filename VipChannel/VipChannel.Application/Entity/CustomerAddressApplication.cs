using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.Entity
{
    public class CustomerAddressApplication : GenericClass<VipChannel_CollectionEntities, CustomerAddress>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public CustomerAddressApplication()
        {
            _dataContext = new VipChannel_CollectionEntities();
        }

        public void Dispose()
        {
            if (_dataContext == null) return;
            _dataContext.Dispose();
            _dataContext = null;
        }

        public ObjectResult<usp_ListarDireccionPorClienteSolicitud_Result> ListarDireccionPorClienteSolicitud(Guid customerAddressId)
        {
            return _dataContext.usp_ListarDireccionPorClienteSolicitud(customerAddressId);
        }

        public int ActualizarCoordenadasCliente(Guid customerAddressId, string latitude, string longitude)
        {
            return _dataContext.usp_ActualizarCoordenadasCliente(customerAddressId, latitude, longitude);
        }

        public int ActualizarEstadoClienteDireccionActivo(Guid customerAddressId, string customerAddressStatus)
        {
            return _dataContext.usp_ActualizarEstadoClienteDireccionActivo(customerAddressId, customerAddressStatus);
        }

        public int ActualizarEstadoClienteDireccionRechazado(Guid customerAddressId, string customerAddressStatus)
        {
            return _dataContext.usp_ActualizarEstadoClienteDireccionRechazado(customerAddressId, customerAddressStatus);
        }
    }
}
