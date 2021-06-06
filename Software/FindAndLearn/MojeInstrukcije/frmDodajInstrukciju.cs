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

namespace FindAndLearn.MojeInstrukcije
{
    public partial class frmDodajInstrukciju : Form
    {
        Instruktor TrenutniInstruktor;
        public frmDodajInstrukciju()
        {
            InitializeComponent();
        }

        public frmDodajInstrukciju(Instruktor trenutniInstruktor)
        {
            InitializeComponent();
            TrenutniInstruktor = trenutniInstruktor;
        }
        private void frmDodajInstrukciju_Load(object sender, EventArgs e)
        {
            
            using(Entities entities = new Entities())
            {
                comboVrstaKolegija.DataSource = entities.Kolegiji.ToList();
                comboTipInstrukcija.DataSource = entities.Tip_instrukcija.ToList();
                dataGridView1.DataSource = entities.Instrukcije.Where(x => x.instruktor_id == TrenutniInstruktor.ID_instruktora).ToList();
                dataGridView1.Columns["Instruktori"].Visible = false;
                dataGridView1.Columns["Kolegiji"].Visible = false;
                dataGridView1.Columns["Tip_Instrukcija"].Visible = false;
                dataGridView1.Columns["Termini"].Visible = false;

            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Close();
        }

        private void btnDodajInstrukciju_Click(object sender, EventArgs e)
        {
            Instrukcija novaInstrukcija = RepozitorijInstrukcija.KreirajInstrukciju();
            novaInstrukcija.Instruktor = TrenutniInstruktor.ID_instruktora;
            novaInstrukcija.TipInstrukcije = (comboTipInstrukcija.SelectedItem as Tip_instrukcija).ID_tip_instrukcije;
            novaInstrukcija.Kolegij = (comboVrstaKolegija.SelectedItem as Kolegiji).ID_kolegija;
            novaInstrukcija.OpisInstrukcije = txtOpisInstrukcije.Text;
            novaInstrukcija.CijenaInstrukcije = double.Parse(textCijenaInstrukcije.Text);
            RepozitorijInstrukcija.DodajInstrukciju(novaInstrukcija);
            
        }
    }
}
