using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KorisniciLib;

namespace FindAndLearn.Klase
{
    public static class RepozitorijKorisnika
    {
        public static List<Korisnik> ListaKorisnika { get; set; }


        // Metodom PopuniListu stvara se kopija liste korisnika iz baze podataka 
        // Svrha: Svesti rad s bazom na minimum i stvoriti jedinstven popis svih korisnika (instruktora i studenata)

        public static void PopuniListu()
        {
            using (var context = new Entities())
            {
                List<Studenti> studenti = context.Studenti.ToList();
                List<Instruktori> instruktori = context.Instruktori.ToList();
                ListaKorisnika = new List<Korisnik>();

                foreach (var item in studenti)
                {
                    ListaKorisnika.Add(
                    new Student
                    {
                        Ime = item.ime,
                        Prezime = item.prezime,
                        KorisnickoIme = item.korisnicko_ime,
                        Lozinka = item.lozinka,
                        Email = item.email,
                        Mjesto = item.mjesto,
                        Ulica = item.ulica,
                        Mobitel = item.mobitel,
                        Slika = item.slika,
                        Opis = item.opis,
                        Uloga = Uloga.Student
                    });
                }

                foreach (var item in instruktori)
                {
                    ListaKorisnika.Add(
                    new Instruktor
                    {
                        Ime = item.ime,
                        Prezime = item.prezime,
                        KorisnickoIme = item.korisnicko_ime,
                        Lozinka = item.lozinka,
                        Email = item.email,
                        Mjesto = item.mjesto,
                        Ulica = item.ulica,
                        Mobitel = item.mobitel,
                        Slika = item.slika,
                        Opis = item.opis,
                        Titula = item.titula,
                        Uloga = Uloga.Instruktor
                    });
                }
            }
        }

        public static Korisnik DohvatiKorisnika(string korisnickoIme, string lozinka)
        {
            // Dohvaća se uvijek lista s najnovijim podacima
            PopuniListu(); 
            Korisnik korisnik = ListaKorisnika.Find(x => (x.KorisnickoIme == korisnickoIme) && (x.Lozinka == lozinka));
            return korisnik;

        }

        public static bool PostojiKorisnik(string korisnickoIme)
        {
            PopuniListu();
            return ListaKorisnika.Exists(x => (x.KorisnickoIme == korisnickoIme));
        }

        public static void AzurirajLozinku(Korisnik korisnik)
        {
            //Ažuriranje se temelji na dohvaćanju korisničkog imena kako u bazi ne postoje dva korisnika s istim korisničkim imenom

            using (var context = new Entities())
            {
                if(korisnik.Uloga == Uloga.Instruktor)
                {
                   Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(x => (x.korisnicko_ime == korisnik.KorisnickoIme));
                   instruktorBaza.lozinka = korisnik.Lozinka;

                   context.SaveChanges();

                }
                else if(korisnik.Uloga == Uloga.Student)
                {
                    Studenti studentBaza = context.Studenti.FirstOrDefault(x => (x.korisnicko_ime == korisnik.KorisnickoIme));
                    studentBaza.lozinka = korisnik.Lozinka;

                    context.SaveChanges();
                }
            }
        }
        public static void AzurirajInstruktora(Instruktor instruktor)
        {

            using (var context = new Entities())
            {
                    Instruktori instruktorBaza = context.Instruktori.FirstOrDefault(x => (x.korisnicko_ime == instruktor.KorisnickoIme));

                    instruktorBaza.ime = instruktor.Ime;
                    instruktorBaza.prezime = instruktor.Prezime;
                    instruktorBaza.korisnicko_ime = instruktor.KorisnickoIme;
                    instruktorBaza.lozinka = instruktor.Lozinka;
                    instruktorBaza.email = instruktor.Email;
                    instruktorBaza.mjesto = instruktor.Mjesto;
                    instruktorBaza.ulica = instruktor.Ulica;
                    instruktorBaza.mobitel = instruktor.Mobitel;
                    instruktorBaza.opis = instruktor.Opis;
                    instruktorBaza.titula = instruktor.Titula;
                  //  instruktorBaza.slika = instruktor.Slika;

                    context.SaveChanges();
            }
        }

        public static void AzurirajStudenta(Student student)
        {
            using (var context = new Entities())
            {
                Studenti studentBaza = context.Studenti.FirstOrDefault(x => (x.korisnicko_ime == student.KorisnickoIme));

                studentBaza.ime = student.Ime;
                studentBaza.prezime = student.Prezime;
                studentBaza.korisnicko_ime = student.KorisnickoIme;
                studentBaza.lozinka = student.Lozinka;
                studentBaza.email = student.Email;
                studentBaza.mjesto = student.Mjesto;
                studentBaza.ulica = student.Ulica;
                studentBaza.mobitel = student.Mobitel;
                studentBaza.opis = student.Opis;
              //  studentBaza.slika = student.Slika;

                context.SaveChanges();
            }
        }
    }
}
