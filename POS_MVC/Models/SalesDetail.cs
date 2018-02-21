//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesDetail
    {
        public int Id { get; set; }
        public int SalesMasterId { get; set; }
        public string SalesInvoice { get; set; }
        public int ProductId { get; set; }
        public int BaleQty { get; set; }
        public decimal BaleWeight { get; set; }
        public decimal TotalQtyInKG { get; set; }
        public decimal Rate { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual SalesMaster SalesMaster { get; set; }
    }
}
