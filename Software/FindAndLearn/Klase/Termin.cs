using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class Termin
    {
        public int IdTermina { get; set; }
        public Instrukcija Instrukcija { get; set; }
        public string NazivTermina { get; set; }
        public DateTime VrijemeTermina { get; set; }
        public int Trajanje { get; set; }
        public string MjestoOdrzavanja { get; set; }
        public int KapacitetTermina { get; set; }


        public Termin (int id, Instrukcija instrukcija, string naziv, DateTime vrijeme, int trajanje, string mjesto, int kapacitet)
        {
            IdTermina = id;
            Instrukcija = instrukcija;
            NazivTermina = naziv;
            VrijemeTermina = vrijeme;
            Trajanje = trajanje;
            MjestoOdrzavanja = mjesto;
            KapacitetTermina = kapacitet;
        }

        public Termin()
        {
        }


        public override string ToString()
        {
            return NazivTermina;
        }

    }
}
