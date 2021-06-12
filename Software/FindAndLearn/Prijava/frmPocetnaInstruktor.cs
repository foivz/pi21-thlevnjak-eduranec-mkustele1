using FindAndLearn.MojeInstrukcije;
using FindAndLearn.MojeObavijesti;
using FindAndLearn.MojePoruke;
using FindAndLearn.MojeRezervacije;
using FindAndLearn.Profil;
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


namespace FindAndLearn.Prijava
{
    public partial class frmPocetnaInstruktor : Form
    {
        Instruktor postojeciInstruktor = null;

        public frmPocetnaInstruktor(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
        }

        private void frmPocetnaInstruktor_Load(object sender, EventArgs e)
        {

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmInstruktorProfil form = new frmInstruktorProfil(postojeciInstruktor);
            form.ShowDialog();
        }

        private void btnInstrukcije_Click(object sender, EventArgs e)
        {
            frmDodajInstrukciju frmDodajInstrukciju = new frmDodajInstrukciju(postojeciInstruktor); //konstruktor prima postojeceg instruktora u svrhu kreiranja instrukcije
            frmDodajInstrukciju.ShowDialog(); 
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            frmObavijestiInstruktor form = new frmObavijestiInstruktor(postojeciInstruktor);
            form.ShowDialog();
        }

        private void btnRezervacije_Click(object sender, EventArgs e)
        {
            frmOdobriRezervaciju formOdobri = new frmOdobriRezervaciju(postojeciInstruktor);
            formOdobri.ShowDialog();
        }

        private void btnPoruke_Click(object sender, EventArgs e)
        {
            frmPorukeInstruktor frmPoruke = new frmPorukeInstruktor(postojeciInstruktor);
            frmPoruke.ShowDialog();
        }
    }
}
