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
    
    public partial class CreditNoteMaster
    {
        public decimal creditNoteMasterId { get; set; }
        public string voucherNo { get; set; }
        public string invoiceNo { get; set; }
        public Nullable<decimal> suffixPrefixId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> userId { get; set; }
        public Nullable<decimal> totalAmount { get; set; }
        public string narration { get; set; }
        public Nullable<decimal> financialYearId { get; set; }
        public Nullable<System.DateTime> extraDate { get; set; }
        public string extra1 { get; set; }
        public string extra2 { get; set; }
        public Nullable<decimal> voucherTypeId { get; set; }
    }
}
