using KorisniciLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndLearn.Klase
{
    class RepozitorijRezervacija
    {
        
        public static Rezervacija KreirajRezervaciju()
        {
            Rezervacija rezervacija = new Rezervacija();
            return rezervacija;
        }

        public static List<Rezervacija> PopuniPopisRezervacija()
        {
            List<Rezervacija> ListaRezervacija = new List<Rezervacija>();

            ;

            using (var entities = new Entities())
            {
                
                List<Rezervacije> rezervacije = entities.Rezervacije.ToList();
                foreach (var item in rezervacije)
                {
                    
                    Studenti studentBaza = entities.Studenti.FirstOrDefault(s => s.ID_studenta == item.student_ID);
                    List<Korisnik> korisnici = RepozitorijKorisnika.PopuniListu();
                    Student student = korisnici.Find(s => s.KorisnickoIme == studentBaza.korisnicko_ime) as Student;

                    List<Termin> termini = PopuniPopisTermina();
                    Termin termin = termini.Find(t => t.IdTermina == item.termin_ID);
                    ListaRezervacija.Add(new Rezervacija(item.ID_rezervacija, student, termin, item.rok_rezervacije, item.datum_rezervacije, item.potvrdjena));

                }

                return ListaRezervacija;
            }
        }

        public static void ZatraziRezervaciju(Rezervacija rezervacija) //ustvari dodaje rezervaciju u bazu kako bi ona bila dostupna instruktoru na uvid i odobrenje
        {

        }
        

        private static List<Termin> PopuniPopisTermina()
        {
           using (var entities = new Entities())
            {
                List<Termini> terminiBaza = entities.Termini.ToList();
                List<Termin> listaTermina = new List<Termin>();
                List<Instrukcije> instrukcijeBaza = entities.Instrukcije.ToList();
                List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();
                foreach(var item in terminiBaza)
                {
                    Instrukcija instrukcija = listaInstrukcija.Find(i => i.Id == item.instrukcija_id);
                    listaTermina.Add(
                        new Termin
                        {
                            IdTermina = item.ID_termina,
                            Instrukcija = instrukcija,
                            NazivTermina=item.naziv_termina,
                            VrijemeTermina=item.vrijeme_termina,
                            Trajanje=item.trajanje,
                            MjestoOdrzavanja=item.mjesto_odrzavanja,
                            KapacitetTermina=item.kapacitet_termina
                        });
                }

                return listaTermina;
            }

        }

        

        

            
        
    }
}
