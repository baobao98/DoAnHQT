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
    
    public partial class advertisement
    {
        public string id_ad { get; set; }
        public string name_ad { get; set; }
        public string information { get; set; }
        public string discount { get; set; }
        public string prop { get; set; }
        public string img { get; set; }
    
        public virtual property property { get; set; }
    }
}
