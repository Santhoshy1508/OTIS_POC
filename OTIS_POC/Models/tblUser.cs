//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OTIS_POC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUser
    {
        public int ID { get; set; }
        public string LoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Region { get; set; }
        public int Admin { get; set; }
        public Nullable<int> DefaultLang { get; set; }
        public string LastUseDate { get; set; }
        public Nullable<bool> bReadOnly { get; set; }
        public Nullable<int> bKRSA { get; set; }
        public int Active { get; set; }
    }
}
