using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public static class RepozitorijKolegija
    {
        public static List<Kolegij> ListaKolegija { get; set; }

        //jedinstveni repozitorij koji iz baze povlaci sve kolegije i prikazuje korisniknu na odabir moguće kolegije
        
        public static List<Kolegij> DohvatiKolegije()
        {
          
            using (var entities = new Entities())
            {

                List<Kolegiji> kolegiji = entities.Kolegiji.ToList();
                

                foreach (var item in kolegiji)
                {
                    ListaKolegija.Add(
                        new Kolegij
                        {
                            NazivKolegija = item.naziv_kolegija,
                            GodinaKolegija = item.godina_kolegija
                        }) ;
                }
               
            }
            return ListaKolegija;
        }





    }
}
