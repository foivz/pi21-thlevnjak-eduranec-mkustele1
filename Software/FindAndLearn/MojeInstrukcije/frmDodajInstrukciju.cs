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
            trenutniInstruktor = trenutniInstruktor;
        }
        private void frmDodajInstrukciju_Load(object sender, EventArgs e)
        {

        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmPrijava form = new frmPrijava();
            form.ShowDialog();
            Close();
        }
    }
}
