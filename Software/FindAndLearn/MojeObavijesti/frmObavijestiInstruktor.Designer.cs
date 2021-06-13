
namespace FindAndLearn.MojeObavijesti
{
    partial class frmObavijestiInstruktor
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
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnGrupe = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
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
            this.btnAzurirajObavijest = new System.Windows.Forms.Button();
            this.btnPrikaziSveObavijesti = new System.Windows.Forms.Button();
            this.btnArhiva = new System.Windows.Forms.Button();
            this.gbPopisStudenata = new System.Windows.Forms.GroupBox();
            this.flpSudionici = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDetaljiTermina = new System.Windows.Forms.Button();
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbDatumObavijesti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisObavijesti)).BeginInit();
            this.gbPopisStudenata.SuspendLayout();
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
            this.gbProfil.Location = new System.Drawing.Point(-4, -7);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Size = new System.Drawing.Size(211, 75);
            this.gbProfil.TabIndex = 103;
            this.gbProfil.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(76, 59);
            this.pbLogo.TabIndex = 69;
            this.pbLogo.TabStop = false;
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(58, 17);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(79, 18);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Instruktor ";
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(171, -6);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(1070, 49);
            this.gbInstruktor.TabIndex = 102;
            this.gbInstruktor.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(962, 14);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 25);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnGrupe);
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Location = new System.Drawing.Point(-10, 36);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
            this.gbIzbornik.TabIndex = 101;
            this.gbIzbornik.TabStop = false;
            // 
            // btnGrupe
            // 
            this.btnGrupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGrupe.Location = new System.Drawing.Point(20, 49);
            this.btnGrupe.Name = "btnGrupe";
            this.btnGrupe.Size = new System.Drawing.Size(184, 31);
            this.btnGrupe.TabIndex = 142;
            this.btnGrupe.Text = "OBAVIJESTI";
            this.btnGrupe.UseVisualStyleBackColor = false;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(20, 443);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(184, 31);
            this.btnZatvori.TabIndex = 141;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnKreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKreiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreiraj.Location = new System.Drawing.Point(609, 401);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(101, 23);
            this.btnKreiraj.TabIndex = 120;
            this.btnKreiraj.Text = "KREIRAJ ";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // gbDatumObavijesti
            // 
            this.gbDatumObavijesti.Controls.Add(this.dtpDo);
            this.gbDatumObavijesti.Controls.Add(this.dtpOd);
            this.gbDatumObavijesti.Controls.Add(this.btnFiltiraj);
            this.gbDatumObavijesti.Controls.Add(this.lblOdDatuma);
            this.gbDatumObavijesti.Controls.Add(this.lblDoDatuma);
            this.gbDatumObavijesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDatumObavijesti.Location = new System.Drawing.Point(830, 141);
            this.gbDatumObavijesti.Name = "gbDatumObavijesti";
            this.gbDatumObavijesti.Size = new System.Drawing.Size(161, 174);
            this.gbDatumObavijesti.TabIndex = 118;
            this.gbDatumObavijesti.TabStop = false;
            this.gbDatumObavijesti.Text = "Datum obavijesti";
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(9, 95);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(138, 20);
            this.dtpDo.TabIndex = 102;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(8, 46);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(138, 20);
            this.dtpOd.TabIndex = 101;
            // 
            // btnFiltiraj
            // 
            this.btnFiltiraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnFiltiraj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltiraj.Location = new System.Drawing.Point(58, 131);
            this.btnFiltiraj.Name = "btnFiltiraj";
            this.btnFiltiraj.Size = new System.Drawing.Size(88, 23);
            this.btnFiltiraj.TabIndex = 100;
            this.btnFiltiraj.Text = "FILTRIRAJ";
            this.btnFiltiraj.UseVisualStyleBackColor = false;
            this.btnFiltiraj.Click += new System.EventHandler(this.btnFiltiraj_Click);
            // 
            // lblOdDatuma
            // 
            this.lblOdDatuma.AutoSize = true;
            this.lblOdDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdDatuma.Location = new System.Drawing.Point(6, 26);
            this.lblOdDatuma.Name = "lblOdDatuma";
            this.lblOdDatuma.Size = new System.Drawing.Size(24, 13);
            this.lblOdDatuma.TabIndex = 96;
            this.lblOdDatuma.Text = "Od:";
            // 
            // lblDoDatuma
            // 
            this.lblDoDatuma.AutoSize = true;
            this.lblDoDatuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDoDatuma.Location = new System.Drawing.Point(6, 76);
            this.lblDoDatuma.Name = "lblDoDatuma";
            this.lblDoDatuma.Size = new System.Drawing.Size(24, 13);
            this.lblDoDatuma.TabIndex = 97;
            this.lblDoDatuma.Text = "Do:";
            // 
            // comboPopisTermina
            // 
            this.comboPopisTermina.FormattingEnabled = true;
            this.comboPopisTermina.Location = new System.Drawing.Point(345, 71);
            this.comboPopisTermina.Name = "comboPopisTermina";
            this.comboPopisTermina.Size = new System.Drawing.Size(160, 21);
            this.comboPopisTermina.TabIndex = 121;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaslov.Location = new System.Drawing.Point(345, 100);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(239, 20);
            this.txtNaslov.TabIndex = 117;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(228, 101);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(114, 15);
            this.lblPretrazivanje.TabIndex = 116;
            this.lblPretrazivanje.Text = "Pretraži po naslovu:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(590, 99);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(105, 23);
            this.btnPretrazi.TabIndex = 115;
            this.btnPretrazi.Text = "PRETRAŽI";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTermin.Location = new System.Drawing.Point(229, 74);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(92, 15);
            this.lblTermin.TabIndex = 119;
            this.lblTermin.Text = "Odaberi termin:";
            // 
            // btnProcitaj
            // 
            this.btnProcitaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnProcitaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcitaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcitaj.Location = new System.Drawing.Point(715, 401);
            this.btnProcitaj.Name = "btnProcitaj";
            this.btnProcitaj.Size = new System.Drawing.Size(101, 23);
            this.btnProcitaj.TabIndex = 114;
            this.btnProcitaj.Text = "PROČITAJ ";
            this.btnProcitaj.UseVisualStyleBackColor = false;
            this.btnProcitaj.Click += new System.EventHandler(this.btnProcitaj_Click);
            // 
            // dgvPopisObavijesti
            // 
            this.dgvPopisObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisObavijesti.Location = new System.Drawing.Point(232, 140);
            this.dgvPopisObavijesti.Name = "dgvPopisObavijesti";
            this.dgvPopisObavijesti.Size = new System.Drawing.Size(582, 252);
            this.dgvPopisObavijesti.TabIndex = 113;
            // 
            // btnAzurirajObavijest
            // 
            this.btnAzurirajObavijest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnAzurirajObavijest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAzurirajObavijest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajObavijest.Location = new System.Drawing.Point(504, 401);
            this.btnAzurirajObavijest.Name = "btnAzurirajObavijest";
            this.btnAzurirajObavijest.Size = new System.Drawing.Size(101, 23);
            this.btnAzurirajObavijest.TabIndex = 123;
            this.btnAzurirajObavijest.Text = "AŽURIRAJ ";
            this.btnAzurirajObavijest.UseVisualStyleBackColor = false;
            this.btnAzurirajObavijest.Click += new System.EventHandler(this.btnAzurirajObavijest_Click);
            // 
            // btnPrikaziSveObavijesti
            // 
            this.btnPrikaziSveObavijesti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPrikaziSveObavijesti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaziSveObavijesti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziSveObavijesti.Location = new System.Drawing.Point(699, 99);
            this.btnPrikaziSveObavijesti.Name = "btnPrikaziSveObavijesti";
            this.btnPrikaziSveObavijesti.Size = new System.Drawing.Size(115, 23);
            this.btnPrikaziSveObavijesti.TabIndex = 134;
            this.btnPrikaziSveObavijesti.Text = "UKLONI FILTER";
            this.btnPrikaziSveObavijesti.UseVisualStyleBackColor = false;
            this.btnPrikaziSveObavijesti.Click += new System.EventHandler(this.btnPrikaziSveObavijesti_Click);
            // 
            // btnArhiva
            // 
            this.btnArhiva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnArhiva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArhiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnArhiva.Location = new System.Drawing.Point(231, 401);
            this.btnArhiva.Name = "btnArhiva";
            this.btnArhiva.Size = new System.Drawing.Size(111, 36);
            this.btnArhiva.TabIndex = 140;
            this.btnArhiva.Text = "ARHIVA OBAVIJESTI";
            this.btnArhiva.UseVisualStyleBackColor = false;
            this.btnArhiva.Click += new System.EventHandler(this.btnArhiva_Click);
            // 
            // gbPopisStudenata
            // 
            this.gbPopisStudenata.Controls.Add(this.flpSudionici);
            this.gbPopisStudenata.Location = new System.Drawing.Point(1023, 51);
            this.gbPopisStudenata.Name = "gbPopisStudenata";
            this.gbPopisStudenata.Size = new System.Drawing.Size(200, 476);
            this.gbPopisStudenata.TabIndex = 176;
            this.gbPopisStudenata.TabStop = false;
            this.gbPopisStudenata.Text = "Popis studenata";
            // 
            // flpSudionici
            // 
            this.flpSudionici.Location = new System.Drawing.Point(4, 22);
            this.flpSudionici.Name = "flpSudionici";
            this.flpSudionici.Size = new System.Drawing.Size(186, 451);
            this.flpSudionici.TabIndex = 1;
            // 
            // btnDetaljiTermina
            // 
            this.btnDetaljiTermina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDetaljiTermina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetaljiTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetaljiTermina.Location = new System.Drawing.Point(511, 69);
            this.btnDetaljiTermina.Name = "btnDetaljiTermina";
            this.btnDetaljiTermina.Size = new System.Drawing.Size(120, 23);
            this.btnDetaljiTermina.TabIndex = 177;
            this.btnDetaljiTermina.Text = "DETALJI TERMINA";
            this.btnDetaljiTermina.UseVisualStyleBackColor = false;
            this.btnDetaljiTermina.Click += new System.EventHandler(this.btnDetaljiTermina_Click);
            // 
            // frmObavijestiInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1235, 541);
            this.Controls.Add(this.btnDetaljiTermina);
            this.Controls.Add(this.gbPopisStudenata);
            this.Controls.Add(this.btnArhiva);
            this.Controls.Add(this.btnPrikaziSveObavijesti);
            this.Controls.Add(this.btnAzurirajObavijest);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.gbDatumObavijesti);
            this.Controls.Add(this.comboPopisTermina);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.lblPretrazivanje);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.lblTermin);
            this.Controls.Add(this.btnProcitaj);
            this.Controls.Add(this.dgvPopisObavijesti);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbInstruktor);
            this.Controls.Add(this.gbIzbornik);
            this.Name = "frmObavijestiInstruktor";
            this.Text = "Obavijesti";
            this.Load += new System.EventHandler(this.frmObavijestiInstruktor_Load);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            this.gbDatumObavijesti.ResumeLayout(false);
            this.gbDatumObavijesti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisObavijesti)).EndInit();
            this.gbPopisStudenata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Button btnKreiraj;
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
        private System.Windows.Forms.Button btnAzurirajObavijest;
        private System.Windows.Forms.Button btnPrikaziSveObavijesti;
        private System.Windows.Forms.Button btnArhiva;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnGrupe;
        private System.Windows.Forms.GroupBox gbPopisStudenata;
        private System.Windows.Forms.FlowLayoutPanel flpSudionici;
        private System.Windows.Forms.Button btnDetaljiTermina;
    }
}