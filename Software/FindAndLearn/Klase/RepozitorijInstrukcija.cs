using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.Klase
{
    public static class RepozitorijInstrukcija
    {
        public static List<Instrukcija> ListaInstrukcija { get; set; }

        public static Instrukcija KreirajInstrukciju()
        {
            Instrukcija novaInstrukcija = new Instrukcija();
            return novaInstrukcija;
        }

        public static List<Kolegij> PopuniPopisKolegija()
        {
            List<Kolegij> ListaKolegija = new List<Kolegij>();

            using (var context = new Entities())
            {
                List<Kolegiji> kolegijiBaza = context.Kolegiji.ToList();

                foreach (var item in kolegijiBaza)
                {
                    ListaKolegija.Add(new Kolegij(item.ID_kolegija, item.naziv_kolegija, item.godina_kolegija));
                }
            }

            return ListaKolegija;
        }

        public static List<TipInstrukcije> PopuniPopisTipovaInstrukcija()
        {
            List<TipInstrukcije> ListaTipovaInstrukcije = new List<TipInstrukcije>();

            using (var context = new Entities())
            {
                List<Tip_instrukcija> tipInstrukcijeBaza = context.Tip_instrukcija.ToList();

                foreach (var item in tipInstrukcijeBaza)
                {
                    ListaTipovaInstrukcije.Add(new TipInstrukcije(item.ID_tip_instrukcije, item.naziv_tipa));
                }

                return ListaTipovaInstrukcije;

            }
        }

        public static List<Instrukcija> PopuniPopisInstrukcija()
        {
            List<Instrukcija> ListaInstrukcija = new List<Instrukcija>();

            using (var context = new Entities())
            {
                List<Instrukcije> instrukcije = context.Instrukcije.ToList();
                foreach (var item in instrukcije)
                {
                    List<Kolegij> kolegiji = PopuniPopisKolegija();
                    List<TipInstrukcije> tip = PopuniPopisTipovaInstrukcija();

                    Kolegij kolegij = kolegiji.Find(k => k.Id == item.kolegij_id);
                    TipInstrukcije tipInstrukcije = tip.Find(t => t.Id == item.tip_instrukcije_id);

                    Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(k => k.ID_instruktora == item.instruktor_id);

                    List<Korisnik> korisnici = RepozitorijKorisnika.PopuniListu();
                    Instruktor instruktor = korisnici.Find(i => i.KorisnickoIme == instruktorBaza.korisnicko_ime) as Instruktor;

                    ListaInstrukcija.Add(new Instrukcija(item.ID_instrukcije, instruktor, tipInstrukcije, kolegij, item.opis_instrukcije, item.cijena_instrukcije));
                }

                return ListaInstrukcija;
            }
        }
        public static void DodajInstrukciju(Instrukcija instrukcija)
        {
            if (instrukcija.OpisInstrukcije != "" && instrukcija.CijenaInstrukcije != 0)
            {
                using (var entities = new Entities())
                {
                    Instrukcije novaInstrukcija = new Instrukcije
                    {
                        instruktor_id = instrukcija.Instruktor.ID_instruktora,
                        tip_instrukcije_id = instrukcija.TipInstrukcije.Id,
                        kolegij_id = instrukcija.Kolegij.Id,
                        opis_instrukcije = instrukcija.OpisInstrukcije,
                        cijena_instrukcije = instrukcija.CijenaInstrukcije
                    };
                    entities.Instrukcije.Add(novaInstrukcija);
                    entities.SaveChanges();
                }
            }

            else
            {
                MessageBox.Show("Molimo vas da popunite sva polja za dodavanje instrukcije!");
            }
        }

        internal static void ObrisiInstrukciju(int idInstrukcije)
        {
            using (var entities=new Entities())
            {
                var instrukcija = (from ins in entities.Instrukcije
                                   where ins.ID_instrukcije == idInstrukcije
                                   select ins).Single();
                Instrukcije instrukcijaBrisanje = instrukcija as Instrukcije;

                entities.Instrukcije.Attach(instrukcijaBrisanje);
                if(instrukcijaBrisanje.Termini.Count==0)
                {
                    entities.Instrukcije.Remove(instrukcijaBrisanje);
                    entities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nije moguće obrisati instrukciju s terminima!");
                }
            }
        }
    }
}
