using FindAndLearn.Klase;
using FindAndLearn.MojeObavijesti;
using FindAndLearn.MojePoruke;
using FindAndLearn.MojeRecenzije;
using FindAndLearn.MojeRezervacije;
using FindAndLearn.Profil;
using FindAndLearn.Tražilica;
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
    public partial class frmPocetnaStudent : Form
    {
        Student postojeciStudent = null;
        public frmPocetnaStudent(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
        }

        private void frmPocetnaStudent_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmPocetnaStudent_KeyDown);

        }

        private void frmPocetnaStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                //Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Student/index.html");
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmStudentProfil form = new frmStudentProfil(postojeciStudent);
            form.ShowDialog();
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            frmObavijestiStudent form = new frmObavijestiStudent(postojeciStudent);
            form.ShowDialog();
        }

        private void btnRezervacijaTermina_Click(object sender, EventArgs e)
        {
            frmZatraziRezervaciju frmRezervacija = new frmZatraziRezervaciju(postojeciStudent);
            frmRezervacija.ShowDialog();
        }

        private void btnRecenzije_Click(object sender, EventArgs e)
        {
            frmDodajRecenziju frmRecenz = new frmDodajRecenziju(postojeciStudent);
            frmRecenz.ShowDialog();
        }

        private void btnPoruke_Click(object sender, EventArgs e)
        {
            frmPorukeStudent frmPoruke = new frmPorukeStudent(postojeciStudent);
            frmPoruke.ShowDialog();
        }

        private void btnTrazilica_Click(object sender, EventArgs e)
        {
            frmTrazilica frmTrazilica = new frmTrazilica();
            frmTrazilica.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "Student/index.html");
        }
    }
}