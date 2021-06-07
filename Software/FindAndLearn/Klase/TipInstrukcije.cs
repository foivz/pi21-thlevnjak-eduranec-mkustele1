using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class TipInstrukcije
    {
        public int Id { get; set; }
        public string NazivTipa { get; set; }

        public TipInstrukcije(int id, string naziv)
        {
            Id = id;
            NazivTipa = naziv;
        }

        public override string ToString()
        {
            return NazivTipa;
        }
    }
}
