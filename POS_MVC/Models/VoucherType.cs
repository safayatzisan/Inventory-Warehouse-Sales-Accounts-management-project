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
    
    public partial class VoucherType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoucherType()
        {
            this.AdvancePayments = new HashSet<AdvancePayment>();
            this.ContraMasters = new HashSet<ContraMaster>();
            this.JournalMasters = new HashSet<JournalMaster>();
            this.LedgerPostings = new HashSet<LedgerPosting>();
        }
    
        public int Id { get; set; }
        public string VoucherTypeName { get; set; }
        public string TypeOfVoucher { get; set; }
        public string MethodOfVoucherNumbering { get; set; }
        public Nullable<bool> IsTaxApplicable { get; set; }
        public string Narration { get; set; }
        public Nullable<System.DateTime> ExtraDate { get; set; }
        public string Extra1 { get; set; }
        public string Extra2 { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<int> MasterId { get; set; }
        public string Declaration { get; set; }
        public string Heading1 { get; set; }
        public string Heading2 { get; set; }
        public string Heading3 { get; set; }
        public string Heading4 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdvancePayment> AdvancePayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContraMaster> ContraMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JournalMaster> JournalMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LedgerPosting> LedgerPostings { get; set; }
    }
}
