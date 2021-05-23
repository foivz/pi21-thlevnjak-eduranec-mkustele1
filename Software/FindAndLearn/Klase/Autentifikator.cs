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

            ProvjeriPrazanUnos(korisnickoIme, lozinka);


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

        public static void ProvjeriPrazanUnos(string korisnickoIme, string lozinka)
        {
            if (korisnickoIme == "" || lozinka == "")
            {
                throw new UnosException("Neuspješna prijava! Niste popunili sva polja!");
            }
        }

        public static bool ProvjeriPromjenuLozinke(string novaLozinka, string ponovljenaLozinka)
        {
            bool ispravnaLozinka = true;

            if (novaLozinka != ponovljenaLozinka)
            {
                throw new UnosException($"Lozinka i ponovljena lozinka nisu jednake!");
            }

            return ispravnaLozinka;
        }

        public static void ProvjeriKorisnickoIme(string korisnickoIme)
        {
            bool postojiKorisnik = RepozitorijKorisnika.PostojiKorisnik(korisnickoIme);

            if (postojiKorisnik == true)
            {
                throw new UnosException($"Već postoji korisnik s korisničkim imenom {korisnickoIme}!");
            }
        }
    }
}
