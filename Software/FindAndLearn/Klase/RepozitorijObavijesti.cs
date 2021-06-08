using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public static class RepozitorijObavijesti
    {

        public static List<Obavijest> PopuniListuObavijesti(Termin termin)
        {
            List<Obavijesti> obavijestiBaza = null;
            List<Obavijest> listaObavijesti = new List<Obavijest>();

            using (var context = new Entities())
            {
                var upitObavijesti = from o in context.Obavijesti
                           where o.termin_id == termin.Id
                           select o;

                obavijestiBaza = upitObavijesti.ToList();

                foreach (var item in obavijestiBaza)
                {
                    listaObavijesti.Add(new Obavijest(item.ID_obavijesti, termin, item.naziv_obavijesti, item.opis_obavijesti, item.datum_obavijesti));
                }
            }

            return listaObavijesti;
        }

        public static void DodajObavijest(Obavijest obavijest)
        {
            using (var context = new Entities())
            {
                Obavijesti novaObavijest = new Obavijesti()
                {
                    termin_id = obavijest.Termin.Id,
                    naziv_obavijesti = obavijest.NazivObavijesti,
                    opis_obavijesti = obavijest.OpisObavijesti,
                    datum_obavijesti = obavijest.DatumObavijesti
                };

                context.Obavijesti.Add(novaObavijest);
                context.SaveChanges();
            }
        }

        public static void AzurirajObavijest(Obavijest obavijest)
        {
            using (var context = new Entities())
            {
                var upit = from o in context.Obavijesti
                           where o.ID_obavijesti == obavijest.Id
                           select o;

                Obavijesti obavijestBaza = upit.Single();

                obavijestBaza.naziv_obavijesti = obavijest.NazivObavijesti;
                obavijestBaza.opis_obavijesti = obavijest.OpisObavijesti;
                obavijestBaza.datum_obavijesti = obavijest.DatumObavijesti;

                context.SaveChanges();
            }
        }
    }
}
