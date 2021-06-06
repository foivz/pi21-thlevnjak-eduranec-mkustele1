using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public  class TipInstrukcije
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public TipInstrukcije()
        {


        }

        public static List<TipInstrukcije> tipoviInstrukcija;
        /*public List<TipInstrukcije> DohvatiTipove()
        {
            using(var entitites =new Entities())
            {
                List<Tip_instrukcija> tipoviBaza = entitites.Tip_instrukcija.ToList();
                foreach (var item in tipoviBaza)
                {
                    tipoviInstrukcija.Add(
                        new TipInstrukcije
                        {
                            ID=
                        })
                }
            }
        }
        */
        
    }
}
