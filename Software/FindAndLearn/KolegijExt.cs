using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn
{
    public partial class Kolegiji
    {
        public decimal ProsjecnaOcjena { get; set; }

        public decimal IzracunProsjecneOcjene(Instruktori instruktor)
        {
            int[] ocjene;

            using (var context = new Entities())
            {
                var upit = from rec in context.Recenzije
                           where rec.instruktor_id == instruktor.ID_instruktora
                           select rec.ocjena;

                ocjene = upit.ToArray();

                decimal suma = 0;
                for (int i = 0; i < ocjene.Length; i++)
                {
                    suma += ocjene[i];
                }
                
                ProsjecnaOcjena = suma / ocjene.Length;                
            }
            return ProsjecnaOcjena;
        }

        public override string ToString()
        {
            return this.naziv_kolegija;
        }
    }
}
