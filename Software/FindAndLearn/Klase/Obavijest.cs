using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    public class Obavijest
    {
        public int Id { get; set; }
        public Termin Termin { get; set; }

        [DisplayName("Naslov")]
        public string NazivObavijesti { get; set; }

        public string OpisObavijesti { get; set; }

        [DisplayName("Datum obavijesti")]
        public DateTime DatumObavijesti { get; set; }

        public Obavijest()
        {

        }

        public Obavijest(int id, Termin termin, string naziv, string opis, DateTime datumObavijesti)
        {
            Id = id;
            Termin = termin;
            NazivObavijesti = naziv;
            OpisObavijesti = opis;
            DatumObavijesti = datumObavijesti;
        }

    }
}
