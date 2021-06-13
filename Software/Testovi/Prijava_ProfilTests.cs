using FindAndLearn.Iznimke;
using FindAndLearn.Klase;
using KorisniciLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testovi
{
    [TestClass]
    public class Prijava_ProfilTests
    {

        /// <summary>
        /// -----------------------------------------------------------------------------
        ///  PODACI ZA TESTIRANJE
        /// -----------------------------------------------------------------------------
        ///  Korisnicko ime |   Lozinka   |  Uloga       | Email                        |
        /// ----------------------------------------------------------------------------|
        ///  mkustele1      | student2000 |  Student     | marija.kustelega@gmail.com   |
        ///  thlevnjak99    | thlevnjak   |  Instruktor  | tomislav.hlevnjak@gmail.com  |
        ///  mhorvat        | lozinka4321 |  Instruktor  | marko.horvat@gmail.com       |
        /// </summary>


        [TestMethod]
        public void Prijava_PrijavaKorisnikaUlogeStudent_UspjesnaPrijava()
        {
            Korisnik korisnik = Autentifikator.Prijava("mkustele1", "student2000");
            Assert.IsNotNull(korisnik);
            Assert.IsTrue(korisnik.Uloga == Uloga.Student);
        }

        [TestMethod]
        public void Prijava_PrijavaKorisnikaUlogeInstruktor_UspjesnaPrijava()
        {
            Korisnik korisnik = Autentifikator.Prijava("thlevnjak99", "thlevnjak");
            Assert.IsNotNull(korisnik);
            Assert.IsTrue(korisnik.Uloga == Uloga.Instruktor);
        }

        [TestMethod]
        public void Prijava_PrijavaNepostojecegKorisnika_BacaIznimku()
        {
            Assert.ThrowsException<UnosException>(() => Autentifikator.Prijava("thlevnjak999", "thlevnjak"));
        }

        [TestMethod]
        public void Prijava_PrijavaPostojecegKorisnikaUzPogresnuLozinku_BacaIznimku()
        {
            Assert.ThrowsException<UnosException>(() => Autentifikator.Prijava("mhorvat", "thlevnjak"));
        }

        [TestMethod]
        public void ProvjeriPromjenuLozinke_NovaIPonovljenaLozinkaNisuJednake_BacaIznimku()
        {
            Assert.IsNotNull(Autentifikator.Prijava("thlevnjak99", "thlevnjak"));
            Assert.ThrowsException<UnosException>(() => Autentifikator.ProvjeriPromjenuLozinke("thlevnjak", "lozinka1998", "student1998"));
        }

        [TestMethod]
        public void ProvjeriPromjenuLozinke_UneseneIspravneLozinke_LozinkaPromijenjena()
        {
            Assert.IsNotNull(Autentifikator.Prijava("thlevnjak99", "thlevnjak"));
            Assert.IsTrue(Autentifikator.ProvjeriPromjenuLozinke("thlevnjak", "lozinka1998", "lozinka1998"));
        }

        [TestMethod]
        public void ProvjeriKorisnickoIme_PostojeceKorisnickoIme_BacaIznimku()
        {
            Assert.ThrowsException<UnosException>(() => Autentifikator.ProvjeriKorisnickoIme("thlevnjak"));
        }

        [TestMethod]
        public void ProvjeriKorisnickoIme_NepostojećeKorisnickoIme_IspravanUnos()
        {
            Assert.IsFalse(Autentifikator.ProvjeriKorisnickoIme("eduranec"));
        }

        [TestMethod]
        public void ProvjeriObavezanUnosProfil_NepostojeciEmail_BacaIznimku()
        {
            Assert.ThrowsException<UnosException>(() => Autentifikator.ProvjeriUnosProfil("marko", "horvat", "mhorvat", "marko.horvatgmail.com", "091/791-8129"));
        }

        [TestMethod]
        public void ProvjeriObavezanUnosProfil_UnesenKriviFormatMobitela_BaciIznimku()
        {
            Assert.ThrowsException<UnosException>(() => Autentifikator.ProvjeriUnosProfil("marko", "", "mhorvat", "mhorvat@com", "385 91 791 8129"));
        }
    }
}
