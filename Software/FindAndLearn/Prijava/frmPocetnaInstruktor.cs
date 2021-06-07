﻿using FindAndLearn.MojeInstrukcije;
using FindAndLearn.MojeObavijesti;
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
            Close();
        }

        private void btnInstrukcije_Click(object sender, EventArgs e)
        {
            frmDodajInstrukciju frmDodajInstrukciju = new frmDodajInstrukciju(postojeciInstruktor);
            frmDodajInstrukciju.ShowDialog(); //šaljem postojećeg instruktora u formu instrukcije gdje ga spremam u konstruktor i dodajem u instrukciju
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            frmObavijestiInstruktor form = new frmObavijestiInstruktor(postojeciInstruktor);
            form.ShowDialog();
            Close();
        }
    }
}
