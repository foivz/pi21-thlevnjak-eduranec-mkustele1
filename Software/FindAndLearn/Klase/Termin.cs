using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class Termin
    {
        //public Instrukcije Instrukcije { get; set; }
        public string NazivTermina { get; set; }
        public DateTime VrijemeTermina { get; set; }
        public int Trajanje { get; set; }
        public string MjestoOdrzavanja { get; set; }
        public int KapacitetTermina { get; set; }


      /*  public Termin(Instrukcije instrukcije, DateTime vrijeme)
        {
            VrijemeTermina = vrijeme;
            Instrukcije = instrukcije;
        } */
    }
}
