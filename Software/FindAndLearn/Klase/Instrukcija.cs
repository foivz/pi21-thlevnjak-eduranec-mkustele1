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
        public int TipInstrukcije { get; set; }
        public int Kolegij { get; set; }
        public string OpisInstrukcije { get; set; }
        public double CijenaInstrukcije { get; set; }

        public int Instruktor { get; set; }


        public Instrukcija()
        {

        }

        public Instrukcija(int instruktor, int tipInstrukcije, int kolegij, string opisInstrukcije, double cijenaInstrukcije)
        {
            TipInstrukcije = tipInstrukcije;
            Instruktor = instruktor;
            Kolegij = kolegij;
            OpisInstrukcije = opisInstrukcije;
            CijenaInstrukcije = cijenaInstrukcije;

        }
    }
}
