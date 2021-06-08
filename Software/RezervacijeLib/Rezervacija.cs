using FindAndLearn.Klase;
using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervacijeLib
{
    public class Rezervacija
    { 
        public Student Student { get; set; }
        public Termin Termin { get; set; }
        public DateTime RokRezervacije { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public bool Potvrdjena { get; set; }

        public Rezervacija()
        {

        }
    }
}
