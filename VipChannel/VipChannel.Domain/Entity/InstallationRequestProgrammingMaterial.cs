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
    
    public partial class InstallationRequestProgrammingMaterial
    {
        public System.Guid InstallationRequestProgrammingMaterialId { get; set; }
        public System.Guid InstallationRequestProgrammingId { get; set; }
        public System.Guid MaterialId { get; set; }
        public string ConditionType { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string UserRecordCreation { get; set; }
        public System.DateTime RecordCreationDate { get; set; }
        public string UserEditRecord { get; set; }
        public Nullable<System.DateTime> RecordEditDate { get; set; }
        public string RecordStatus { get; set; }
    
        public virtual InstallationRequestProgramming InstallationRequestProgramming { get; set; }
        public virtual Material Material { get; set; }
    }
}
