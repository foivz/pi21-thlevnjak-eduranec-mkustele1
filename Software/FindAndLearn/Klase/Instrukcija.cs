using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
   
    public class Instrukcija
    {
        public TipInstrukcije TipInstrukcije { get; set; }
        public Kolegij Kolegij { get; set; }
        public string OpisInstrukcije { get; set; }
        public double CijenaInstrukcije { get; set; }

        public Instruktor Instruktor { get; set; }

        public Instrukcija(Instruktor instruktor, TipInstrukcije tipInstrukcije, Kolegij kolegij, string opisInstrukcije, double cijenaInstrukcije)
        {
            TipInstrukcije = tipInstrukcije;
            Instruktor = instruktor;
            Kolegij = kolegij;
            OpisInstrukcije = opisInstrukcije;
            CijenaInstrukcije = cijenaInstrukcije;

        }
    }
}
