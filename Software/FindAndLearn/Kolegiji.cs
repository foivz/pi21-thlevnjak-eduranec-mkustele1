//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindAndLearn
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kolegiji
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kolegiji()
        {
            this.Instrukcije = new HashSet<Instrukcije>();
        }
    
        public int ID_kolegija { get; set; }
        public string naziv_kolegija { get; set; }
        public int godina_kolegija { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instrukcije> Instrukcije { get; set; }
    }
}
