using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Iznimke
{
    public class UnosException : ApplicationException
    {
        public string Poruka { get; set; }
        public UnosException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
