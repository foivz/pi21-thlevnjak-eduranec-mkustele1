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
    
    public partial class Poruke
    {
        public int ID_poruke { get; set; }
        public int instruktor_id { get; set; }
        public int student_id { get; set; }
        public string naslov_poruke { get; set; }
        public string sadrzaj { get; set; }
        public System.DateTime datum { get; set; }
    
        public virtual Instruktori Instruktori { get; set; }
        public virtual Studenti Studenti { get; set; }
    }
}
