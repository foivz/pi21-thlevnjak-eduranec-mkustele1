using FindAndLearn.Klase;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testovi
{
    [TestClass]
     public class Instrukcija_TerminTests
    {

        [TestMethod]
        public void Termin_DohvacanjeTerminaIzBaze_UspjesnoDohvacenTermin()
        {
            Termin termin = new Termin();
            termin.IdTermina = 1;
            Assert.IsNotNull(RepozitorijTermina.DohvatiTermin(termin.IdTermina));

        }

        [TestMethod]
        public void Termin_ProvjeraKapacitetaTermina_PostojiMjestoUTermina()
        {
            Termin termin = new Termin();
            termin.IdTermina = 7;
            Assert.IsTrue(RepozitorijTermina.ProvjeraKapaciteta(termin.IdTermina));

        }

        [TestMethod]
        public void Termin_ProvjeraKapacitetaTermina_NePostojiMjestoUTermina()
        {
            Termin termin = new Termin();
            termin.IdTermina = 24;
            Assert.IsFalse(RepozitorijTermina.ProvjeraKapaciteta(termin.IdTermina));

        }

        [TestMethod]
        public void Termin_ProvjeraIspravnostiUnosa_IspravanUnos()
        {

            Termin termin = new Termin();
            List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();
            termin.Instrukcija = listaInstrukcija.FirstOrDefault();
            termin.NazivTermina = "testnitermin";
            termin.VrijemeTermina = DateTime.Now;
            termin.Trajanje = 60;
            termin.KapacitetTermina = 10;
            termin.MjestoOdrzavanja = "Dvorana Test";
            Assert.IsTrue(RepozitorijTermina.ProvjeraIspravnostiUnosaTermina(termin));

        }

    }
}
