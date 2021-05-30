using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public static class RepozitorijTermina
    {
        public static List<Termin> ListaTermina { get; set; }

        public static void PopuniListuTermina()
        {
            ListaTermina = new List<Termin>();

            using (var context = new Entities())
            {
                List<Termini> terminiBaza = context.Termini.ToList();

                foreach (var termin in terminiBaza)
                {
                    // ListaTermina.Add (new Termin(...
                }
            }
        }
    }
}
