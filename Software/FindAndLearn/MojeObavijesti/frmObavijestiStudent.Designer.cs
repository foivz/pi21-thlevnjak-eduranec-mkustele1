
namespace FindAndLearn.MojeObavijesti
{
    partial class frmObavijestiStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.btnProfil = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnPoruke = new System.Windows.Forms.Button();
            this.btnTrazilica = new System.Windows.Forms.Button();
            this.btnGrupe = new System.Windows.Forms.Button();
            this.btnRezervacijaTermina = new System.Windows.Forms.Button();
            this.btnRecenzije = new System.Windows.Forms.Button();
            this.lblNazivTermina = new System.Windows.Forms.Label();
            this.gbDatumObavijesti = new System.Windows.Forms.GroupBox();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.btnFiltiraj = new System.Windows.Forms.Button();
            this.lblOdDatuma = new System.Windows.Forms.Label();
            this.lblDoDatuma = new System.Windows.Forms.Label();
            this.comboPopisTermina = new System.Windows.Forms.ComboBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.lblTermin = new System.Windows.Forms.Label();
            this.btnProcitaj = new System.Windows.Forms.Button();
            this.dgvPopisObavijesti = new System.Windows.Forms.DataGridView();
            this.btnPrikaziSveObavijesti = new System.Windows.Forms.Button();
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbDatumObavijesti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisObavijesti)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(77, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "OBAVIJESTI";
            // 
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.label2);
            this.gbProfil.Location = new System.Drawing.Point(-2, -11);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Size = new System.Drawing.Size(211, 75);
            this.gbProfil.TabIndex = 87;
            this.gbProfil.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(-1, 11);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(79, 59);
            this.pbLogo.TabIndex = 70;
            this.pbLogo.TabStop = false;
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnOdjava);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(173, -10);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(1144, 49);
            this.gbInstruktor.TabIndex = 86;
            this.gbInstruktor.TabStop = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(665, 16);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(90, 25);
            this.btnOdjava.TabIndex = 23;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(766, 16);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 25);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(58, 17);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(64, 18);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Student ";
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfil.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfil.Location = new System.Drawing.Point(17, 48);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(184, 31);
            this.btnProfil.TabIndex = 25;
            this.btnProfil.Text = "PROFIL";
            this.btnProfil.UseVisualStyleBackColor = false;
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnPoruke);
            this.gbIzbornik.Controls.Add(this.btnTrazilica);
            this.gbIzbornik.Controls.Add(this.btnGrupe);
            this.gbIzbornik.Controls.Add(this.btnProfil);
            this.gbIzbornik.Controls.Add(this.btnRezervacijaTermina);
            this.gbIzbornik.Controls.Add(this.btnRecenzije);
            this.gbIzbornik.Location = new System.Drawing.Point(-7, 32);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
            this.gbIzbornik.TabIndex = 85;
            this.gbIzbornik.TabStop = false;
            // 
            // btnPoruke
            // 
            this.btnPoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPoruke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoruke.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoruke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPoruke.Location = new System.Drawing.Point(18, 249);
            this.btnPoruke.Name = "btnPoruke";
            this.btnPoruke.Size = new System.Drawing.Size(184, 31);
            this.btnPoruke.TabIndex = 30;
            this.btnPoruke.Text = "PORUKE";
            this.btnPoruke.UseVisualStyleBackColor = false;
            // 
            // btnTrazilica
            // 
            this.btnTrazilica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnTrazilica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrazilica.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrazilica.Location = new System.Drawing.Point(17, 87);
            this.btnTrazilica.Name = "btnTrazilica";
            this.btnTrazilica.Size = new System.Drawing.Size(184, 31);
            this.btnTrazilica.TabIndex = 29;
            this.btnTrazilica.Text = "TRAŽILICA";
            this.btnTrazilica.UseVisualStyleBackColor = false;
            // 
            // btnGrupe
            // 
            this.btnGrupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrupe.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGrupe.Location = new System.Drawing.Point(17, 207);
            this.btnGrupe.Name = "btnGrupe";
            this.btnGrupe.Size = new System.Drawing.Size(184, 31);
            this.btnGrupe.TabIndex = 28;
            this.btnGrupe.Text = "OBAVIJESTI";
            this.btnGrupe.UseVisualStyleBackColor = false;
            // 
            // btnRezervacijaTermina
            // 
            this.btnRezervacijaTermina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRezervacijaTermina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervacijaTermina.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezervacijaTermina.Location = new System.Drawing.Point(16, 126);
            this.btnRezervacijaTermina.Name = "btnRezervacijaTermina";
            this.btnRezervacijaTermina.Size = new System.Drawing.Size(184, 31);
            this.btnRezervacijaTermina.TabIndex = 24;
            this.btnRezervacijaTermina.Text = "ZATRAŽI REZERVACIJU ";
            this.btnRezervacijaTermina.UseVisualStyleBackColor = false;
            // 
            // btnRecenzije
            // 
            this.btnRecenzije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRecenzije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecenzije.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecenzije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecenzije.Location = new System.Drawing.Point(17, 165);
            this.btnRecenzije.Name = "btnRecenzije";
            this.btnRecenzije.Size = new System.Drawing.Size(184, 31);
            this.btnRecenzije.TabIndex = 20;
            this.btnRecenzije.Text = "RECENZIJE";
            this.btnRecenzije.UseVisualStyleBackColor = false;
            // 
            // lblNazivTermina
            // 
            this.lblNazivTermina.AutoSize = true;
            this.lblNazivTermina.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTermina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.lblNazivTermina.Location = new System.Drawing.Point(228, 59);
            this.lblNazivTermina.Name = "lblNazivTermina";
            this.lblNazivTermina.Size = new System.Drawing.Size(138, 26);
            this.lblNazivTermina.TabIndex = 132;
            this.lblNazivTermina.Text = "Naziv termina";
            // 
            // gbDatumObavijesti
            // 
            this.gbDatumObavijesti.Controls.Add(this.dtpDo);
            this.gbDatumObavijesti.Controls.Add(this.dtpOd);
            this.gbDatumObavijesti.Controls.Add(this.btnFiltiraj);
            this.gbDatumObavijesti.Controls.Add(this.lblOdDatuma);
            this.gbDatumObavijesti.Controls.Add(this.lblDoDatuma);
            this.gbDatumObavijesti.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDatumObavijesti.Location = new System.Drawing.Point(832, 172);
            this.gbDatumObavijesti.Name = "gbDatumObavijesti";
            this.gbDatumObavijesti.Size = new System.Drawing.Size(161, 174);
            this.gbDatumObavijesti.TabIndex = 128;
            this.gbDatumObavijesti.TabStop = false;
            this.gbDatumObavijesti.Text = "Datum obavijesti";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(9, 95);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(138, 22);
            this.dtpDo.TabIndex = 102;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(8, 46);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(138, 22);
            this.dtpOd.TabIndex = 101;
            // 
            // btnFiltiraj
            // 
            this.btnFiltiraj.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltiraj.Location = new System.Drawing.Point(58, 131);
            this.btnFiltiraj.Name = "btnFiltiraj";
            this.btnFiltiraj.Size = new System.Drawing.Size(88, 23);
            this.btnFiltiraj.TabIndex = 100;
            this.btnFiltiraj.Text = "FILTRIRAJ";
            this.btnFiltiraj.UseVisualStyleBackColor = true;
            this.btnFiltiraj.Click += new System.EventHandler(this.btnFiltiraj_Click);
            // 
            // lblOdDatuma
            // 
            this.lblOdDatuma.AutoSize = true;
            this.lblOdDatuma.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdDatuma.Location = new System.Drawing.Point(6, 26);
            this.lblOdDatuma.Name = "lblOdDatuma";
            this.lblOdDatuma.Size = new System.Drawing.Size(26, 15);
            this.lblOdDatuma.TabIndex = 96;
            this.lblOdDatuma.Text = "Od:";
            // 
            // lblDoDatuma
            // 
            this.lblDoDatuma.AutoSize = true;
            this.lblDoDatuma.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDoDatuma.Location = new System.Drawing.Point(6, 76);
            this.lblDoDatuma.Name = "lblDoDatuma";
            this.lblDoDatuma.Size = new System.Drawing.Size(25, 15);
            this.lblDoDatuma.TabIndex = 97;
            this.lblDoDatuma.Text = "Do:";
            // 
            // comboPopisTermina
            // 
            this.comboPopisTermina.FormattingEnabled = true;
            this.comboPopisTermina.Location = new System.Drawing.Point(347, 98);
            this.comboPopisTermina.Name = "comboPopisTermina";
            this.comboPopisTermina.Size = new System.Drawing.Size(160, 21);
            this.comboPopisTermina.TabIndex = 131;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaslov.Location = new System.Drawing.Point(347, 127);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(237, 22);
            this.txtNaslov.TabIndex = 127;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(230, 129);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(110, 15);
            this.lblPretrazivanje.TabIndex = 126;
            this.lblPretrazivanje.Text = "Pretraži po naslovu:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(590, 126);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(105, 23);
            this.btnPretrazi.TabIndex = 125;
            this.btnPretrazi.Text = "PRETRAŽI";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTermin.Location = new System.Drawing.Point(231, 98);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(89, 15);
            this.lblTermin.TabIndex = 129;
            this.lblTermin.Text = "Odaberi termin:";
            // 
            // btnProcitaj
            // 
            this.btnProcitaj.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcitaj.Location = new System.Drawing.Point(671, 432);
            this.btnProcitaj.Name = "btnProcitaj";
            this.btnProcitaj.Size = new System.Drawing.Size(145, 23);
            this.btnProcitaj.TabIndex = 124;
            this.btnProcitaj.Text = "PROČITAJ OBAVIJESTI";
            this.btnProcitaj.UseVisualStyleBackColor = true;
            this.btnProcitaj.Click += new System.EventHandler(this.btnProcitaj_Click);
            // 
            // dgvPopisObavijesti
            // 
            this.dgvPopisObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisObavijesti.Location = new System.Drawing.Point(234, 171);
            this.dgvPopisObavijesti.Name = "dgvPopisObavijesti";
            this.dgvPopisObavijesti.Size = new System.Drawing.Size(582, 252);
            this.dgvPopisObavijesti.TabIndex = 123;
            // 
            // btnPrikaziSveObavijesti
            // 
            this.btnPrikaziSveObavijesti.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziSveObavijesti.Location = new System.Drawing.Point(701, 126);
            this.btnPrikaziSveObavijesti.Name = "btnPrikaziSveObavijesti";
            this.btnPrikaziSveObavijesti.Size = new System.Drawing.Size(115, 23);
            this.btnPrikaziSveObavijesti.TabIndex = 133;
            this.btnPrikaziSveObavijesti.Text = "PRIKAŽI SVE ";
            this.btnPrikaziSveObavijesti.UseVisualStyleBackColor = true;
            this.btnPrikaziSveObavijesti.Click += new System.EventHandler(this.btnPrikaziSveObavijesti_Click);
            // 
            // frmObavijestiStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1079, 543);
            this.Controls.Add(this.btnPrikaziSveObavijesti);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.lblNazivTermina);
            this.Controls.Add(this.gbInstruktor);
            this.Controls.Add(this.gbDatumObavijesti);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.comboPopisTermina);
            this.Controls.Add(this.dgvPopisObavijesti);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.btnProcitaj);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.lblTermin);
            this.Controls.Add(this.btnPretrazi);
            this.Name = "frmObavijestiStudent";
            this.Text = "Obavijesti";
            this.Load += new System.EventHandler(this.frmObavijestiStudent_Load);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            this.gbDatumObavijesti.ResumeLayout(false);
            this.gbDatumObavijesti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisObavijesti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Button btnPoruke;
        private System.Windows.Forms.Button btnTrazilica;
        private System.Windows.Forms.Button btnGrupe;
        private System.Windows.Forms.Button btnRezervacijaTermina;
        private System.Windows.Forms.Button btnRecenzije;
        private System.Windows.Forms.Label lblNazivTermina;
        private System.Windows.Forms.GroupBox gbDatumObavijesti;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Button btnFiltiraj;
        private System.Windows.Forms.Label lblOdDatuma;
        private System.Windows.Forms.Label lblDoDatuma;
        private System.Windows.Forms.ComboBox comboPopisTermina;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Label lblTermin;
        private System.Windows.Forms.Button btnProcitaj;
        private System.Windows.Forms.DataGridView dgvPopisObavijesti;
        private System.Windows.Forms.Button btnPrikaziSveObavijesti;
    }
}