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
    public partial class frmObavijestiStudent : Form
    {
        Student postojeciStudent = null;
        List<Termin> terminiStudenta = null;


        public frmObavijestiStudent(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
            terminiStudenta = PopuniTermineStudenta();
            comboPopisTermina.DataSource = terminiStudenta;
            comboPopisTermina.SelectedIndexChanged += ComboPopisTermina_SelectedIndexChanged;
        }

        private void ComboPopisTermina_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziObavijesti();
        }

        private void frmObavijestiStudent_Load(object sender, EventArgs e)
        {

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
            }
        }

        public List<Termin> PopuniTermineStudenta()
        {
            List<Termin> listaTermina = RepozitorijTermina.PopuniListuTermina();
            terminiStudenta = new List<Termin>();

            using (var context = new Entities())
            {
                var upit = from r in context.Rezervacije
                           where r.student_ID == postojeciStudent.ID_studenta
                           select r.Termini;

                List<Termini> terminiBaza = upit.ToList();

                foreach (var item in terminiBaza)
                {
                    Termin termin = listaTermina.Find(x => x.Id == item.ID_termina);
                    terminiStudenta.Add(termin);
                }
            }

            return terminiStudenta;
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

        public List<Obavijest> FiltrirajObavijestiPoDatumu(DateTime odDatuma, DateTime doDatuma)
        {
            List<Obavijest> filtriraneObavijesti = new List<Obavijest>();
            List<Obavijest> dohvaceneObavijesti = DohvatiSveObavijesti();

            if (dohvaceneObavijesti != null)
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

        public List<Obavijest> PretraziObavijestiPoNaslovu(string naslov)
        {
            List<Obavijest> pronadjeneObavijesti = new List<Obavijest>();
            List<Obavijest> dohvaceneObavijesti = DohvatiSveObavijesti();

            if (dohvaceneObavijesti != null)
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

            if (porukaProvjere == "")
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
