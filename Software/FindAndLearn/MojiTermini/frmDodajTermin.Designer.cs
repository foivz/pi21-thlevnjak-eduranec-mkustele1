
namespace FindAndLearn.MojiTermini
{
    partial class frmDodajTermin
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
            this.components = new System.ComponentModel.Container();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.lblVrijemeTermina = new System.Windows.Forms.Label();
            this.lblNazivTermina = new System.Windows.Forms.Label();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnTermin = new System.Windows.Forms.Button();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrajanjeTermina = new System.Windows.Forms.Label();
            this.lblMjestoOdrzavanja = new System.Windows.Forms.Label();
            this.lblKapacitetTermina = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dtpVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.lblStud = new System.Windows.Forms.Label();
            this.iDterminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivterminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeterminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoodrzavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetterminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instrukcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDodajTermin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajTermin.Location = new System.Drawing.Point(513, 472);
            this.btnDodajTermin.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(203, 31);
            this.btnDodajTermin.TabIndex = 123;
            this.btnDodajTermin.Text = "Dodaj termin";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // lblVrijemeTermina
            // 
            this.lblVrijemeTermina.AutoSize = true;
            this.lblVrijemeTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrijemeTermina.Location = new System.Drawing.Point(311, 169);
            this.lblVrijemeTermina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrijemeTermina.Name = "lblVrijemeTermina";
            this.lblVrijemeTermina.Size = new System.Drawing.Size(148, 20);
            this.lblVrijemeTermina.TabIndex = 128;
            this.lblVrijemeTermina.Text = "Vrijeme termina:";
            // 
            // lblNazivTermina
            // 
            this.lblNazivTermina.AutoSize = true;
            this.lblNazivTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTermina.Location = new System.Drawing.Point(311, 122);
            this.lblNazivTermina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNazivTermina.Name = "lblNazivTermina";
            this.lblNazivTermina.Size = new System.Drawing.Size(131, 20);
            this.lblNazivTermina.TabIndex = 124;
            this.lblNazivTermina.Text = "Naziv termina:";
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnOdjava);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(234, 3);
            this.gbInstruktor.Margin = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Padding = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Size = new System.Drawing.Size(1613, 60);
            this.gbInstruktor.TabIndex = 126;
            this.gbInstruktor.TabStop = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(1032, 16);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(120, 31);
            this.btnOdjava.TabIndex = 29;
            this.btnOdjava.Text = "ODJAVA";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(1188, 16);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(120, 31);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(77, 21);
            this.lblInstruktor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(95, 20);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Instruktor ";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(24, 496);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(245, 38);
            this.btnZatvori.TabIndex = 25;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Controls.Add(this.btnTermin);
            this.gbIzbornik.Location = new System.Drawing.Point(-8, 54);
            this.gbIzbornik.Margin = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Padding = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Size = new System.Drawing.Size(289, 809);
            this.gbIzbornik.TabIndex = 125;
            this.gbIzbornik.TabStop = false;
            // 
            // btnTermin
            // 
            this.btnTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnTermin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermin.Location = new System.Drawing.Point(24, 50);
            this.btnTermin.Margin = new System.Windows.Forms.Padding(4);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(245, 38);
            this.btnTermin.TabIndex = 24;
            this.btnTermin.Text = "TERMINI";
            this.btnTermin.UseVisualStyleBackColor = false;
            // 
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.label2);
            this.gbProfil.Location = new System.Drawing.Point(0, 1);
            this.gbProfil.Margin = new System.Windows.Forms.Padding(4);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Padding = new System.Windows.Forms.Padding(4);
            this.gbProfil.Size = new System.Drawing.Size(281, 92);
            this.gbProfil.TabIndex = 127;
            this.gbProfil.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 15);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(101, 73);
            this.pbLogo.TabIndex = 69;
            this.pbLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.label2.Location = new System.Drawing.Point(103, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "PROFIL";
            // 
            // lblTrajanjeTermina
            // 
            this.lblTrajanjeTermina.AutoSize = true;
            this.lblTrajanjeTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrajanjeTermina.Location = new System.Drawing.Point(311, 220);
            this.lblTrajanjeTermina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrajanjeTermina.Name = "lblTrajanjeTermina";
            this.lblTrajanjeTermina.Size = new System.Drawing.Size(152, 20);
            this.lblTrajanjeTermina.TabIndex = 129;
            this.lblTrajanjeTermina.Text = "Trajanje termina:";
            // 
            // lblMjestoOdrzavanja
            // 
            this.lblMjestoOdrzavanja.AutoSize = true;
            this.lblMjestoOdrzavanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjestoOdrzavanja.Location = new System.Drawing.Point(311, 271);
            this.lblMjestoOdrzavanja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMjestoOdrzavanja.Name = "lblMjestoOdrzavanja";
            this.lblMjestoOdrzavanja.Size = new System.Drawing.Size(168, 20);
            this.lblMjestoOdrzavanja.TabIndex = 140;
            this.lblMjestoOdrzavanja.Text = "Mjesto održavanja:";
            // 
            // lblKapacitetTermina
            // 
            this.lblKapacitetTermina.AutoSize = true;
            this.lblKapacitetTermina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKapacitetTermina.Location = new System.Drawing.Point(311, 326);
            this.lblKapacitetTermina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKapacitetTermina.Name = "lblKapacitetTermina";
            this.lblKapacitetTermina.Size = new System.Drawing.Size(163, 20);
            this.lblKapacitetTermina.TabIndex = 141;
            this.lblKapacitetTermina.Text = "Kapacitet termina:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(513, 122);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(253, 22);
            this.txtNaziv.TabIndex = 142;
            // 
            // dtpVrijeme
            // 
            this.dtpVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVrijeme.Location = new System.Drawing.Point(513, 167);
            this.dtpVrijeme.Name = "dtpVrijeme";
            this.dtpVrijeme.Size = new System.Drawing.Size(253, 22);
            this.dtpVrijeme.TabIndex = 143;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Location = new System.Drawing.Point(513, 220);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(253, 22);
            this.txtTrajanje.TabIndex = 144;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(772, 223);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(50, 17);
            this.lblMin.TabIndex = 145;
            this.lblMin.Text = "minuta";
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(513, 271);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(253, 22);
            this.txtMjesto.TabIndex = 146;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(513, 324);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(100, 22);
            this.txtKapacitet.TabIndex = 147;
            // 
            // dgvTermini
            // 
            this.dgvTermini.AutoGenerateColumns = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDterminaDataGridViewTextBoxColumn,
            this.nazivterminaDataGridViewTextBoxColumn,
            this.vrijemeterminaDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.mjestoodrzavanjaDataGridViewTextBoxColumn,
            this.kapacitetterminaDataGridViewTextBoxColumn});
            this.dgvTermini.DataSource = this.terminiBindingSource;
            this.dgvTermini.Location = new System.Drawing.Point(828, 104);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(715, 325);
            this.dgvTermini.TabIndex = 148;
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnObrisiTermin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiTermin.Location = new System.Drawing.Point(1126, 472);
            this.btnObrisiTermin.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(203, 31);
            this.btnObrisiTermin.TabIndex = 149;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = false;
            this.btnObrisiTermin.Click += new System.EventHandler(this.btnObrisiTermin_Click);
            // 
            // lblStud
            // 
            this.lblStud.AutoSize = true;
            this.lblStud.Location = new System.Drawing.Point(619, 327);
            this.lblStud.Name = "lblStud";
            this.lblStud.Size = new System.Drawing.Size(71, 17);
            this.lblStud.TabIndex = 150;
            this.lblStud.Text = "studenata";
            // 
            // iDterminaDataGridViewTextBoxColumn
            // 
            this.iDterminaDataGridViewTextBoxColumn.DataPropertyName = "ID_termina";
            this.iDterminaDataGridViewTextBoxColumn.HeaderText = "ID termina";
            this.iDterminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDterminaDataGridViewTextBoxColumn.Name = "iDterminaDataGridViewTextBoxColumn";
            this.iDterminaDataGridViewTextBoxColumn.Width = 93;
            // 
            // nazivterminaDataGridViewTextBoxColumn
            // 
            this.nazivterminaDataGridViewTextBoxColumn.DataPropertyName = "naziv_termina";
            this.nazivterminaDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivterminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivterminaDataGridViewTextBoxColumn.Name = "nazivterminaDataGridViewTextBoxColumn";
            this.nazivterminaDataGridViewTextBoxColumn.Width = 72;
            // 
            // vrijemeterminaDataGridViewTextBoxColumn
            // 
            this.vrijemeterminaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_termina";
            this.vrijemeterminaDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeterminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrijemeterminaDataGridViewTextBoxColumn.Name = "vrijemeterminaDataGridViewTextBoxColumn";
            this.vrijemeterminaDataGridViewTextBoxColumn.Width = 84;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.Width = 89;
            // 
            // mjestoodrzavanjaDataGridViewTextBoxColumn
            // 
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.DataPropertyName = "mjesto_odrzavanja";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.HeaderText = "Mjesto održavanja";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.Name = "mjestoodrzavanjaDataGridViewTextBoxColumn";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.Width = 139;
            // 
            // kapacitetterminaDataGridViewTextBoxColumn
            // 
            this.kapacitetterminaDataGridViewTextBoxColumn.DataPropertyName = "kapacitet_termina";
            this.kapacitetterminaDataGridViewTextBoxColumn.HeaderText = "Kapacitet";
            this.kapacitetterminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kapacitetterminaDataGridViewTextBoxColumn.Name = "kapacitetterminaDataGridViewTextBoxColumn";
            this.kapacitetterminaDataGridViewTextBoxColumn.Width = 96;
            // 
            // terminiBindingSource
            // 
            this.terminiBindingSource.DataSource = typeof(FindAndLearn.Termini);
            // 
            // instrukcijeBindingSource
            // 
            this.instrukcijeBindingSource.DataSource = typeof(FindAndLearn.Instrukcije);
            // 
            // frmDodajTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 628);
            this.Controls.Add(this.lblStud);
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.dtpVrijeme);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblKapacitetTermina);
            this.Controls.Add(this.lblMjestoOdrzavanja);
            this.Controls.Add(this.btnDodajTermin);
            this.Controls.Add(this.lblTrajanjeTermina);
            this.Controls.Add(this.lblVrijemeTermina);
            this.Controls.Add(this.lblNazivTermina);
            this.Controls.Add(this.gbInstruktor);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.gbProfil);
            this.Name = "frmDodajTermin";
            this.Text = "frmDodajTermin";
            this.Load += new System.EventHandler(this.frmDodajTermin_Load);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource instrukcijeBindingSource;
        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.Label lblVrijemeTermina;
        private System.Windows.Forms.Label lblNazivTermina;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Button btnTermin;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTrajanjeTermina;
        private System.Windows.Forms.Label lblMjestoOdrzavanja;
        private System.Windows.Forms.Label lblKapacitetTermina;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DateTimePicker dtpVrijeme;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.BindingSource terminiBindingSource;
        private System.Windows.Forms.Button btnObrisiTermin;
        private System.Windows.Forms.Label lblStud;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDterminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivterminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeterminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoodrzavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetterminaDataGridViewTextBoxColumn;
    }
}