//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Files
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Files()
        {
            this.del = 0;
            this.Persoanes = new HashSet<Persoane>();
            this.Useris = new HashSet<Useri>();
        }
    
        public int Id { get; set; }
        public string nume_fisier { get; set; }
        public string cale { get; set; }
        public System.DateTime data_creare { get; set; }
        public string locatie { get; set; }
        public string eveniment { get; set; }
        public string peisaj { get; set; }
        public string descriere { get; set; }
        public int del { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persoane> Persoanes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Useri> Useris { get; set; }
    }
}
