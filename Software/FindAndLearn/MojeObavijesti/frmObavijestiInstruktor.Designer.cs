
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnRezervacije = new System.Windows.Forms.Button();
            this.btnGrupe = new System.Windows.Forms.Button();
            this.btnPitanjaIOdgovori = new System.Windows.Forms.Button();
            this.btnInstrukcije = new System.Windows.Forms.Button();
            this.btnRecenzije = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
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
            this.btnAzurirajObavijest = new System.Windows.Forms.Button();
            this.btnPrikaziSveObavijesti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbProfil.SuspendLayout();
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbDatumObavijesti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisObavijesti)).BeginInit();
            this.SuspendLayout();
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
            this.gbInstruktor.Controls.Add(this.btnOdjava);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(171, -6);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(911, 49);
            this.gbInstruktor.TabIndex = 102;
            this.gbInstruktor.TabStop = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(665, 14);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(90, 25);
            this.btnOdjava.TabIndex = 29;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(765, 14);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 25);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnProfil
            // 
            this.btnProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfil.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProfil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfil.Location = new System.Drawing.Point(20, 48);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(184, 31);
            this.btnProfil.TabIndex = 30;
            this.btnProfil.Text = "PROFIL";
            this.btnProfil.UseVisualStyleBackColor = false;
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnProfil);
            this.gbIzbornik.Controls.Add(this.btnRezervacije);
            this.gbIzbornik.Controls.Add(this.btnGrupe);
            this.gbIzbornik.Controls.Add(this.btnPitanjaIOdgovori);
            this.gbIzbornik.Controls.Add(this.btnInstrukcije);
            this.gbIzbornik.Controls.Add(this.btnRecenzije);
            this.gbIzbornik.Location = new System.Drawing.Point(-10, 36);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
            this.gbIzbornik.TabIndex = 101;
            this.gbIzbornik.TabStop = false;
            // 
            // btnRezervacije
            // 
            this.btnRezervacije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervacije.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRezervacije.Location = new System.Drawing.Point(20, 162);
            this.btnRezervacije.Name = "btnRezervacije";
            this.btnRezervacije.Size = new System.Drawing.Size(184, 31);
            this.btnRezervacije.TabIndex = 29;
            this.btnRezervacije.Text = "REZERVACIJE ";
            this.btnRezervacije.UseVisualStyleBackColor = false;
            // 
            // btnGrupe
            // 
            this.btnGrupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnGrupe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrupe.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGrupe.Location = new System.Drawing.Point(20, 125);
            this.btnGrupe.Name = "btnGrupe";
            this.btnGrupe.Size = new System.Drawing.Size(184, 31);
            this.btnGrupe.TabIndex = 28;
            this.btnGrupe.Text = "OBAVIJESTI";
            this.btnGrupe.UseVisualStyleBackColor = false;
            // 
            // btnPitanjaIOdgovori
            // 
            this.btnPitanjaIOdgovori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnPitanjaIOdgovori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPitanjaIOdgovori.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPitanjaIOdgovori.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPitanjaIOdgovori.Location = new System.Drawing.Point(20, 237);
            this.btnPitanjaIOdgovori.Name = "btnPitanjaIOdgovori";
            this.btnPitanjaIOdgovori.Size = new System.Drawing.Size(184, 31);
            this.btnPitanjaIOdgovori.TabIndex = 26;
            this.btnPitanjaIOdgovori.Text = "PORUKE";
            this.btnPitanjaIOdgovori.UseVisualStyleBackColor = false;
            // 
            // btnInstrukcije
            // 
            this.btnInstrukcije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnInstrukcije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstrukcije.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInstrukcije.Location = new System.Drawing.Point(20, 87);
            this.btnInstrukcije.Name = "btnInstrukcije";
            this.btnInstrukcije.Size = new System.Drawing.Size(184, 31);
            this.btnInstrukcije.TabIndex = 24;
            this.btnInstrukcije.Text = "INSTRUKCIJE";
            this.btnInstrukcije.UseVisualStyleBackColor = false;
            // 
            // btnRecenzije
            // 
            this.btnRecenzije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRecenzije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecenzije.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecenzije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRecenzije.Location = new System.Drawing.Point(20, 200);
            this.btnRecenzije.Name = "btnRecenzije";
            this.btnRecenzije.Size = new System.Drawing.Size(184, 31);
            this.btnRecenzije.TabIndex = 20;
            this.btnRecenzije.Text = "RECENZIJE";
            this.btnRecenzije.UseVisualStyleBackColor = false;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKreiraj.Location = new System.Drawing.Point(555, 435);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(125, 23);
            this.btnKreiraj.TabIndex = 120;
            this.btnKreiraj.Text = "KREIRAJ OBAVIJEST";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // lblNazivTermina
            // 
            this.lblNazivTermina.AutoSize = true;
            this.lblNazivTermina.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTermina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.lblNazivTermina.Location = new System.Drawing.Point(227, 62);
            this.lblNazivTermina.Name = "lblNazivTermina";
            this.lblNazivTermina.Size = new System.Drawing.Size(138, 26);
            this.lblNazivTermina.TabIndex = 122;
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
            this.gbDatumObavijesti.Location = new System.Drawing.Point(831, 175);
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
            this.comboPopisTermina.Location = new System.Drawing.Point(346, 101);
            this.comboPopisTermina.Name = "comboPopisTermina";
            this.comboPopisTermina.Size = new System.Drawing.Size(160, 21);
            this.comboPopisTermina.TabIndex = 121;
            // 
            // txtNaslov
            // 
            this.txtNaslov.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaslov.Location = new System.Drawing.Point(346, 130);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(239, 22);
            this.txtNaslov.TabIndex = 117;
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(229, 132);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(110, 15);
            this.lblPretrazivanje.TabIndex = 116;
            this.lblPretrazivanje.Text = "Pretraži po naslovu:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.Location = new System.Drawing.Point(591, 129);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(105, 23);
            this.btnPretrazi.TabIndex = 115;
            this.btnPretrazi.Text = "PRETRAŽI";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // lblTermin
            // 
            this.lblTermin.AutoSize = true;
            this.lblTermin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTermin.Location = new System.Drawing.Point(230, 101);
            this.lblTermin.Name = "lblTermin";
            this.lblTermin.Size = new System.Drawing.Size(89, 15);
            this.lblTermin.TabIndex = 119;
            this.lblTermin.Text = "Odaberi termin:";
            // 
            // btnProcitaj
            // 
            this.btnProcitaj.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProcitaj.Location = new System.Drawing.Point(687, 435);
            this.btnProcitaj.Name = "btnProcitaj";
            this.btnProcitaj.Size = new System.Drawing.Size(126, 23);
            this.btnProcitaj.TabIndex = 114;
            this.btnProcitaj.Text = "PROČITAJ OBAVIJEST";
            this.btnProcitaj.UseVisualStyleBackColor = true;
            this.btnProcitaj.Click += new System.EventHandler(this.btnProcitaj_Click);
            // 
            // dgvPopisObavijesti
            // 
            this.dgvPopisObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisObavijesti.Location = new System.Drawing.Point(233, 174);
            this.dgvPopisObavijesti.Name = "dgvPopisObavijesti";
            this.dgvPopisObavijesti.Size = new System.Drawing.Size(582, 252);
            this.dgvPopisObavijesti.TabIndex = 113;
            // 
            // btnAzurirajObavijest
            // 
            this.btnAzurirajObavijest.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajObavijest.Location = new System.Drawing.Point(425, 435);
            this.btnAzurirajObavijest.Name = "btnAzurirajObavijest";
            this.btnAzurirajObavijest.Size = new System.Drawing.Size(125, 23);
            this.btnAzurirajObavijest.TabIndex = 123;
            this.btnAzurirajObavijest.Text = "AŽURIRAJ OBAVIJEST";
            this.btnAzurirajObavijest.UseVisualStyleBackColor = true;
            this.btnAzurirajObavijest.Click += new System.EventHandler(this.btnAzurirajObavijest_Click);
            // 
            // btnPrikaziSveObavijesti
            // 
            this.btnPrikaziSveObavijesti.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziSveObavijesti.Location = new System.Drawing.Point(700, 128);
            this.btnPrikaziSveObavijesti.Name = "btnPrikaziSveObavijesti";
            this.btnPrikaziSveObavijesti.Size = new System.Drawing.Size(115, 23);
            this.btnPrikaziSveObavijesti.TabIndex = 134;
            this.btnPrikaziSveObavijesti.Text = "PRIKAŽI SVE ";
            this.btnPrikaziSveObavijesti.UseVisualStyleBackColor = true;
            this.btnPrikaziSveObavijesti.Click += new System.EventHandler(this.btnPrikaziSveObavijesti_Click);
            // 
            // frmObavijestiInstruktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1059, 541);
            this.Controls.Add(this.btnPrikaziSveObavijesti);
            this.Controls.Add(this.btnAzurirajObavijest);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.lblNazivTermina);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
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
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Button btnRezervacije;
        private System.Windows.Forms.Button btnGrupe;
        private System.Windows.Forms.Button btnPitanjaIOdgovori;
        private System.Windows.Forms.Button btnInstrukcije;
        private System.Windows.Forms.Button btnRecenzije;
        private System.Windows.Forms.Button btnKreiraj;
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
        private System.Windows.Forms.Button btnAzurirajObavijest;
        private System.Windows.Forms.Button btnPrikaziSveObavijesti;
    }
}