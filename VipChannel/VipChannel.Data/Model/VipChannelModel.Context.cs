﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VipChannel.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using VipChannel.Domain.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class VipChannel_CollectionEntities : DbContext
    {
        public VipChannel_CollectionEntities()
            : base("name=VipChannel_CollectionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avenue> Avenues { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<InstallationRequest> InstallationRequests { get; set; }
        public virtual DbSet<InstallationRequestCost> InstallationRequestCosts { get; set; }
        public virtual DbSet<InstallationRequestPlan> InstallationRequestPlans { get; set; }
        public virtual DbSet<MasterTable> MasterTables { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }
        public virtual DbSet<PaymentSchedule> PaymentSchedules { get; set; }
        public virtual DbSet<PaymentScheduleDetail> PaymentScheduleDetails { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SaleBox> SaleBoxes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Sucursal> Sucursals { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Technical> Technicals { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<Zone> Zones { get; set; }
        public virtual DbSet<vCliente> vClientes { get; set; }
        public virtual DbSet<vEmpleado> vEmpleadoes { get; set; }
        public virtual DbSet<vPlanCable> vPlanCables { get; set; }
        public virtual DbSet<vPlanesVenta> vPlanesVentas { get; set; }
        public virtual DbSet<vPlanInternet> vPlanInternets { get; set; }
        public virtual DbSet<vPlanPersonalizado> vPlanPersonalizadoes { get; set; }
        public virtual DbSet<vServiciosVenta> vServiciosVentas { get; set; }
        public virtual DbSet<vSolicitudesInstalacion> vSolicitudesInstalacions { get; set; }
        public virtual DbSet<vSucursalPorCaja> vSucursalPorCajas { get; set; }
        public virtual DbSet<vTecnico> vTecnicoes { get; set; }
        public virtual DbSet<vTipoComprobantePorCaja> vTipoComprobantePorCajas { get; set; }
        public virtual DbSet<InstallationRequestAttended> InstallationRequestAttendeds { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
    
        public virtual ObjectResult<usp_ListarDireccionPorClienteSolicitud_Result> usp_ListarDireccionPorClienteSolicitud(Nullable<System.Guid> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("CustomerId", customerId) :
                new ObjectParameter("CustomerId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ListarDireccionPorClienteSolicitud_Result>("usp_ListarDireccionPorClienteSolicitud", customerIdParameter);
        }
    
        public virtual int usp_ActualizarCoordenadasCliente(Nullable<System.Guid> customerAddressId, string latitude, string longitude)
        {
            var customerAddressIdParameter = customerAddressId.HasValue ?
                new ObjectParameter("CustomerAddressId", customerAddressId) :
                new ObjectParameter("CustomerAddressId", typeof(System.Guid));
    
            var latitudeParameter = latitude != null ?
                new ObjectParameter("Latitude", latitude) :
                new ObjectParameter("Latitude", typeof(string));
    
            var longitudeParameter = longitude != null ?
                new ObjectParameter("Longitude", longitude) :
                new ObjectParameter("Longitude", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ActualizarCoordenadasCliente", customerAddressIdParameter, latitudeParameter, longitudeParameter);
        }
    }
}
