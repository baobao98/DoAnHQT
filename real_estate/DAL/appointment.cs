//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class appointment
    {
        public int id { get; set; }
        public string description { get; set; }
        public string status { get; set; }
        public string id_cus { get; set; }
        public Nullable<System.DateTime> appointment_date { get; set; }
    
        public virtual customer customer { get; set; }
    }
}
