using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn
{
    public partial class Poruke
    {
        public string ImePrezime { get; set; }

        public override string ToString()
        {
            return ImePrezime;
        }
    }
}
