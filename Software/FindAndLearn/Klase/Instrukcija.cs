using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VrsteKolegijaLib;

namespace FindAndLearn.Klase
{
   
    public class Instrukcija
    {
        public int Id { get; set; }
        public TipInstrukcije TipInstrukcije { get; set; }
        public Kolegij Kolegij { get; set; }
        public string OpisInstrukcije { get; set; }
        public double CijenaInstrukcije { get; set; }

        public Instruktor Instruktor { get; set; }


        public Instrukcija()
        {

        }

        public Instrukcija(int id, Instruktor instruktor, TipInstrukcije tipInstrukcije, Kolegij kolegij, string opisInstrukcije, double cijenaInstrukcije)
        {
            Id = id;
            TipInstrukcije = tipInstrukcije;
            Instruktor = instruktor;
            Kolegij = kolegij;
            OpisInstrukcije = opisInstrukcije;
            CijenaInstrukcije = cijenaInstrukcije;

        }
    }
}
