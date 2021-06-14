
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
            this.lblRecenzije = new System.Windows.Forms.Label();
            this.btnDodajRecenziju = new System.Windows.Forms.Button();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.lblTrenutniStudent = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.gbRecenzija = new System.Windows.Forms.GroupBox();
            this.comboOcjena = new System.Windows.Forms.ComboBox();
            this.comboInstruktor = new System.Windows.Forms.ComboBox();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblOcjena = new System.Windows.Forms.Label();
            this.lblInstruktor2 = new System.Windows.Forms.Label();
            this.dgvMojeRecenzije = new System.Windows.Forms.DataGridView();
            this.instruktoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocjenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komentarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recenzijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrisiRecenziju = new System.Windows.Forms.Button();
            this.lblMojeRecenzije = new System.Windows.Forms.Label();
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
            this.btnZatvori.Location = new System.Drawing.Point(18, 403);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(184, 31);
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
            this.gbProfil.Controls.Add(this.lblRecenzije);
            this.gbProfil.Location = new System.Drawing.Point(-2, -2);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Size = new System.Drawing.Size(211, 75);
            this.gbProfil.TabIndex = 172;
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
            // lblRecenzije
            // 
            this.lblRecenzije.AutoSize = true;
            this.lblRecenzije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRecenzije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblRecenzije.Location = new System.Drawing.Point(77, 28);
            this.lblRecenzije.Name = "lblRecenzije";
            this.lblRecenzije.Size = new System.Drawing.Size(99, 20);
            this.lblRecenzije.TabIndex = 68;
            this.lblRecenzije.Text = "RECENZIJE";
            // 
            // btnDodajRecenziju
            // 
            this.btnDodajRecenziju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnDodajRecenziju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajRecenziju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajRecenziju.Location = new System.Drawing.Point(235, 31);
            this.btnDodajRecenziju.Name = "btnDodajRecenziju";
            this.btnDodajRecenziju.Size = new System.Drawing.Size(152, 29);
            this.btnDodajRecenziju.TabIndex = 169;
            this.btnDodajRecenziju.Text = "Dodaj recenziju";
            this.btnDodajRecenziju.UseVisualStyleBackColor = false;
            this.btnDodajRecenziju.Click += new System.EventHandler(this.btnDodajRecenziju_Click);
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.lblTrenutniStudent);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblStudent);
            this.gbInstruktor.Location = new System.Drawing.Point(173, 0);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(1210, 49);
            this.gbInstruktor.TabIndex = 171;
            this.gbInstruktor.TabStop = false;
            // 
            // lblTrenutniStudent
            // 
            this.lblTrenutniStudent.AutoSize = true;
            this.lblTrenutniStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutniStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblTrenutniStudent.Location = new System.Drawing.Point(138, 17);
            this.lblTrenutniStudent.Name = "lblTrenutniStudent";
            this.lblTrenutniStudent.Size = new System.Drawing.Size(64, 16);
            this.lblTrenutniStudent.TabIndex = 23;
            this.lblTrenutniStudent.Text = "Student:";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(828, 13);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 25);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblStudent.Location = new System.Drawing.Point(58, 17);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(64, 16);
            this.lblStudent.TabIndex = 3;
            this.lblStudent.Text = "Student:";
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Location = new System.Drawing.Point(-8, 41);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
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
            this.gbRecenzija.Location = new System.Drawing.Point(245, 82);
            this.gbRecenzija.Margin = new System.Windows.Forms.Padding(2);
            this.gbRecenzija.Name = "gbRecenzija";
            this.gbRecenzija.Padding = new System.Windows.Forms.Padding(2);
            this.gbRecenzija.Size = new System.Drawing.Size(406, 393);
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
            this.comboOcjena.Location = new System.Drawing.Point(80, 63);
            this.comboOcjena.Margin = new System.Windows.Forms.Padding(2);
            this.comboOcjena.Name = "comboOcjena";
            this.comboOcjena.Size = new System.Drawing.Size(107, 21);
            this.comboOcjena.TabIndex = 5;
            // 
            // comboInstruktor
            // 
            this.comboInstruktor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboInstruktor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboInstruktor.FormattingEnabled = true;
            this.comboInstruktor.Location = new System.Drawing.Point(80, 31);
            this.comboInstruktor.Margin = new System.Windows.Forms.Padding(2);
            this.comboInstruktor.Name = "comboInstruktor";
            this.comboInstruktor.Size = new System.Drawing.Size(107, 21);
            this.comboInstruktor.TabIndex = 4;
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(15, 125);
            this.rtbKomentar.Margin = new System.Windows.Forms.Padding(2);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(373, 253);
            this.rtbKomentar.TabIndex = 3;
            this.rtbKomentar.Text = "";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomentar.Location = new System.Drawing.Point(12, 98);
            this.lblKomentar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(73, 17);
            this.lblKomentar.TabIndex = 2;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblOcjena
            // 
            this.lblOcjena.AutoSize = true;
            this.lblOcjena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOcjena.Location = new System.Drawing.Point(12, 63);
            this.lblOcjena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcjena.Name = "lblOcjena";
            this.lblOcjena.Size = new System.Drawing.Size(57, 17);
            this.lblOcjena.TabIndex = 1;
            this.lblOcjena.Text = "Ocjena:";
            // 
            // lblInstruktor2
            // 
            this.lblInstruktor2.AutoSize = true;
            this.lblInstruktor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruktor2.Location = new System.Drawing.Point(12, 31);
            this.lblInstruktor2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstruktor2.Name = "lblInstruktor2";
            this.lblInstruktor2.Size = new System.Drawing.Size(71, 17);
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
            this.dgvMojeRecenzije.Location = new System.Drawing.Point(672, 113);
            this.dgvMojeRecenzije.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMojeRecenzije.Name = "dgvMojeRecenzije";
            this.dgvMojeRecenzije.RowHeadersWidth = 51;
            this.dgvMojeRecenzije.RowTemplate.Height = 24;
            this.dgvMojeRecenzije.Size = new System.Drawing.Size(401, 280);
            this.dgvMojeRecenzije.TabIndex = 174;
            // 
            // instruktoriDataGridViewTextBoxColumn
            // 
            this.instruktoriDataGridViewTextBoxColumn.DataPropertyName = "Instruktori";
            this.instruktoriDataGridViewTextBoxColumn.HeaderText = "Instruktor";
            this.instruktoriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.instruktoriDataGridViewTextBoxColumn.Name = "instruktoriDataGridViewTextBoxColumn";
            this.instruktoriDataGridViewTextBoxColumn.Width = 76;
            // 
            // ocjenaDataGridViewTextBoxColumn
            // 
            this.ocjenaDataGridViewTextBoxColumn.DataPropertyName = "ocjena";
            this.ocjenaDataGridViewTextBoxColumn.HeaderText = "Ocjena";
            this.ocjenaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ocjenaDataGridViewTextBoxColumn.Name = "ocjenaDataGridViewTextBoxColumn";
            this.ocjenaDataGridViewTextBoxColumn.Width = 66;
            // 
            // komentarDataGridViewTextBoxColumn
            // 
            this.komentarDataGridViewTextBoxColumn.DataPropertyName = "komentar";
            this.komentarDataGridViewTextBoxColumn.HeaderText = "Komentar";
            this.komentarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.komentarDataGridViewTextBoxColumn.Name = "komentarDataGridViewTextBoxColumn";
            this.komentarDataGridViewTextBoxColumn.Width = 77;
            // 
            // recenzijeBindingSource
            // 
            this.recenzijeBindingSource.DataSource = typeof(FindAndLearn.Recenzije);
            // 
            // btnObrisiRecenziju
            // 
            this.btnObrisiRecenziju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnObrisiRecenziju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiRecenziju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiRecenziju.Location = new System.Drawing.Point(808, 416);
            this.btnObrisiRecenziju.Name = "btnObrisiRecenziju";
            this.btnObrisiRecenziju.Size = new System.Drawing.Size(152, 29);
            this.btnObrisiRecenziju.TabIndex = 170;
            this.btnObrisiRecenziju.Text = "Obriši recenziju";
            this.btnObrisiRecenziju.UseVisualStyleBackColor = false;
            this.btnObrisiRecenziju.Click += new System.EventHandler(this.btnObrisiRecenziju_Click);
            // 
            // lblMojeRecenzije
            // 
            this.lblMojeRecenzije.AutoSize = true;
            this.lblMojeRecenzije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMojeRecenzije.Location = new System.Drawing.Point(669, 89);
            this.lblMojeRecenzije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMojeRecenzije.Name = "lblMojeRecenzije";
            this.lblMojeRecenzije.Size = new System.Drawing.Size(118, 17);
            this.lblMojeRecenzije.TabIndex = 170;
            this.lblMojeRecenzije.Text = "Moje recenzije:";
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataSource = typeof(FindAndLearn.Rezervacije);
            // 
            // frmDodajRecenziju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 500);
            this.Controls.Add(this.lblMojeRecenzije);
            this.Controls.Add(this.btnObrisiRecenziju);
            this.Controls.Add(this.dgvMojeRecenzije);
            this.Controls.Add(this.gbRecenzija);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbInstruktor);
            this.Controls.Add(this.gbIzbornik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmDodajRecenziju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recenzije";
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
        private System.Windows.Forms.Label lblRecenzije;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private System.Windows.Forms.Button btnDodajRecenziju;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblStudent;
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
        private System.Windows.Forms.Label lblTrenutniStudent;
    }
}