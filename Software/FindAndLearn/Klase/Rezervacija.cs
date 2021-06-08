using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class Rezervacija
    {
        public int IdRezervacije { get; set; }
        public Student Student { get; set; }
        public Termin Termin { get; set; }
        public DateTime RokRezervacije { get; set; }
        public DateTime DatumRezervacije { get; set; }
        public bool Potvrdjena { get; set; }
        public int ID_rezervacija { get; }
        public DateTime Rok_rezervacije { get; }
        public DateTime Datum_rezervacije { get; }

        public Rezervacija()
        {

        }

        public Rezervacija(int iD_rezervacija, Student student, Termin termin, DateTime rok_rezervacije, DateTime datum_rezervacije, bool potvrdjena)
        {
            ID_rezervacija = iD_rezervacija;
            Student = student;
            Termin = termin;
            Rok_rezervacije = rok_rezervacije;
            Datum_rezervacije = datum_rezervacije;
            Potvrdjena = potvrdjena;
        }
    }
}
