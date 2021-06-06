using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            using (var entities=new Entities())
            {
                Instrukcije novaInstrukcija = new Instrukcije
                {
                    instruktor_id = instrukcija.Instruktor,
                    tip_instrukcije_id = instrukcija.TipInstrukcije,
                    kolegij_id = instrukcija.Kolegij,
                    opis_instrukcije = instrukcija.OpisInstrukcije,
                    cijena_instrukcije=instrukcija.CijenaInstrukcije
                };
                entities.Instrukcije.Add(novaInstrukcija);
                entities.SaveChanges();
            }
        }




    }
}
