using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Iznimke
{
    class UnosTerminaException:ApplicationException
    {
        public string Poruka { get; set; }
        public UnosTerminaException(string message)
        {
            Poruka = message;
        }
    }
}
