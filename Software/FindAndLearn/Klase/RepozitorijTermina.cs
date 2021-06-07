using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public static class RepozitorijTermina
    {
        public static List<Termin> PopuniListuTermina()
        {
            List<Termin> listaTermina = new List<Termin>();
            List<Termini> terminiBaza = null;

            using (var context = new Entities())
            {
                terminiBaza = context.Termini.ToList();

                var upit = from t in context.Termini
                           select t.Instrukcije;
            }


            foreach (var termin in terminiBaza)
            {
                List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();
                Instrukcija instrukcija = listaInstrukcija.Find(ins => ins.Id == termin.instrukcija_id);

                listaTermina.Add(new Termin (termin.ID_termina, instrukcija, termin.naziv_termina, termin.vrijeme_termina, termin.trajanje,
                                            termin.mjesto_odrzavanja, termin.kapacitet_termina));
            }

            return listaTermina;
        }
    }
}
