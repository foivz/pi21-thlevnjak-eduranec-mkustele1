using FindAndLearn.Klase;
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
    public partial class frmArhivaObavijesti : Form
    {
        List<Obavijest> prosleObavijesti= null;

        public frmArhivaObavijesti(List<Obavijest> obavijesti)
        {
            InitializeComponent();
            prosleObavijesti = obavijesti;
        }

        private void frmArhivaObavijesti_Load(object sender, EventArgs e)
        {
            dgvPopisObavijesti.DataSource = null;
            dgvPopisObavijesti.DataSource = prosleObavijesti;
            PodesiSirinuPopisaObavijesti();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmArhivaObavijesti_KeyDown);
        }

        private void frmArhivaObavijesti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Instruktor/Obavijesti/Arhiva_obavijesti/index.html");
            }
        }

        public void PodesiSirinuPopisaObavijesti()
        {
            dgvPopisObavijesti.Columns["Id"].Visible = false;
            dgvPopisObavijesti.Columns["OpisObavijesti"].Visible = false;
            dgvPopisObavijesti.Columns[1].Width = 138;
            dgvPopisObavijesti.Columns[2].Width = 250;
            dgvPopisObavijesti.Columns[4].Width = 150;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            List<Obavijest> pronadjeneObavijesti = new List<Obavijest>();

            if (prosleObavijesti != null)
            {
                string pretraga = txtNaslov.Text;
                string[] pretvorbaPretrage = pretraga.Split(' ');

                foreach (var rijec in pretvorbaPretrage)
                {
                    foreach (var obavijest in prosleObavijesti)
                    {
                        if (obavijest.NazivObavijesti.ToLower().Contains(rijec.ToLower()))
                        {
                            pronadjeneObavijesti.Add(obavijest);
                        }
                    }
                }
            }

            dgvPopisObavijesti.DataSource = null;
            dgvPopisObavijesti.DataSource = pronadjeneObavijesti;
            PodesiSirinuPopisaObavijesti();
        }

        private void btnFiltiraj_Click(object sender, EventArgs e)
        {
            DateTime odDatuma = dtpOd.Value;
            DateTime doDatuma = dtpDo.Value;
            string porukaProvjere = RepozitorijObavijesti.ProvjeraDatuma(odDatuma, doDatuma);

            if (porukaProvjere == "")
            {
                dgvPopisObavijesti.DataSource = null;

                List<Obavijest> filtriraneObavijesti = new List<Obavijest>();

                if (prosleObavijesti != null)
                {
                    foreach (var item in prosleObavijesti)
                    {
                        if (item.DatumObavijesti.Date >= odDatuma.Date && item.DatumObavijesti.Date <= doDatuma.Date)
                        {
                            filtriraneObavijesti.Add(item);
                        }
                    }
                }

                dgvPopisObavijesti.DataSource = filtriraneObavijesti;
                PodesiSirinuPopisaObavijesti();
            }
            else
            {
                MessageBox.Show(porukaProvjere);
            }
        }

        private void btnProcitaj_Click(object sender, EventArgs e)
        {
            Obavijest odabranaObavijest = null;

            if (dgvPopisObavijesti.CurrentRow != null)
            {
                odabranaObavijest = dgvPopisObavijesti.CurrentRow.DataBoundItem as Obavijest;
            }

            if (odabranaObavijest != null)
            {
                frmProcitajObavijesti form = new frmProcitajObavijesti(odabranaObavijest);
                form.ShowDialog();
            }
        }

        private void btnUkloniFilter_Click(object sender, EventArgs e)
        {
            dgvPopisObavijesti.DataSource = null;
            dgvPopisObavijesti.DataSource = prosleObavijesti;
            PodesiSirinuPopisaObavijesti();
        }
    }
}
