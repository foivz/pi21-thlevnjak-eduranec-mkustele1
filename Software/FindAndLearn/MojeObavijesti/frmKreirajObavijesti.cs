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
    public partial class frmKreirajObavijesti : Form
    {
        Instruktor postojeciInstruktor = null;

        public frmKreirajObavijesti(Instruktor instruktor)
        {
            InitializeComponent();
            postojeciInstruktor = instruktor;
        }

        private void frmKreirajObavijesti_Load(object sender, EventArgs e)
        {

        }
       
    }
}
