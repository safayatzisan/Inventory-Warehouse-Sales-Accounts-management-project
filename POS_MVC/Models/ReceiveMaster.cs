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
    
    public partial class ReceiveMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceiveMaster()
        {
            this.ReceiveDetails = new HashSet<ReceiveDetail>();
        }
    
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string InvoiceNoPaper { get; set; }
        public int SupplierID { get; set; }
        public string RecieveFrom { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public decimal AdditionalCost { get; set; }
        public decimal BillDiscount { get; set; }
        public decimal GrandTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public string MarketType { get; set; }
        public string TransportType { get; set; }
        public string TransportNo { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiveDetail> ReceiveDetails { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
