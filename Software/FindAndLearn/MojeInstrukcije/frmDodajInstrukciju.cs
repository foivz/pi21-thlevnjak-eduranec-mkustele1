using FindAndLearn.Klase;
using FindAndLearn.MojiTermini;
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
using VrsteKolegijaLib;

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
                comboTipInstrukcija.DataSource = RepozitorijInstrukcija.PopuniPopisTipovaInstrukcija();
                comboVrstaKolegija.DataSource = RepozitorijInstrukcija.PopuniPopisKolegija();
            }
            OsvjeziMojeInstrukcije();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmDodajInstrukciju_KeyDown);
        }

        private void frmDodajInstrukciju_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Instruktor/Instrukcije/index.html");
            }
        }

        private void OsvjeziMojeInstrukcije()
        {
            Entities entities = new Entities();
            entities.Instrukcije.Load();
            instrukcijeBindingSource.DataSource = entities.Instrukcije.Local.Where(x=>x.instruktor_id==TrenutniInstruktor.ID_instruktora);
            lblTrenutniInstruktor.Text = TrenutniInstruktor.ToString();
        }

        private void btnDodajInstrukciju_Click(object sender, EventArgs e)
        {
            Instrukcija novaInstrukcija = RepozitorijInstrukcija.KreirajInstrukciju();
            novaInstrukcija.Instruktor = TrenutniInstruktor;
            novaInstrukcija.TipInstrukcije = comboTipInstrukcija.SelectedItem as TipInstrukcije;
            novaInstrukcija.Kolegij = comboVrstaKolegija.SelectedItem as Kolegij;
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

        private void btnDodajTermin_Click(object sender, EventArgs e)
        {
            Instrukcije instrukcijaBaza = instrukcijeBindingSource.Current as Instrukcije;
            List<Instrukcija> listaInstrukcija = RepozitorijInstrukcija.PopuniPopisInstrukcija();

            Instrukcija odabranaInstrukcija = (from ins in listaInstrukcija
                                               where ins.Id == instrukcijaBaza.ID_instrukcije
                                               select ins).Single();

            frmDodajTermin formTermin = new frmDodajTermin(odabranaInstrukcija);
            
            formTermin.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Instruktor/Instrukcije/index.html");
        }
    }
}
