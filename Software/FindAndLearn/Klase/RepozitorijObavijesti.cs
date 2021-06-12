using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public static class RepozitorijObavijesti
    {

        public static List<Obavijest> PopuniListuTrenutnihObavijesti(Termin termin)
        {
            List<Obavijesti> obavijestiBaza = null;
            List<Obavijest> listaObavijesti = new List<Obavijest>();

            using (var context = new Entities())
            {
                var upitObavijesti = from o in context.Obavijesti
                                     where o.Termini.vrijeme_termina >= DateTime.Now && o.termin_id == termin.IdTermina
                                     select o;

                obavijestiBaza = upitObavijesti.ToList();

                foreach (var item in obavijestiBaza)
                {
                    listaObavijesti.Add(new Obavijest(item.ID_obavijesti, termin, item.naziv_obavijesti, item.opis_obavijesti, item.datum_obavijesti));
                }
            }

            return listaObavijesti;
        }

        public static List<Obavijest> PopuniListuProslihObavijesti(Instruktor instruktor)
        {
            List<Obavijesti> obavijestiBaza = null;
            List<Obavijest> listaObavijesti = new List<Obavijest>();

            using (var context = new Entities())
            {
                var upitObavijesti = from o in context.Obavijesti
                                     where o.Termini.vrijeme_termina < DateTime.Now && instruktor.KorisnickoIme == o.Termini.Instrukcije.Instruktori.korisnicko_ime
                                     select o;

                obavijestiBaza = upitObavijesti.ToList();

                List<Termin> listaTermina = RepozitorijTermina.PopuniListuTermina();

                foreach (var item in obavijestiBaza)
                {
                    Termin termin = listaTermina.Find(x => x.IdTermina == item.termin_id);

                    if(termin != null)
                    {
                       listaObavijesti.Add(new Obavijest(item.ID_obavijesti, termin, item.naziv_obavijesti, item.opis_obavijesti, item.datum_obavijesti));
                    }
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
