using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public class Instruktor : Korisnik
    {
        public string Titula { get; set; }
        public Image  Slika { get; set; }
        
        public Instruktor()
        {

        }

        public Instruktor(string ime, string prezime, string korisnickoIme, string lozinka, string email) : base(ime, prezime, korisnickoIme, lozinka, email, Uloga.Instruktor)
        {

        }
    }
}
