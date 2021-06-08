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

namespace FindAndLearn.Termin
{
    public partial class frmDodajTermin : Form
    {
        public Instrukcija OdabranaInstrukcija { get; set; }
        public frmDodajTermin()
        {
            InitializeComponent();
        }
        public frmDodajTermin(Instrukcija odabranaInstrukcija)
        {
            InitializeComponent();
            OdabranaInstrukcija = odabranaInstrukcija;

        }

        private void frmDodajTermin_Load(object sender, EventArgs e)
        {


        }
    }
}
