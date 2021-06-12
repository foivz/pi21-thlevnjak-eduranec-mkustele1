using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KorisniciLib;
using FindAndLearn.Iznimke;
using FindAndLearn.Klase;

namespace FindAndLearn.Klase
{
    public static class Autentifikator
    {

        // Metoda prijava provjerava ispravnost unosa (prazan unos, postojece korisnicko ime ili neispravnu lozinku)
        // U slučaju da je prijava ispravna dohvaća podatke o korisniku, u suprotnom vraća poruku greške, tj. baca iznimku

        public static Korisnik Prijava(string korisnickoIme, string lozinka)
        {
            Korisnik korisnikPrijava = null;

            ProvjeriPrazanUnosPrijave(korisnickoIme, lozinka);


            bool postojiKorisnik = RepozitorijKorisnika.PostojiKorisnik(korisnickoIme);

            // 1. Slučaj: Ne postoji korisničko ime u bazi podataka

            if (postojiKorisnik == false)
            {
                throw new UnosException($"Neuspješna prijava! Ne postoji korisnik s korisničkim imenom {korisnickoIme}!");
            }

            // 2. Slučaj: Postoji korisničko ime u bazi podataka

            else if (postojiKorisnik == true)
            {

                // 2.1. Dohvaća se korisnik (ispravno korisničko ime i lozinka)

                korisnikPrijava = RepozitorijKorisnika.DohvatiKorisnika(korisnickoIme, lozinka);

                // 2.2. Baca se iznimka (pogrešna lozinka)

                if (korisnikPrijava == null)
                {
                    throw new UnosException($"Neuspješna prijava! Pogrešna lozinka za {korisnickoIme}!");
                }
            }
            return korisnikPrijava;
        }

        public static void ProvjeriPrazanUnosPrijave(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme == "" || lozinka == "")
            {
                throw new UnosException("Neuspješna prijava! Niste popunili sva polja!");
            }
        }

        public static bool ProvjeriPromjenuLozinke(string trenutnaLozinka, string novaLozinka, string ponovljenaLozinka)
        {
            bool ispravnaLozinka = true;

            if (novaLozinka == "" || ponovljenaLozinka == "")
            {
                throw new UnosException("Neuspješna prijava! Niste popunili polja za lozinke!");
            }
            else if (trenutnaLozinka == novaLozinka)
            {
                throw new UnosException("Trenutna lozinka i nova lozinka su jednake!");
            }
            else if (novaLozinka != ponovljenaLozinka)
            {
                throw new UnosException($"Nova lozinka i ponovljena lozinka nisu jednake!");
            }

            return ispravnaLozinka;
        }

        public static bool ProvjeriKorisnickoIme(string korisnickoIme)
        {
            bool postojiKorisnik = RepozitorijKorisnika.PostojiKorisnik(korisnickoIme);

            if (postojiKorisnik == true)
            {
                throw new UnosException($"Već postoji korisnik s korisničkim imenom {korisnickoIme}!");
            }
            return postojiKorisnik;
        }

        public static bool ProvjeriObavezanUnosProfil(string ime, string prezime, string korisnickoIme, string email)
        {
            bool ispravanUnos = true;

            if (korisnickoIme == "" || prezime == "" || ime == "" || email == "")
            {
                throw new UnosException("Nisu uneseni svi obavezni podaci označeni s *");
            }

            ProvjeriEmailAdresu(email);

            return ispravanUnos;
        }

        public static Korisnik Registracija(Uloga uloga, string ime, string prezime, string korisnickoIme, string lozinka, string ponovljenaLozinka, string email, string mobitel, string mjesto, string ulica, string opis, string titula = null)
        {
            Korisnik korisnikRegistracija = null;

            ProvjeriPrazanUnosRegistracije(ime, prezime, korisnickoIme, lozinka, ponovljenaLozinka, email);

            bool postojiKorisnik = RepozitorijKorisnika.PostojiKorisnik(korisnickoIme);

            // 1. slučaj: Već postoji korisničko ime u bazi podataka
            if (postojiKorisnik == true)
            {
                throw new UnosException($"Neuspješna registracija! Već postoji korisnik s korisničkim imenom {korisnickoIme}!");
            }

            // 2. slučaj: Ne postoji korisničko ime u bazi podataka
            else if (postojiKorisnik == false && ProvjeriLozinkeRegistracije(lozinka, ponovljenaLozinka) == true && ProvjeriEmailAdresu(email) == true)
            {
                // 2.1. Dodaje se korisnik (ispravni parametri i izvršena validacija obrasca)
                korisnikRegistracija = RepozitorijKorisnika.DodajKorisnika(uloga, ime, prezime, korisnickoIme, lozinka, email, mobitel, mjesto, ulica, opis, titula);
            }

            return korisnikRegistracija;
        }

        public static void ProvjeriPrazanUnosRegistracije(string ime, string prezime, string korisnickoIme, string lozinka, string ponovljenaLozinka, string email)
        {
            if (ime == "" || prezime == "" || korisnickoIme == "" || lozinka == "" || ponovljenaLozinka == "" || email == "")
            {
                throw new UnosException("Neuspješna registracija! Niste popunili tražena polja! (Označena zvjezdicom *)");
            }
        }

        public static bool ProvjeriLozinkeRegistracije(string lozinka, string ponovljenaLozinka)
        {
            if (lozinka != ponovljenaLozinka)
            {
                throw new UnosException("Neuspješna registracija! Lozinka i ponovljena lozinka se ne poklapaju!");
            }
            else
            {
                return true;
            }
        }

        public static bool ProvjeriEmailAdresu(string email)
        {
            if (email.Contains('@'))
            {
                return true;
            }
            else
            {
                throw new UnosException("Neispravan format email adrese!");
            }
        }
    }
}
