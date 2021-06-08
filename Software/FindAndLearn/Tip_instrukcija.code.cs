using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn
{
    public partial class Tip_instrukcija
    {
        public override string ToString()
        {
            return naziv_tipa + " (" + naziv_tipa.Substring(0, 3).ToUpper() + ")";
        }
    }
}
