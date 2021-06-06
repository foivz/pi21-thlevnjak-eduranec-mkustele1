using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class Kolegij
    {
        public string NazivKolegija { get; set; }
        public int GodinaKolegija { get; set; }

        public Kolegij()
        {


        }


        public Kolegij(string nazivKolegija, int godinaKolegija)
        {
            NazivKolegija = nazivKolegija;
            GodinaKolegija = godinaKolegija;
        }
    }
}
