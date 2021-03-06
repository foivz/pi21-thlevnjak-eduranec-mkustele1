using FindAndLearn.Iznimke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.Klase
{
    public static class RepozitorijTermina
    {
        public static Termin KreirajTermin()
        {
            Termin termin = new Termin();
            return termin;
        }

        public static void DodajTerminUBazu(Termin noviTermin)
        {
            using (var entities = new Entities())
            {
                Termini noviTerminBaza = new Termini
                {
                    instrukcija_id = noviTermin.Instrukcija.Id,
                    naziv_termina = noviTermin.NazivTermina,
                    vrijeme_termina = noviTermin.VrijemeTermina,
                    trajanje = noviTermin.Trajanje,
                    mjesto_odrzavanja = noviTermin.MjestoOdrzavanja,
                    kapacitet_termina = noviTermin.KapacitetTermina

                };
                entities.Termini.Add(noviTerminBaza);
                entities.SaveChanges();
            }

        }
        public static void ObrisiTermin(int terminId)
        {
            using (var entities = new Entities())
            {
                Termini terminBrisanje = (from ter in entities.Termini
                                          where ter.ID_termina == terminId
                                          select ter).Single();

                entities.Termini.Attach(terminBrisanje);
                if (terminBrisanje.Obavijesti.Count == 0)
                {
                    entities.Termini.Remove(terminBrisanje);
                    entities.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Nije moguće obrisati termin za koji ste poslali obavijest!");
                }

            }
        }

        public static bool ProvjeraIspravnostiUnosaTermina(Termin termin)
        {
            if (termin.VrijemeTermina < DateTime.Now || termin.KapacitetTermina <= 0 || termin.Trajanje <= 0 || termin.NazivTermina =="" || termin.MjestoOdrzavanja=="")
            {
                throw new UnosTerminaException("Za dodavanje termina sva polja trebaju biti korektno popunjena!");
            }
            else return true;


        }
        public static List<Termin> PopuniListuTermina()
        {
            List<Termin> listaTermina = new List<Termin>();
            List<Termini> terminiBaza = null;

            using (var context = new Entities())
            {
                terminiBaza = context.Termini.ToList();

                var upit = from t in context.Termini
                           select t.Instrukcije;
            }


            foreach (var termin in terminiBaza)
            {
                List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();
                Instrukcija instrukcija = listaInstrukcija.Find(ins => ins.Id == termin.instrukcija_id);

                listaTermina.Add(new Termin(termin.ID_termina, instrukcija, termin.naziv_termina, termin.vrijeme_termina, termin.trajanje,
                                            termin.mjesto_odrzavanja, termin.kapacitet_termina));
            }

            return listaTermina;
        }

        /// <summary>
        /// Ova metoda provjerava dostupnost slobodnih mjesta unutar odabranog termina prema IdTermina.
        /// </summary>
        /// <param name="odabraniTerminId"></param>
        /// <returns>True ako postoji slobodnih mjesta ili false ako slobodnih mjesta nema.</returns>
        public static bool ProvjeraKapaciteta(int odabraniTerminId)
        {
            using (var entities = new Entities())
            {
                var termin = (from ter in entities.Termini
                              where ter.ID_termina == odabraniTerminId
                              select ter).Single();

                if (termin.kapacitet_termina < 1)
                {
                    return false;
                }

                else return true;
            }
        }

        public static void DopuniKapacitet(Rezervacije rezervacija)
        {
            if (rezervacija.potvrdjena == false)
            {
                using (var entities = new Entities())
                {
                    var odabraniTermin = (from ter in entities.Termini
                                          where ter.ID_termina == rezervacija.termin_ID
                                          select ter).Single();
                    odabraniTermin.kapacitet_termina = odabraniTermin.kapacitet_termina - 1;
                    entities.SaveChanges();
                }
            }
        }

        public static Termin DohvatiTermin(int idTermina)
        {
            List<Termin> listaTermina = PopuniListuTermina();
            Termin odabraniTermin = (from ter in listaTermina
                                    where ter.IdTermina==idTermina
                                    select ter).Single();
            return odabraniTermin;
        }
    }
}
