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
    
    public partial class Company
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Road { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string PostalCode { get; set; }
        public string LogoURL { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
