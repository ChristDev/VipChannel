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
    
    public partial class vCliente
    {
        public System.Guid CustomerId { get; set; }
        public string PersonTypeId { get; set; }
        public string PersonType { get; set; }
        public string DocumentTypeId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string BusinessName { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string CellPhone { get; set; }
        public string CustomerStatus { get; set; }
    }
}
