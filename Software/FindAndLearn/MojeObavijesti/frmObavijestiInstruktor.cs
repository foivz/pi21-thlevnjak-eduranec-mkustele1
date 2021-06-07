using FindAndLearn.Klase;
using KorisniciLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindAndLearn.MojeObavijesti
{
    public partial class frmObavijestiInstruktor : Form
    {
        Instruktor postojeciInstruktor = null;
        List<Obavijest> dohvaceneObavijesti;

        List<Termin> listaTermina = RepozitorijTermina.PopuniListuTermina();
        List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();

        public frmObavijestiInstruktor(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
            PopuniTermineInstruktora();
        }

        private void frmObavijestiInstruktor_Load(object sender, EventArgs e)
        {

        }

        public string[] PretvoriDatumUPolje(DateTime datumVrijeme)
        {
            string[] datum = datumVrijeme.ToShortDateString().Split('.');
            return datum;
        }


        public void PopuniTermineInstruktora()
        {
            foreach (var instrukcija in listaInstrukcija)
            {
               // termini.Add (new listaTermina.Find(x => x.Instrukcija.Id == instrukcija.Id && instrukcija.Instruktor.ID_instruktora == postojeciInstruktor.ID_instruktora));

                comboPopisTermina.DataSource = listaTermina.ToList();
            }
        }

        public Termin DohvatiTermin()
        {
            Termin odabraniTermin = null;
            if (comboPopisTermina.SelectedItem != null)
            {
                odabraniTermin = comboPopisTermina.SelectedItem as Termin;
            }
            return odabraniTermin;
        }

        private Obavijest DohvatiObavijest()
        {
            Obavijest odabranaObavijest = null;
            if (dgvPopisObavijesti.CurrentRow != null)
            {
                odabranaObavijest = dgvPopisObavijesti.CurrentRow.DataBoundItem as Obavijest;
            }
            return odabranaObavijest;
        }

        public List<Obavijest> FiltrirajObavijestiPoDatumu(DateTime odDatuma, DateTime doDatuma)
        {
            List<Obavijest> filtriraneObavijesti = new List<Obavijest>();

            foreach (var item in dohvaceneObavijesti)
            {
                string[] datumObavijesti = PretvoriDatumUPolje(item.DatumObavijesti);
                string[] datumOd = PretvoriDatumUPolje(odDatuma);
                string[] datumDo = PretvoriDatumUPolje(doDatuma);

                bool datumOdURasponu = UsporediDatume(datumObavijesti, datumOd);
                bool datumDoURasponu = UsporediDatume(datumDo, datumObavijesti);

                if (datumOdURasponu == true && datumDoURasponu == true)
                {
                    filtriraneObavijesti.Add(item);
                }
            }
            return filtriraneObavijesti;
        }

        public List<Obavijest> PretraziObavijestiPoNaslovu(string naslov)
        {
            List<Obavijest> pronadjeneObavijesti = new List<Obavijest>();
            string pretraga = naslov;
            string[] pretvorbaPretrage = pretraga.Split(' ');
            foreach (var rijec in pretvorbaPretrage)
            {
                foreach (var obavijest in dohvaceneObavijesti)
                {
                    if (obavijest.NazivObavijesti.Contains(rijec))
                    {
                        pronadjeneObavijesti.Add(obavijest);
                    }
                }
            }
            return pronadjeneObavijesti;
        }

        private bool UsporediDatume(string[] veciDatum, string[] manjiDatum)
        {

            bool datumURasponu = false;

            int danVeci = int.Parse(veciDatum[0]);
            int mjesecVeci = int.Parse(veciDatum[1]);
            int godinaVeca = int.Parse(veciDatum[2]);

            int danManji = int.Parse(manjiDatum[0]);
            int mjesecManji = int.Parse(manjiDatum[1]);
            int godinaManja = int.Parse(manjiDatum[2]);

            if ((godinaVeca > godinaManja))
            {
                datumURasponu = true;
            }

            else if (godinaVeca == godinaManja)
            {
                if (mjesecVeci > mjesecManji)
                {
                    datumURasponu = true;
                }

                else if (mjesecVeci == mjesecManji)
                {
                    if (danVeci >= danManji)
                    {
                        datumURasponu = true;
                    }
                }
            }
            return datumURasponu;
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            frmKreirajObavijesti form = new frmKreirajObavijesti(postojeciInstruktor);
            form.ShowDialog();
            Close();
        }
    }
}
