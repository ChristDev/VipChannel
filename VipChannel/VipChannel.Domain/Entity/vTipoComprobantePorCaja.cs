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
    
    public partial class vTipoComprobantePorCaja
    {
        public System.Guid VoucherId { get; set; }
        public string VoucherType { get; set; }
        public Nullable<System.Guid> SaleBoxId { get; set; }
        public string Name { get; set; }
        public string Serie { get; set; }
        public int Number { get; set; }
    }
}
