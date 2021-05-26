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

namespace FindAndLearn.Profil
{
    public partial class frmOMeniStudent : Form
    {
        Student postojeciStudent = null;
        public frmOMeniStudent(Student student)
        {
            InitializeComponent();
            postojeciStudent = student;
        }

        private void frmOMeniStudent_Load(object sender, EventArgs e)
        {
            txtKorisnickoIme.Text = postojeciStudent.KorisnickoIme;
            txtIme.Text = postojeciStudent.Ime;
            txtPrezime.Text = postojeciStudent.Prezime;
            txtEmail.Text = postojeciStudent.Email;
            txtMobitel.Text = postojeciStudent.Mobitel;
            txtMjesto.Text = postojeciStudent.Mjesto;
            txtUlica.Text = postojeciStudent.Ulica;
            txtOpis.Text = postojeciStudent.Opis;
        }
    }
}
