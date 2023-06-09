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
    
    public partial class InstallationRequestCost
    {
        public System.Guid InstallationRequestCostId { get; set; }
        public Nullable<System.Guid> InstallationRequestId { get; set; }
        public Nullable<System.Guid> ServiceId { get; set; }
        public string ServiceName { get; set; }
        public Nullable<decimal> ServiceCost { get; set; }
        public string UserRecordCreation { get; set; }
        public Nullable<System.DateTime> RecordCreationDate { get; set; }
        public string UserEditRecord { get; set; }
        public Nullable<System.DateTime> RecordEditDate { get; set; }
        public string RecordStatus { get; set; }
    
        public virtual InstallationRequest InstallationRequest { get; set; }
        public virtual Service Service { get; set; }
    }
}
