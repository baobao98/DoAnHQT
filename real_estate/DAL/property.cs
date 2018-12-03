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
    
    public partial class property
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public property()
        {
            this.advertisements = new HashSet<advertisement>();
            this.trannsactions = new HashSet<trannsaction>();
        }
    
        public string id_prop { get; set; }
        public string name { get; set; }
        public Nullable<int> id_real_estate_type { get; set; }
        public string id_project { get; set; }
        public Nullable<int> floor { get; set; }
        public Nullable<int> room { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public Nullable<int> id_town_region { get; set; }
        public Nullable<int> id_area { get; set; }
        public Nullable<int> id_district { get; set; }
        public string img1 { get; set; }
        public string img2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<advertisement> advertisements { get; set; }
        public virtual area area { get; set; }
        public virtual district district { get; set; }
        public virtual realEstateType realEstateType { get; set; }
        public virtual townRegion townRegion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trannsaction> trannsactions { get; set; }
    }
}
