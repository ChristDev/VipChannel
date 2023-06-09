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
    
    public partial class Material
    {
        public System.Guid MaterialId { get; set; }
        public System.Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public string Model { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public int Stock { get; set; }
        public Nullable<int> MinimumStock { get; set; }
        public string Description { get; set; }
        public string SerialNumber { get; set; }
        public string MacNumber { get; set; }
        public byte[] Image { get; set; }
        public Nullable<System.Guid> BrandId { get; set; }
        public string UnitMeasurementType { get; set; }
        public string UserRecordCreation { get; set; }
        public System.DateTime RecordCreationDate { get; set; }
        public string UserEditRecord { get; set; }
        public Nullable<System.DateTime> RecordEditDate { get; set; }
        public string RecordStatus { get; set; }
    
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}
