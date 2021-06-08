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
                           where o.termin_id == termin.IdTermina
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
                    termin_id = obavijest.Termin.IdTermina,
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
               List<Obavijesti> obavijesti = context.Obavijesti.ToList();
               Obavijesti obavijestBaza = obavijesti.FirstOrDefault(x => x.ID_obavijesti == obavijest.Id);

               obavijestBaza.naziv_obavijesti = obavijest.NazivObavijesti;
               obavijestBaza.opis_obavijesti = obavijest.OpisObavijesti;
               obavijestBaza.datum_obavijesti = obavijest.DatumObavijesti;

               context.SaveChanges();
            }
        }

        public static string ProvjeraDatuma(DateTime odDatuma, DateTime doDatuma)
        {
            string poruka = "";

            if(odDatuma.Date > doDatuma.Date)
            {
                poruka = "Zadan nepostojeći raspon (od - do)! Datum 'Od' ne može biti kasniji od datuma 'Do'.";
            }

            return poruka;
        }
    }
}
