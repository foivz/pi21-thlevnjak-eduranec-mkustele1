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

namespace FindAndLearn.Controls
{
    public partial class frmStudentPodaci : Form
    {
        Student student = null;

        public frmStudentPodaci(Student selektiraniStudent)
        {
            InitializeComponent();
            student = selektiraniStudent;
        }

        private void frmStudentPodaci_Load(object sender, EventArgs e)
        {
            if (student != null)
            {
                lblImePrezime.Text = student.Ime + " " + student.Prezime;
                lblEmail.Text = student.Email;
                lblMobitel.Text = student.Mobitel;
                lblMjesto.Text = student.Mjesto;
                lblUlica.Text = student.Ulica;
                txtOpis.Text = student.Opis;
                pbSlikaStudenta.Image = student.Slika;
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
