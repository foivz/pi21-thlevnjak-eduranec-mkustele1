
namespace FindAndLearn.MojeInstrukcije
{
    partial class frmDodajInstrukciju
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.btnInstrukcije = new System.Windows.Forms.Button();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblTipInstrukcija = new System.Windows.Forms.Label();
            this.lblVrstaKolegija = new System.Windows.Forms.Label();
            this.lblOpisInstrukcije = new System.Windows.Forms.Label();
            this.lblCijenaInstrukcije = new System.Windows.Forms.Label();
            this.comboTipInstrukcija = new System.Windows.Forms.ComboBox();
            this.comboVrstaKolegija = new System.Windows.Forms.ComboBox();
            this.txtOpisInstrukcije = new System.Windows.Forms.RichTextBox();
            this.btnDodajInstrukciju = new System.Windows.Forms.Button();
            this.dgvMojeInstrukcije = new System.Windows.Forms.DataGridView();
            this.lblMojeInstrukcije = new System.Windows.Forms.Label();
            this.btnTermin = new System.Windows.Forms.Button();
            this.textCijenaInstrukcije = new System.Windows.Forms.TextBox();
            this.btnObrisiInstrukciju = new System.Windows.Forms.Button();
            this.lblKn = new System.Windows.Forms.Label();
            this.iDinstrukcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipinstrukcijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolegijiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisinstrukcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenainstrukcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrukcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbProfil.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbInstruktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeInstrukcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(0, 15);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.label2);
            this.gbProfil.Location = new System.Drawing.Point(-3, -4);
            this.gbProfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbProfil.Size = new System.Drawing.Size(281, 92);
            this.gbProfil.TabIndex = 108;
            this.gbProfil.TabStop = false;
            // 
            // btnInstrukcije
            // 
            this.btnInstrukcije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnInstrukcije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstrukcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInstrukcije.Location = new System.Drawing.Point(24, 50);
            this.btnInstrukcije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstrukcije.Name = "btnInstrukcije";
            this.btnInstrukcije.Size = new System.Drawing.Size(245, 38);
            this.btnInstrukcije.TabIndex = 24;
            this.btnInstrukcije.Text = "INSTRUKCIJE";
            this.btnInstrukcije.UseVisualStyleBackColor = false;
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
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Controls.Add(this.btnInstrukcije);
            this.gbIzbornik.Location = new System.Drawing.Point(-11, 49);
            this.gbIzbornik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIzbornik.Size = new System.Drawing.Size(289, 809);
            this.gbIzbornik.TabIndex = 106;
            this.gbIzbornik.TabStop = false;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(24, 496);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(245, 38);
            this.btnZatvori.TabIndex = 25;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = false;
            this.btnZatvori.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnOdjava);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(231, -2);
            this.gbInstruktor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbInstruktor.Size = new System.Drawing.Size(1613, 60);
            this.gbInstruktor.TabIndex = 107;
            this.gbInstruktor.TabStop = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.Location = new System.Drawing.Point(1323, 17);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnHelp.Location = new System.Drawing.Point(1465, 17);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(120, 31);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // lblTipInstrukcija
            // 
            this.lblTipInstrukcija.AutoSize = true;
            this.lblTipInstrukcija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTipInstrukcija.Location = new System.Drawing.Point(308, 98);
            this.lblTipInstrukcija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipInstrukcija.Name = "lblTipInstrukcija";
            this.lblTipInstrukcija.Size = new System.Drawing.Size(134, 20);
            this.lblTipInstrukcija.TabIndex = 100;
            this.lblTipInstrukcija.Text = "Tip instrukcija:";
            // 
            // lblVrstaKolegija
            // 
            this.lblVrstaKolegija.AutoSize = true;
            this.lblVrstaKolegija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVrstaKolegija.Location = new System.Drawing.Point(308, 146);
            this.lblVrstaKolegija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrstaKolegija.Name = "lblVrstaKolegija";
            this.lblVrstaKolegija.Size = new System.Drawing.Size(72, 20);
            this.lblVrstaKolegija.TabIndex = 109;
            this.lblVrstaKolegija.Text = "Kolegij:";
            // 
            // lblOpisInstrukcije
            // 
            this.lblOpisInstrukcije.AutoSize = true;
            this.lblOpisInstrukcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpisInstrukcije.Location = new System.Drawing.Point(308, 203);
            this.lblOpisInstrukcije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpisInstrukcije.Name = "lblOpisInstrukcije";
            this.lblOpisInstrukcije.Size = new System.Drawing.Size(54, 20);
            this.lblOpisInstrukcije.TabIndex = 110;
            this.lblOpisInstrukcije.Text = "Opis:";
            // 
            // lblCijenaInstrukcije
            // 
            this.lblCijenaInstrukcije.AutoSize = true;
            this.lblCijenaInstrukcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCijenaInstrukcije.Location = new System.Drawing.Point(308, 545);
            this.lblCijenaInstrukcije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijenaInstrukcije.Name = "lblCijenaInstrukcije";
            this.lblCijenaInstrukcije.Size = new System.Drawing.Size(161, 20);
            this.lblCijenaInstrukcije.TabIndex = 111;
            this.lblCijenaInstrukcije.Text = "Cijena instrukcije:";
            // 
            // comboTipInstrukcija
            // 
            this.comboTipInstrukcija.FormattingEnabled = true;
            this.comboTipInstrukcija.Location = new System.Drawing.Point(459, 98);
            this.comboTipInstrukcija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTipInstrukcija.Name = "comboTipInstrukcija";
            this.comboTipInstrukcija.Size = new System.Drawing.Size(199, 24);
            this.comboTipInstrukcija.TabIndex = 112;
            // 
            // comboVrstaKolegija
            // 
            this.comboVrstaKolegija.FormattingEnabled = true;
            this.comboVrstaKolegija.Location = new System.Drawing.Point(459, 143);
            this.comboVrstaKolegija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVrstaKolegija.Name = "comboVrstaKolegija";
            this.comboVrstaKolegija.Size = new System.Drawing.Size(199, 24);
            this.comboVrstaKolegija.TabIndex = 113;
            // 
            // txtOpisInstrukcije
            // 
            this.txtOpisInstrukcije.Location = new System.Drawing.Point(312, 244);
            this.txtOpisInstrukcije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpisInstrukcije.Name = "txtOpisInstrukcije";
            this.txtOpisInstrukcije.Size = new System.Drawing.Size(569, 269);
            this.txtOpisInstrukcije.TabIndex = 115;
            this.txtOpisInstrukcije.Text = "";
            // 
            // btnDodajInstrukciju
            // 
            this.btnDodajInstrukciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDodajInstrukciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajInstrukciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajInstrukciju.Location = new System.Drawing.Point(677, 540);
            this.btnDodajInstrukciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajInstrukciju.Name = "btnDodajInstrukciju";
            this.btnDodajInstrukciju.Size = new System.Drawing.Size(203, 31);
            this.btnDodajInstrukciju.TabIndex = 30;
            this.btnDodajInstrukciju.Text = "Dodaj instrukciju";
            this.btnDodajInstrukciju.UseVisualStyleBackColor = false;
            this.btnDodajInstrukciju.Click += new System.EventHandler(this.btnDodajInstrukciju_Click);
            // 
            // dgvMojeInstrukcije
            // 
            this.dgvMojeInstrukcije.AutoGenerateColumns = false;
            this.dgvMojeInstrukcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeInstrukcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDinstrukcijeDataGridViewTextBoxColumn,
            this.tipinstrukcijaDataGridViewTextBoxColumn,
            this.kolegijiDataGridViewTextBoxColumn,
            this.opisinstrukcijeDataGridViewTextBoxColumn,
            this.cijenainstrukcijeDataGridViewTextBoxColumn});
            this.dgvMojeInstrukcije.DataSource = this.instrukcijeBindingSource;
            this.dgvMojeInstrukcije.Location = new System.Drawing.Point(992, 110);
            this.dgvMojeInstrukcije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMojeInstrukcije.Name = "dgvMojeInstrukcije";
            this.dgvMojeInstrukcije.RowHeadersWidth = 51;
            this.dgvMojeInstrukcije.RowTemplate.Height = 24;
            this.dgvMojeInstrukcije.Size = new System.Drawing.Size(764, 338);
            this.dgvMojeInstrukcije.TabIndex = 117;
            // 
            // lblMojeInstrukcije
            // 
            this.lblMojeInstrukcije.AutoSize = true;
            this.lblMojeInstrukcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMojeInstrukcije.Location = new System.Drawing.Point(988, 76);
            this.lblMojeInstrukcije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMojeInstrukcije.Name = "lblMojeInstrukcije";
            this.lblMojeInstrukcije.Size = new System.Drawing.Size(148, 20);
            this.lblMojeInstrukcije.TabIndex = 118;
            this.lblMojeInstrukcije.Text = "Moje instrukcije:";
            // 
            // btnTermin
            // 
            this.btnTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnTermin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTermin.Location = new System.Drawing.Point(1599, 503);
            this.btnTermin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(157, 31);
            this.btnTermin.TabIndex = 119;
            this.btnTermin.Text = "Termini";
            this.btnTermin.UseVisualStyleBackColor = false;
            this.btnTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // textCijenaInstrukcije
            // 
            this.textCijenaInstrukcije.Location = new System.Drawing.Point(496, 545);
            this.textCijenaInstrukcije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCijenaInstrukcije.Name = "textCijenaInstrukcije";
            this.textCijenaInstrukcije.Size = new System.Drawing.Size(88, 22);
            this.textCijenaInstrukcije.TabIndex = 120;
            // 
            // btnObrisiInstrukciju
            // 
            this.btnObrisiInstrukciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnObrisiInstrukciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiInstrukciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiInstrukciju.Location = new System.Drawing.Point(992, 503);
            this.btnObrisiInstrukciju.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObrisiInstrukciju.Name = "btnObrisiInstrukciju";
            this.btnObrisiInstrukciju.Size = new System.Drawing.Size(217, 31);
            this.btnObrisiInstrukciju.TabIndex = 121;
            this.btnObrisiInstrukciju.Text = "Obriši instrukciju";
            this.btnObrisiInstrukciju.UseVisualStyleBackColor = false;
            this.btnObrisiInstrukciju.Click += new System.EventHandler(this.btnObrisiInstrukciju_Click);
            // 
            // lblKn
            // 
            this.lblKn.AutoSize = true;
            this.lblKn.Location = new System.Drawing.Point(589, 548);
            this.lblKn.Name = "lblKn";
            this.lblKn.Size = new System.Drawing.Size(25, 17);
            this.lblKn.TabIndex = 122;
            this.lblKn.Text = "Kn";
            // 
            // iDinstrukcijeDataGridViewTextBoxColumn
            // 
            this.iDinstrukcijeDataGridViewTextBoxColumn.DataPropertyName = "ID_instrukcije";
            this.iDinstrukcijeDataGridViewTextBoxColumn.HeaderText = "ID_instrukcije";
            this.iDinstrukcijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDinstrukcijeDataGridViewTextBoxColumn.Name = "iDinstrukcijeDataGridViewTextBoxColumn";
            this.iDinstrukcijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipinstrukcijaDataGridViewTextBoxColumn
            // 
            this.tipinstrukcijaDataGridViewTextBoxColumn.DataPropertyName = "Tip_instrukcija";
            this.tipinstrukcijaDataGridViewTextBoxColumn.HeaderText = "Tip_instrukcija";
            this.tipinstrukcijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipinstrukcijaDataGridViewTextBoxColumn.Name = "tipinstrukcijaDataGridViewTextBoxColumn";
            this.tipinstrukcijaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolegijiDataGridViewTextBoxColumn
            // 
            this.kolegijiDataGridViewTextBoxColumn.DataPropertyName = "Kolegiji";
            this.kolegijiDataGridViewTextBoxColumn.HeaderText = "Kolegiji";
            this.kolegijiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolegijiDataGridViewTextBoxColumn.Name = "kolegijiDataGridViewTextBoxColumn";
            this.kolegijiDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisinstrukcijeDataGridViewTextBoxColumn
            // 
            this.opisinstrukcijeDataGridViewTextBoxColumn.DataPropertyName = "opis_instrukcije";
            this.opisinstrukcijeDataGridViewTextBoxColumn.HeaderText = "opis_instrukcije";
            this.opisinstrukcijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisinstrukcijeDataGridViewTextBoxColumn.Name = "opisinstrukcijeDataGridViewTextBoxColumn";
            this.opisinstrukcijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cijenainstrukcijeDataGridViewTextBoxColumn
            // 
            this.cijenainstrukcijeDataGridViewTextBoxColumn.DataPropertyName = "cijena_instrukcije";
            this.cijenainstrukcijeDataGridViewTextBoxColumn.HeaderText = "cijena_instrukcije";
            this.cijenainstrukcijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenainstrukcijeDataGridViewTextBoxColumn.Name = "cijenainstrukcijeDataGridViewTextBoxColumn";
            this.cijenainstrukcijeDataGridViewTextBoxColumn.Width = 125;
            // 
            // instrukcijeBindingSource
            // 
            this.instrukcijeBindingSource.DataSource = typeof(FindAndLearn.Instrukcije);
            // 
            // frmDodajInstrukciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1837, 658);
            this.Controls.Add(this.lblKn);
            this.Controls.Add(this.btnObrisiInstrukciju);
            this.Controls.Add(this.textCijenaInstrukcije);
            this.Controls.Add(this.btnTermin);
            this.Controls.Add(this.lblMojeInstrukcije);
            this.Controls.Add(this.dgvMojeInstrukcije);
            this.Controls.Add(this.btnDodajInstrukciju);
            this.Controls.Add(this.txtOpisInstrukcije);
            this.Controls.Add(this.comboVrstaKolegija);
            this.Controls.Add(this.comboTipInstrukcija);
            this.Controls.Add(this.lblCijenaInstrukcije);
            this.Controls.Add(this.lblOpisInstrukcije);
            this.Controls.Add(this.lblVrstaKolegija);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.gbInstruktor);
            this.Controls.Add(this.lblTipInstrukcija);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDodajInstrukciju";
            this.Text = "frmDodajInstrukciju";
            this.Load += new System.EventHandler(this.frmDodajInstrukciju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeInstrukcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.Button btnInstrukcije;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblTipInstrukcija;
        private System.Windows.Forms.Label lblVrstaKolegija;
        private System.Windows.Forms.Label lblOpisInstrukcije;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label lblCijenaInstrukcije;
        private System.Windows.Forms.ComboBox comboTipInstrukcija;
        private System.Windows.Forms.ComboBox comboVrstaKolegija;
        private System.Windows.Forms.RichTextBox txtOpisInstrukcije;
        private System.Windows.Forms.Button btnDodajInstrukciju;
        private System.Windows.Forms.DataGridView dgvMojeInstrukcije;
        private System.Windows.Forms.Label lblMojeInstrukcije;
        private System.Windows.Forms.Button btnTermin;
        private System.Windows.Forms.TextBox textCijenaInstrukcije;
        private System.Windows.Forms.BindingSource instrukcijeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDinstrukcijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipinstrukcijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolegijiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisinstrukcijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenainstrukcijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnObrisiInstrukciju;
        private System.Windows.Forms.Label lblKn;
    }
}