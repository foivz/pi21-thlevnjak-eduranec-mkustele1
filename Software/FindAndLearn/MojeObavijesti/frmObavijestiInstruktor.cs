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
             OsvjeziObavijesti();
        }

        public void OsvjeziObavijesti()
        {
            Termin termin = DohvatiTermin();

            if (termin != null)
            {
                dgvPopisObavijesti.DataSource = null;
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
            List<Obavijest> dohvaceneObavijesti = DohvatiSveObavijesti();

            if(dohvaceneObavijesti != null)
            {
                foreach (var item in dohvaceneObavijesti)
                {
                    if (item.DatumObavijesti.Date >= odDatuma.Date && item.DatumObavijesti.Date <= doDatuma.Date)
                    {
                        filtriraneObavijesti.Add(item);
                    }
                }
            }

            return filtriraneObavijesti;
        }

        public List<Obavijest> DohvatiSveObavijesti()
        {
            Termin termin = DohvatiTermin();
            List<Obavijest> dohvaceneObavijesti = new List<Obavijest>();

            if (termin != null)
            {
                dohvaceneObavijesti = RepozitorijObavijesti.PopuniListuObavijesti(termin);
            }

            return dohvaceneObavijesti;
        }

        public List<Obavijest> PretraziObavijestiPoNaslovu(string naslov)
        {
            List<Obavijest> pronadjeneObavijesti = new List<Obavijest>();
            List<Obavijest> dohvaceneObavijesti = DohvatiSveObavijesti();

            if(dohvaceneObavijesti != null)
            {
                string pretraga = naslov;
                string[] pretvorbaPretrage = pretraga.Split(' ');

                foreach (var rijec in pretvorbaPretrage)
                {
                    foreach (var obavijest in dohvaceneObavijesti)
                    {
                        if (obavijest.NazivObavijesti.ToLower().Contains(rijec.ToLower()))
                        {
                            pronadjeneObavijesti.Add(obavijest);
                        }
                    }
                }
            }
            return pronadjeneObavijesti;
        }


        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            frmKreirajObavijesti form = new frmKreirajObavijesti(terminiInstruktora);
            form.ShowDialog();
            OsvjeziObavijesti();
        }

        private void btnAzurirajObavijest_Click(object sender, EventArgs e)
        {
            Obavijest obavijest = DohvatiObavijest();

            if(obavijest != null)
            {
                frmAzurirajObavijesti form = new frmAzurirajObavijesti(obavijest);
                form.ShowDialog();
            }

            OsvjeziObavijesti();
        }

        private void btnProcitaj_Click(object sender, EventArgs e)
        {
            Obavijest obavijest = DohvatiObavijest();

            if (obavijest != null)
            {
                frmProcitajObavijesti form = new frmProcitajObavijesti(obavijest);
                form.ShowDialog();
            }

            OsvjeziObavijesti();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            dgvPopisObavijesti.DataSource = null;
            dgvPopisObavijesti.DataSource = PretraziObavijestiPoNaslovu(txtNaslov.Text);
            dgvPopisObavijesti.Columns["Id"].Visible = false;
            dgvPopisObavijesti.Columns["OpisObavijesti"].Visible = false;
            dgvPopisObavijesti.Columns[1].Width = 138;
            dgvPopisObavijesti.Columns[2].Width = 250;
            dgvPopisObavijesti.Columns[4].Width = 150;
        }

        private void btnPrikaziSveObavijesti_Click(object sender, EventArgs e)
        {
            OsvjeziObavijesti();
        }

        private void btnFiltiraj_Click(object sender, EventArgs e)
        {
            DateTime odDatuma = dtpOd.Value;
            DateTime doDatuma = dtpDo.Value;
            string porukaProvjere = RepozitorijObavijesti.ProvjeraDatuma(odDatuma, doDatuma);

            if(porukaProvjere == "")
            {
                dgvPopisObavijesti.DataSource = null;
                dgvPopisObavijesti.DataSource = FiltrirajObavijestiPoDatumu(odDatuma, doDatuma);
                dgvPopisObavijesti.Columns["Id"].Visible = false;
                dgvPopisObavijesti.Columns["OpisObavijesti"].Visible = false;
                dgvPopisObavijesti.Columns[1].Width = 138;
                dgvPopisObavijesti.Columns[2].Width = 250;
                dgvPopisObavijesti.Columns[4].Width = 150;
            }
            else
            {
                MessageBox.Show(porukaProvjere);
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Close();
        }
    }
}
