//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Testovi
{
    using System;
    using System.Collections.Generic;
    
    public partial class Instrukcije
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instrukcije()
        {
            this.Termini = new HashSet<Termini>();
        }
    
        public int ID_instrukcije { get; set; }
        public int instruktor_id { get; set; }
        public Nullable<int> tip_instrukcije_id { get; set; }
        public int kolegij_id { get; set; }
        public string opis_instrukcije { get; set; }
        public double cijena_instrukcije { get; set; }
    
        public virtual Instruktori Instruktori { get; set; }
        public virtual Kolegiji Kolegiji { get; set; }
        public virtual Tip_instrukcija Tip_instrukcija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Termini> Termini { get; set; }
    }
}
