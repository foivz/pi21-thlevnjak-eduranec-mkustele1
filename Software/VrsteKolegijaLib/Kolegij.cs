using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrsteKolegijaLib
{
    public class Kolegij
    {
        public int Id { get; set; }
        public string NazivKolegija { get; set; }
        public int GodinaKolegija { get; set; }
        public decimal ProsjecnaOcjena { get; set; }

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
