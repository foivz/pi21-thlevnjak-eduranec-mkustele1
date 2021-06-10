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
            using(var entities=new Entities())
            {
                Rezervacije novaRezervacijaBaza = new Rezervacije
                {
                    student_ID = rezervacija.Student.ID_studenta,
                    termin_ID = rezervacija.Termin.IdTermina,
                    rok_rezervacije = rezervacija.RokRezervacije,
                    datum_rezervacije = rezervacija.DatumRezervacije,
                    potvrdjena = rezervacija.Potvrdjena

                };
                entities.Rezervacije.Add(novaRezervacijaBaza);
                entities.SaveChanges();
            }
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

        public static void OdobriRezervaciju(Rezervacije rezervacija)
        {
            using(var entities = new Entities())
            {
                Rezervacije rezervacijaIzBaze = (from rez in entities.Rezervacije
                                                where rez.ID_rezervacija == rezervacija.ID_rezervacija
                                                select rez).Single();
                rezervacijaIzBaze.potvrdjena = true;
                entities.SaveChanges();
            }
        }
        /// <summary>
        /// Ova metoda provjerava da li je student prethodno već zatražio rezervaciju za dani termin.
        /// </summary>
        /// <param name="student"></param>
        /// <returns>Vraća true ako je student već zatražio rezervaciju i false ako nije.</returns>
        public static bool ProvjeraPrethodnihRezervacija(Student student, int idTermina)
        {
            bool postoji = false;
            List<Rezervacija> popisRezervacija = PopuniPopisRezervacija();
            foreach (var item in popisRezervacija)
            {
                if(item.Student.ID_studenta==student.ID_studenta && item.Termin.IdTermina==idTermina)
                {
                    postoji = true;
                }

            }
            return postoji;
        }
        

        

            
        
    }
}
