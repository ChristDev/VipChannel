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
    
    public partial class vPlanInternet
    {
        public System.Guid PlanId { get; set; }
        public string InternalCode { get; set; }
        public string PlanTypeDescription { get; set; }
        public string Description { get; set; }
        public string InternetUpload { get; set; }
        public string InternetDownload { get; set; }
        public decimal Cost { get; set; }
    }
}
