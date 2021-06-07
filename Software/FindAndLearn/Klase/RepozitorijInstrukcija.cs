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

        public static void DodajInstrukciju(Instrukcija instrukcija)
        {
            if (instrukcija.OpisInstrukcije != "" && instrukcija.CijenaInstrukcije != 0)
            {
                using (var entities = new Entities())
                {


                    Instrukcije novaInstrukcija = new Instrukcije
                    {
                        instruktor_id = instrukcija.Instruktor,
                        tip_instrukcije_id = instrukcija.TipInstrukcije,
                        kolegij_id = instrukcija.Kolegij,
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
