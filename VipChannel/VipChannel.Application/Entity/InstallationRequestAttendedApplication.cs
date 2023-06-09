﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VipChannel.Application.Helper;
using VipChannel.Data.Model;
using VipChannel.Domain.Entity;

namespace VipChannel.Application.Entity
{
    public class InstallationRequestAttendedApplication : GenericClass<VipChannel_CollectionEntities, 
        InstallationRequestAttended>, IDisposable
    {
        private VipChannel_CollectionEntities _dataContext;

        public InstallationRequestAttendedApplication()
        {
            _dataContext = new VipChannel_CollectionEntities();
        }

        public void Dispose()
        {
            if (_dataContext == null) return;
            _dataContext.Dispose();
            _dataContext = null;
        }

        public void GenerarCronogramaClienteDireccion(Guid customerAddressId, string userRecordCreation)
        {
            _dataContext.usp_GenerarCronogramaClienteDireccion(customerAddressId, userRecordCreation);
        }
    }
}
