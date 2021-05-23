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
            Korisnik korisnik = ListaKorisnika.Find(x => (x.KorisnickoIme == korisnickoIme) && (x.Lozinka == lozinka));
            return korisnik;

        }

        public static bool PostojiKorisnik(string korisnickoIme)
        {
            return ListaKorisnika.Exists(x => (x.KorisnickoIme == korisnickoIme));
        }
    }
}
