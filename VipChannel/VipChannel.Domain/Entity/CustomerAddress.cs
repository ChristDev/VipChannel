//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VipChannel.Domain.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAddress()
        {
            this.InstallationRequests = new HashSet<InstallationRequest>();
            this.Schedules = new HashSet<Schedule>();
        }
    
        public System.Guid CustomerAddressId { get; set; }
        public System.Guid CustomerId { get; set; }
        public string CodeCustomerAddress { get; set; }
        public System.Guid ZoneId { get; set; }
        public System.Guid AvenueId { get; set; }
        public string AdressDetail { get; set; }
        public string Number { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Reference { get; set; }
        public string CustomerAddressStatus { get; set; }
        public string UserRecordCreation { get; set; }
        public System.DateTime RecordCreationDate { get; set; }
        public string UserEditRecord { get; set; }
        public Nullable<System.DateTime> RecordEditDate { get; set; }
        public string RecordStatus { get; set; }
    
        public virtual Avenue Avenue { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Zone Zone { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstallationRequest> InstallationRequests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
