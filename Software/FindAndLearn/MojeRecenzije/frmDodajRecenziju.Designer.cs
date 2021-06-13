
namespace FindAndLearn.MojeRecenzije
{
    partial class frmDodajRecenziju
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDodajRecenziju = new System.Windows.Forms.Button();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.btnRecenzije = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.gbRecenzija = new System.Windows.Forms.GroupBox();
            this.comboOcjena = new System.Windows.Forms.ComboBox();
            this.comboInstruktor = new System.Windows.Forms.ComboBox();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblInstruktor2 = new System.Windows.Forms.Label();
            this.dgvMojeRecenzije = new System.Windows.Forms.DataGridView();
            this.btnObrisiRecenziju = new System.Windows.Forms.Button();
            this.lblMojeRecenzije = new System.Windows.Forms.Label();
            this.instruktoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komentarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recenzijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbInstruktor.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            this.gbRecenzija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeRecenzije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recenzijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.label2);
            this.gbProfil.Location = new System.Drawing.Point(-3, -2);
            this.gbProfil.Margin = new System.Windows.Forms.Padding(4);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Padding = new System.Windows.Forms.Padding(4);
            this.gbProfil.Size = new System.Drawing.Size(281, 92);
            this.gbProfil.TabIndex = 172;
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
            // btnDodajRecenziju
            // 
            this.btnDodajRecenziju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDodajRecenziju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajRecenziju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRecenziju.Location = new System.Drawing.Point(313, 38);
            this.btnDodajRecenziju.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajRecenziju.Name = "btnDodajRecenziju";
            this.btnDodajRecenziju.Size = new System.Drawing.Size(203, 36);
            this.btnDodajRecenziju.TabIndex = 169;
            this.btnDodajRecenziju.Text = "Dodaj recenziju";
            this.btnDodajRecenziju.UseVisualStyleBackColor = false;
            this.btnDodajRecenziju.Click += new System.EventHandler(this.btnDodajRecenziju_Click);
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(231, 0);
            this.gbInstruktor.Margin = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Padding = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Size = new System.Drawing.Size(1613, 60);
            this.gbInstruktor.TabIndex = 171;
            this.gbInstruktor.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(1104, 16);
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
            // btnRecenzije
            // 
            this.btnRecenzije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnRecenzije.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecenzije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRecenzije.Location = new System.Drawing.Point(24, 50);
            this.btnRecenzije.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecenzije.Name = "btnRecenzije";
            this.btnRecenzije.Size = new System.Drawing.Size(245, 38);
            this.btnRecenzije.TabIndex = 24;
            this.btnRecenzije.Text = "RECENZIJE";
            this.btnRecenzije.UseVisualStyleBackColor = false;
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Controls.Add(this.btnRecenzije);
            this.gbIzbornik.Location = new System.Drawing.Point(-11, 51);
            this.gbIzbornik.Margin = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Padding = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Size = new System.Drawing.Size(289, 809);
            this.gbIzbornik.TabIndex = 170;
            this.gbIzbornik.TabStop = false;
            // 
            // gbRecenzija
            // 
            this.gbRecenzija.Controls.Add(this.comboOcjena);
            this.gbRecenzija.Controls.Add(this.comboInstruktor);
            this.gbRecenzija.Controls.Add(this.btnDodajRecenziju);
            this.gbRecenzija.Controls.Add(this.rtbKomentar);
            this.gbRecenzija.Controls.Add(this.lblKomentar);
            this.gbRecenzija.Controls.Add(this.lblOcjena);
            this.gbRecenzija.Controls.Add(this.lblInstruktor2);
            this.gbRecenzija.Location = new System.Drawing.Point(327, 101);
            this.gbRecenzija.Name = "gbRecenzija";
            this.gbRecenzija.Size = new System.Drawing.Size(541, 484);
            this.gbRecenzija.TabIndex = 173;
            this.gbRecenzija.TabStop = false;
            this.gbRecenzija.Text = "Ostavi recenziju";
            // 
            // comboOcjena
            // 
            this.comboOcjena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOcjena.FormattingEnabled = true;
            this.comboOcjena.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboOcjena.Location = new System.Drawing.Point(106, 78);
            this.comboOcjena.Name = "comboOcjena";
            this.comboOcjena.Size = new System.Drawing.Size(141, 24);
            this.comboOcjena.TabIndex = 5;
            // 
            // comboInstruktor
            // 
            this.comboInstruktor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboInstruktor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboInstruktor.FormattingEnabled = true;
            this.comboInstruktor.Location = new System.Drawing.Point(106, 38);
            this.comboInstruktor.Name = "comboInstruktor";
            this.comboInstruktor.Size = new System.Drawing.Size(141, 24);
            this.comboInstruktor.TabIndex = 4;
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(20, 154);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(496, 311);
            this.rtbKomentar.TabIndex = 3;
            this.rtbKomentar.Text = "";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomentar.Location = new System.Drawing.Point(16, 121);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(86, 20);
            this.lblKomentar.TabIndex = 2;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjena.Location = new System.Drawing.Point(16, 78);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(67, 20);
            this.lblOcjena.TabIndex = 1;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblInstruktor2
            // 
            this.lblInstruktor2.AutoSize = true;
            this.lblInstruktor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruktor2.Location = new System.Drawing.Point(16, 38);
            this.lblInstruktor2.Name = "lblInstruktor2";
            this.lblInstruktor2.Size = new System.Drawing.Size(84, 20);
            this.lblInstruktor2.TabIndex = 0;
            this.lblInstruktor2.Text = "Instruktor:";
            // 
            // dgvMojeRecenzije
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.dgvMojeRecenzije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMojeRecenzije.AutoGenerateColumns = false;
            this.dgvMojeRecenzije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMojeRecenzije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMojeRecenzije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMojeRecenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeRecenzije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.instruktoriDataGridViewTextBoxColumn,
            this.ocjenaDataGridViewTextBoxColumn,
            this.komentarDataGridViewTextBoxColumn});
            this.dgvMojeRecenzije.DataSource = this.recenzijeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMojeRecenzije.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMojeRecenzije.Location = new System.Drawing.Point(896, 139);
            this.dgvMojeRecenzije.Name = "dgvMojeRecenzije";
            this.dgvMojeRecenzije.RowHeadersWidth = 51;
            this.dgvMojeRecenzije.RowTemplate.Height = 24;
            this.dgvMojeRecenzije.Size = new System.Drawing.Size(535, 344);
            this.dgvMojeRecenzije.TabIndex = 174;
            // 
            // btnObrisiRecenziju
            // 
            this.btnObrisiRecenziju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnObrisiRecenziju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiRecenziju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiRecenziju.Location = new System.Drawing.Point(1078, 512);
            this.btnObrisiRecenziju.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiRecenziju.Name = "btnObrisiRecenziju";
            this.btnObrisiRecenziju.Size = new System.Drawing.Size(203, 36);
            this.btnObrisiRecenziju.TabIndex = 170;
            this.btnObrisiRecenziju.Text = "Obriši recenziju";
            this.btnObrisiRecenziju.UseVisualStyleBackColor = false;
            this.btnObrisiRecenziju.Click += new System.EventHandler(this.btnObrisiRecenziju_Click);
            // 
            // lblMojeRecenzije
            // 
            this.lblMojeRecenzije.AutoSize = true;
            this.lblMojeRecenzije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMojeRecenzije.Location = new System.Drawing.Point(892, 110);
            this.lblMojeRecenzije.Name = "lblMojeRecenzije";
            this.lblMojeRecenzije.Size = new System.Drawing.Size(138, 20);
            this.lblMojeRecenzije.TabIndex = 170;
            this.lblMojeRecenzije.Text = "Moje recenzije:";
            // 
            // instruktoriDataGridViewTextBoxColumn
            // 
            this.instruktoriDataGridViewTextBoxColumn.DataPropertyName = "Instruktori";
            this.instruktoriDataGridViewTextBoxColumn.HeaderText = "Instruktor";
            this.instruktoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instruktoriDataGridViewTextBoxColumn.Name = "instruktoriDataGridViewTextBoxColumn";
            this.instruktoriDataGridViewTextBoxColumn.Width = 96;
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            this.ocjenaDataGridViewTextBoxColumn.Width = 82;
            // 
            // komentarDataGridViewTextBoxColumn
            // 
            this.komentarDataGridViewTextBoxColumn.DataPropertyName = "komentar";
            this.komentarDataGridViewTextBoxColumn.HeaderText = "Komentar";
            this.komentarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.komentarDataGridViewTextBoxColumn.Name = "komentarDataGridViewTextBoxColumn";
            this.komentarDataGridViewTextBoxColumn.Width = 98;
            // 
            // recenzijeBindingSource
            // 
            this.recenzijeBindingSource.DataSource = typeof(FindAndLearn.Recenzije);
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataSource = typeof(FindAndLearn.Rezervacije);
            // 
            // frmDodajRecenziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 615);
            this.Controls.Add(this.lblMojeRecenzije);
            this.Controls.Add(this.btnObrisiRecenziju);
            this.Controls.Add(this.dgvMojeRecenzije);
            this.Controls.Add(this.gbRecenzija);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbInstruktor);
            this.Controls.Add(this.gbIzbornik);
            this.Name = "frmDodajRecenziju";
            this.Text = "frmDodajRecenziju";
            this.Load += new System.EventHandler(this.frmDodajRecenziju_Load);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            this.gbRecenzija.ResumeLayout(false);
            this.gbRecenzija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMojeRecenzije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recenzijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private System.Windows.Forms.Button btnDodajRecenziju;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Button btnRecenzije;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.GroupBox gbRecenzija;
        private System.Windows.Forms.ComboBox comboOcjena;
        private System.Windows.Forms.ComboBox comboInstruktor;
        private System.Windows.Forms.RichTextBox rtbKomentar;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblOcjena;
        private System.Windows.Forms.Label lblInstruktor2;
        private System.Windows.Forms.DataGridView dgvMojeRecenzije;
        private System.Windows.Forms.BindingSource recenzijeBindingSource;
        private System.Windows.Forms.Button btnObrisiRecenziju;
        private System.Windows.Forms.DataGridViewTextBoxColumn instruktoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocjenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn komentarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMojeRecenzije;
    }
}