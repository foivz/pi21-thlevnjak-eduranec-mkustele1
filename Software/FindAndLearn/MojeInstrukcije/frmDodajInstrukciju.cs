using FindAndLearn.Klase;
using KorisniciLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            using(var entities=new Entities())
            {
                comboTipInstrukcija.DataSource = entities.Tip_instrukcija.ToList();
                comboVrstaKolegija.DataSource = entities.Kolegiji.ToList();
            }
            OsvjeziMojeInstrukcije();
        }

        private void OsvjeziMojeInstrukcije()
        {
            Entities entities = new Entities();
            entities.Instrukcije.Load();
            instrukcijeBindingSource.DataSource = entities.Instrukcije.Local;
        }
        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            this.Close();
        }

        private void btnDodajInstrukciju_Click(object sender, EventArgs e)
        {
            Instrukcija novaInstrukcija = RepozitorijInstrukcija.KreirajInstrukciju();
            novaInstrukcija.Instruktor = TrenutniInstruktor.ID_instruktora;
            novaInstrukcija.TipInstrukcije = (comboTipInstrukcija.SelectedItem as Tip_instrukcija).ID_tip_instrukcije;
            novaInstrukcija.Kolegij = (comboVrstaKolegija.SelectedItem as Kolegiji).ID_kolegija;
            novaInstrukcija.OpisInstrukcije = txtOpisInstrukcije.Text;
            if (textCijenaInstrukcije.Text != "")
            {
                novaInstrukcija.CijenaInstrukcije = double.Parse(textCijenaInstrukcije.Text);
            }
            else
            {
                novaInstrukcija.CijenaInstrukcije = 0;
            }
            RepozitorijInstrukcija.DodajInstrukciju(novaInstrukcija);
            OsvjeziMojeInstrukcije();
            OsvjeziObrazac();
        }

        private void OsvjeziObrazac()
        {
            txtOpisInstrukcije.Clear();
            textCijenaInstrukcije.Clear();
            
        }

        private void btnObrisiInstrukciju_Click(object sender, EventArgs e)
        {
            
            Instrukcije instrukcijaBrisanje = instrukcijeBindingSource.Current as Instrukcije;
            int idBrisanje = instrukcijaBrisanje.ID_instrukcije;
            if(instrukcijaBrisanje != null)
            {
                if(MessageBox.Show("Želite li obrisati odabranu instrukciju?", "Brisanje",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
                {
                    RepozitorijInstrukcija.ObrisiInstrukciju(idBrisanje);
                }
            }
            OsvjeziMojeInstrukcije();

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
