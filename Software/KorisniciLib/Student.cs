using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorisniciLib
{
    public class Student : Korisnik
    {
        public Image Slika { get; set; }
        public Student()
        {

        }

        public Student(string ime, string prezime, string korisnickoIme, string lozinka, string email) : base(ime, prezime, korisnickoIme, lozinka, email, Uloga.Student)
        {

        }
    }
}
