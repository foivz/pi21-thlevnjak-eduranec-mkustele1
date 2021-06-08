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
        List<Termin> listaTermina = RepozitorijTermina.PopuniListuTermina();
        List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();
        List<Obavijest> dohvaceneObavijesti;

        List<Termin> terminiInstruktora;


        public frmObavijestiInstruktor(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
            terminiInstruktora = PopuniTermineInstruktora();
            comboPopisTermina.SelectedIndexChanged += ComboPopisTermina_SelectedIndexChanged;

            comboPopisTermina.DataSource = null;
            comboPopisTermina.DataSource=terminiInstruktora;
        }

        private void ComboPopisTermina_SelectedIndexChanged(object sender, EventArgs e)
        {
            Termin termin = DohvatiTermin();
            dgvPopisObavijesti.DataSource = null;

            if (termin != null)
            {
                dgvPopisObavijesti.DataSource = RepozitorijObavijesti.PopuniListuObavijesti(termin);
                dgvPopisObavijesti.Columns["Id"].Visible = false;
                dgvPopisObavijesti.Columns["OpisObavijesti"].Visible = false;
                dgvPopisObavijesti.Columns[1].Width = 138;
                dgvPopisObavijesti.Columns[2].Width = 250;
                dgvPopisObavijesti.Columns[4].Width = 150;
                dgvPopisObavijesti.SelectionChanged += DgvPopisObavijesti_SelectionChanged;
            }
        }

        private void DgvPopisObavijesti_SelectionChanged(object sender, EventArgs e)
        {
            Obavijest obavijest = DohvatiObavijest();
  
            btnAzurirajObavijest.Enabled = false;

            if (obavijest != null)
            {
                // Obavijest se može mijenjati samo pola sata nakon njezina kreiranja

                DateTime vrijemeObjave = obavijest.DatumObavijesti.AddMinutes(30);

                if (vrijemeObjave >= DateTime.Now)
                {
                    btnAzurirajObavijest.Enabled = true;
                }
                else
                {
                    btnAzurirajObavijest.Enabled = false;
                }
            }

        }

        private void frmObavijestiInstruktor_Load(object sender, EventArgs e)
        {

        }

        public string[] PretvoriDatumUPolje(DateTime datumVrijeme)
        {
            string[] datum = datumVrijeme.ToShortDateString().Split('.');
            return datum;
        }


        public List<Termin> PopuniTermineInstruktora()
        {
            terminiInstruktora = new List<Termin>();

            foreach (var instrukcija in listaInstrukcija)
            {
                if (instrukcija.Instruktor.ID_instruktora == postojeciInstruktor.ID_instruktora)
                {
                    Termin termin = listaTermina.Find(x => x.Instrukcija.Id == instrukcija.Id);

                    if(termin != null)
                    {
                        terminiInstruktora.Add(termin);
                    }
                }
            }

            return terminiInstruktora;
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
            frmKreirajObavijesti form = new frmKreirajObavijesti(terminiInstruktora);
            form.ShowDialog();
        }

        private void btnAzurirajObavijest_Click(object sender, EventArgs e)
        {
            Obavijest obavijest = DohvatiObavijest();

            if(obavijest != null)
            {
                frmAzurirajObavijesti form = new frmAzurirajObavijesti(obavijest);
                form.ShowDialog();
            }
        }
    }
}
