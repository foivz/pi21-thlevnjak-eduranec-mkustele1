using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class Recenzija
    {
        public int IdRecenzije { get; set; }
        public Instruktor Instruktor { get; set; }
        public Student Student { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public Recenzija()
        {

        }

        public Recenzija(int id, Instruktor instruktor, Student student, int ocjena, string komentar)
        {
            IdRecenzije = id;
            Instruktor = instruktor;
            Student = student;
            Ocjena = ocjena;
            Komentar = komentar;

        }
    }
}
