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
    
    public partial class Obavijesti
    {
        public int ID_obavijesti { get; set; }
        public int termin_id { get; set; }
        public string naziv_obavijesti { get; set; }
        public string opis_obavijesti { get; set; }
        public System.DateTime datum_obavijesti { get; set; }
    
        public virtual Termini Termini { get; set; }
    }
}