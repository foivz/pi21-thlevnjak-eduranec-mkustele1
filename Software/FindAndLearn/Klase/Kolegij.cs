using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class Kolegij
    {
        public int Id { get; set; }
        public string NazivKolegija { get; set; }
        public int GodinaKolegija { get; set; }

        public Kolegij()
        {


        }


        public Kolegij(int id, string nazivKolegija, int godinaKolegija)
        {
            Id = id;
            NazivKolegija = nazivKolegija;
            GodinaKolegija = godinaKolegija;
        }

        public override string ToString()
        {
            return NazivKolegija;
        }
    }
}
