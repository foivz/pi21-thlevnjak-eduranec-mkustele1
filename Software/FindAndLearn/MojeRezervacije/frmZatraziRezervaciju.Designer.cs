
namespace FindAndLearn.MojeRezervacije
{
    partial class frmZatraziRezervaciju
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
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnZatraziRezervaciju = new System.Windows.Forms.Button();
            this.btnTermin = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.lblInstrukcije = new System.Windows.Forms.Label();
            this.lblTerminiZaOdabranu = new System.Windows.Forms.Label();
            this.dgvInstrukcije = new System.Windows.Forms.DataGridView();
            this.dgvtTermini = new System.Windows.Forms.DataGridView();
            this.dgvOdobreneRezervacije = new System.Windows.Forms.DataGridView();
            this.terminiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instruktoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolegijiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipinstrukcijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisinstrukcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenainstrukcijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrukcijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nazivterminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeterminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoodrzavanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapacitetterminaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrukcije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdobreneRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnOdjava);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(229, -2);
            this.gbInstruktor.Margin = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Padding = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Size = new System.Drawing.Size(1613, 60);
            this.gbInstruktor.TabIndex = 154;
            this.gbInstruktor.TabStop = false;
            // 
            // btnZatraziRezervaciju
            // 
            this.btnZatraziRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatraziRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatraziRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatraziRezervaciju.Location = new System.Drawing.Point(1122, 512);
            this.btnZatraziRezervaciju.Margin = new System.Windows.Forms.Padding(4);
            this.btnZatraziRezervaciju.Name = "btnZatraziRezervaciju";
            this.btnZatraziRezervaciju.Size = new System.Drawing.Size(203, 31);
            this.btnZatraziRezervaciju.TabIndex = 151;
            this.btnZatraziRezervaciju.Text = "Zatraži rezervaciju";
            this.btnZatraziRezervaciju.UseVisualStyleBackColor = false;
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
            this.gbIzbornik.Location = new System.Drawing.Point(-13, 49);
            this.gbIzbornik.Margin = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Padding = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Size = new System.Drawing.Size(289, 809);
            this.gbIzbornik.TabIndex = 153;
            this.gbIzbornik.TabStop = false;
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
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.label2);
            this.gbProfil.Location = new System.Drawing.Point(-5, -4);
            this.gbProfil.Margin = new System.Windows.Forms.Padding(4);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Padding = new System.Windows.Forms.Padding(4);
            this.gbProfil.Size = new System.Drawing.Size(281, 92);
            this.gbProfil.TabIndex = 155;
            this.gbProfil.TabStop = false;
            // 
            // lblInstrukcije
            // 
            this.lblInstrukcije.AutoSize = true;
            this.lblInstrukcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstrukcije.Location = new System.Drawing.Point(306, 117);
            this.lblInstrukcije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrukcije.Name = "lblInstrukcije";
            this.lblInstrukcije.Size = new System.Drawing.Size(102, 20);
            this.lblInstrukcije.TabIndex = 152;
            this.lblInstrukcije.Text = "Instrukcije:";
            // 
            // lblTerminiZaOdabranu
            // 
            this.lblTerminiZaOdabranu.AutoSize = true;
            this.lblTerminiZaOdabranu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTerminiZaOdabranu.Location = new System.Drawing.Point(1058, 117);
            this.lblTerminiZaOdabranu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTerminiZaOdabranu.Name = "lblTerminiZaOdabranu";
            this.lblTerminiZaOdabranu.Size = new System.Drawing.Size(280, 20);
            this.lblTerminiZaOdabranu.TabIndex = 156;
            this.lblTerminiZaOdabranu.Text = "Termini za odabranu instrukciju:";
            // 
            // dgvInstrukcije
            // 
            this.dgvInstrukcije.AutoGenerateColumns = false;
            this.dgvInstrukcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstrukcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instruktoriDataGridViewTextBoxColumn,
            this.kolegijiDataGridViewTextBoxColumn,
            this.tipinstrukcijaDataGridViewTextBoxColumn,
            this.opisinstrukcijeDataGridViewTextBoxColumn,
            this.cijenainstrukcijeDataGridViewTextBoxColumn});
            this.dgvInstrukcije.DataSource = this.instrukcijeBindingSource;
            this.dgvInstrukcije.Location = new System.Drawing.Point(310, 155);
            this.dgvInstrukcije.Name = "dgvInstrukcije";
            this.dgvInstrukcije.RowHeadersWidth = 51;
            this.dgvInstrukcije.RowTemplate.Height = 24;
            this.dgvInstrukcije.Size = new System.Drawing.Size(579, 330);
            this.dgvInstrukcije.TabIndex = 157;
            // 
            // dgvtTermini
            // 
            this.dgvtTermini.AutoGenerateColumns = false;
            this.dgvtTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtTermini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivterminaDataGridViewTextBoxColumn,
            this.vrijemeterminaDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.mjestoodrzavanjaDataGridViewTextBoxColumn,
            this.kapacitetterminaDataGridViewTextBoxColumn});
            this.dgvtTermini.DataSource = this.terminiBindingSource;
            this.dgvtTermini.Location = new System.Drawing.Point(978, 155);
            this.dgvtTermini.Name = "dgvtTermini";
            this.dgvtTermini.RowHeadersWidth = 51;
            this.dgvtTermini.RowTemplate.Height = 24;
            this.dgvtTermini.Size = new System.Drawing.Size(579, 330);
            this.dgvtTermini.TabIndex = 158;
            // 
            // dgvOdobreneRezervacije
            // 
            this.dgvOdobreneRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdobreneRezervacije.Location = new System.Drawing.Point(310, 545);
            this.dgvOdobreneRezervacije.Name = "dgvOdobreneRezervacije";
            this.dgvOdobreneRezervacije.RowHeadersWidth = 51;
            this.dgvOdobreneRezervacije.RowTemplate.Height = 24;
            this.dgvOdobreneRezervacije.Size = new System.Drawing.Size(579, 330);
            this.dgvOdobreneRezervacije.TabIndex = 159;
            // 
            // terminiBindingSource
            // 
            this.terminiBindingSource.DataSource = typeof(FindAndLearn.Termini);
            // 
            // instruktoriDataGridViewTextBoxColumn
            // 
            this.instruktoriDataGridViewTextBoxColumn.DataPropertyName = "Instruktori";
            this.instruktoriDataGridViewTextBoxColumn.HeaderText = "Instruktori";
            this.instruktoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instruktoriDataGridViewTextBoxColumn.Name = "instruktoriDataGridViewTextBoxColumn";
            this.instruktoriDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolegijiDataGridViewTextBoxColumn
            // 
            this.kolegijiDataGridViewTextBoxColumn.DataPropertyName = "Kolegiji";
            this.kolegijiDataGridViewTextBoxColumn.HeaderText = "Kolegiji";
            this.kolegijiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolegijiDataGridViewTextBoxColumn.Name = "kolegijiDataGridViewTextBoxColumn";
            this.kolegijiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipinstrukcijaDataGridViewTextBoxColumn
            // 
            this.tipinstrukcijaDataGridViewTextBoxColumn.DataPropertyName = "Tip_instrukcija";
            this.tipinstrukcijaDataGridViewTextBoxColumn.HeaderText = "Tip_instrukcija";
            this.tipinstrukcijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipinstrukcijaDataGridViewTextBoxColumn.Name = "tipinstrukcijaDataGridViewTextBoxColumn";
            this.tipinstrukcijaDataGridViewTextBoxColumn.Width = 125;
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
            this.instrukcijeBindingSource.CurrentChanged += new System.EventHandler(this.instrukcijeBindingSource_CurrentChanged);
            // 
            // nazivterminaDataGridViewTextBoxColumn
            // 
            this.nazivterminaDataGridViewTextBoxColumn.DataPropertyName = "naziv_termina";
            this.nazivterminaDataGridViewTextBoxColumn.HeaderText = "naziv_termina";
            this.nazivterminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivterminaDataGridViewTextBoxColumn.Name = "nazivterminaDataGridViewTextBoxColumn";
            this.nazivterminaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrijemeterminaDataGridViewTextBoxColumn
            // 
            this.vrijemeterminaDataGridViewTextBoxColumn.DataPropertyName = "vrijeme_termina";
            this.vrijemeterminaDataGridViewTextBoxColumn.HeaderText = "vrijeme_termina";
            this.vrijemeterminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrijemeterminaDataGridViewTextBoxColumn.Name = "vrijemeterminaDataGridViewTextBoxColumn";
            this.vrijemeterminaDataGridViewTextBoxColumn.Width = 125;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // mjestoodrzavanjaDataGridViewTextBoxColumn
            // 
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.DataPropertyName = "mjesto_odrzavanja";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.HeaderText = "mjesto_odrzavanja";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.Name = "mjestoodrzavanjaDataGridViewTextBoxColumn";
            this.mjestoodrzavanjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kapacitetterminaDataGridViewTextBoxColumn
            // 
            this.kapacitetterminaDataGridViewTextBoxColumn.DataPropertyName = "kapacitet_termina";
            this.kapacitetterminaDataGridViewTextBoxColumn.HeaderText = "kapacitet_termina";
            this.kapacitetterminaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kapacitetterminaDataGridViewTextBoxColumn.Name = "kapacitetterminaDataGridViewTextBoxColumn";
            this.kapacitetterminaDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmZatraziRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 953);
            this.Controls.Add(this.dgvOdobreneRezervacije);
            this.Controls.Add(this.dgvtTermini);
            this.Controls.Add(this.dgvInstrukcije);
            this.Controls.Add(this.lblTerminiZaOdabranu);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.btnZatraziRezervaciju);
            this.Controls.Add(this.lblInstrukcije);
            this.Controls.Add(this.gbInstruktor);
            this.Name = "frmZatraziRezervaciju";
            this.Text = "frmZatraziRezervaciju";
            this.Load += new System.EventHandler(this.frmZatraziRezervaciju_Load);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstrukcije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdobreneRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnZatraziRezervaciju;
        private System.Windows.Forms.Button btnTermin;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.Label lblInstrukcije;
        private System.Windows.Forms.Label lblTerminiZaOdabranu;
        private System.Windows.Forms.DataGridView dgvInstrukcije;
        private System.Windows.Forms.BindingSource instrukcijeBindingSource;
        private System.Windows.Forms.DataGridView dgvtTermini;
        private System.Windows.Forms.BindingSource terminiBindingSource;
        private System.Windows.Forms.DataGridView dgvOdobreneRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruktoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolegijiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipinstrukcijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisinstrukcijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenainstrukcijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivterminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeterminaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoodrzavanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapacitetterminaDataGridViewTextBoxColumn;
    }
}