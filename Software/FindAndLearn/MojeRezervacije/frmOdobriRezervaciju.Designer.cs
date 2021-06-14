
namespace FindAndLearn.MojeRezervacije
{
    partial class frmOdobriRezervaciju
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
            this.lblTrenutniInstruktor = new System.Windows.Forms.Label();
            this.btnOdobriRezervaciju = new System.Windows.Forms.Button();
            this.dgvRezervacije = new System.Windows.Forms.DataGridView();
            this.studentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokrezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potvrdjenaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRezervacijeIns = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.lblRezervacijeZaOdobrenje = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.lblOdobreneRezervacije = new System.Windows.Forms.Label();
            this.dgvOdobreneRezervacije = new System.Windows.Forms.DataGridView();
            this.studentiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokrezervacijeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrezervacijeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potvrdjenaDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbInstruktor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.gbProfil.SuspendLayout();
            this.gbIzbornik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdobreneRezervacije)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(49, 21);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(75, 16);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Instruktor:";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(562, 17);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(90, 25);
            this.btnHelp.TabIndex = 22;
            this.btnHelp.Text = "POMOĆ";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // gbInstruktor
            // 
            this.gbInstruktor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbInstruktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInstruktor.Controls.Add(this.lblTrenutniInstruktor);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(169, -11);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Size = new System.Drawing.Size(1210, 49);
            this.gbInstruktor.TabIndex = 163;
            this.gbInstruktor.TabStop = false;
            // 
            // lblTrenutniInstruktor
            // 
            this.lblTrenutniInstruktor.AutoSize = true;
            this.lblTrenutniInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutniInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblTrenutniInstruktor.Location = new System.Drawing.Point(137, 21);
            this.lblTrenutniInstruktor.Name = "lblTrenutniInstruktor";
            this.lblTrenutniInstruktor.Size = new System.Drawing.Size(75, 16);
            this.lblTrenutniInstruktor.TabIndex = 23;
            this.lblTrenutniInstruktor.Text = "Instruktor:";
            // 
            // btnOdobriRezervaciju
            // 
            this.btnOdobriRezervaciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnOdobriRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOdobriRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdobriRezervaciju.Location = new System.Drawing.Point(459, 323);
            this.btnOdobriRezervaciju.Name = "btnOdobriRezervaciju";
            this.btnOdobriRezervaciju.Size = new System.Drawing.Size(152, 25);
            this.btnOdobriRezervaciju.TabIndex = 160;
            this.btnOdobriRezervaciju.Text = "Odobri rezervaciju";
            this.btnOdobriRezervaciju.UseVisualStyleBackColor = false;
            this.btnOdobriRezervaciju.Click += new System.EventHandler(this.btnOdobriRezervaciju_Click);
            // 
            // dgvRezervacije
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.dgvRezervacije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRezervacije.AutoGenerateColumns = false;
            this.dgvRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRezervacije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRezervacije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRezervacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentiDataGridViewTextBoxColumn,
            this.terminiDataGridViewTextBoxColumn,
            this.rokrezervacijeDataGridViewTextBoxColumn,
            this.datumrezervacijeDataGridViewTextBoxColumn,
            this.potvrdjenaDataGridViewCheckBoxColumn});
            this.dgvRezervacije.DataSource = this.rezervacijeBindingSource;
            this.dgvRezervacije.Location = new System.Drawing.Point(267, 103);
            this.dgvRezervacije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRezervacije.Name = "dgvRezervacije";
            this.dgvRezervacije.RowHeadersWidth = 51;
            this.dgvRezervacije.RowTemplate.Height = 24;
            this.dgvRezervacije.Size = new System.Drawing.Size(500, 189);
            this.dgvRezervacije.TabIndex = 168;
            // 
            // studentiDataGridViewTextBoxColumn
            // 
            this.studentiDataGridViewTextBoxColumn.DataPropertyName = "Studenti";
            this.studentiDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentiDataGridViewTextBoxColumn.Name = "studentiDataGridViewTextBoxColumn";
            this.studentiDataGridViewTextBoxColumn.Width = 69;
            // 
            // terminiDataGridViewTextBoxColumn
            // 
            this.terminiDataGridViewTextBoxColumn.DataPropertyName = "Termini";
            this.terminiDataGridViewTextBoxColumn.HeaderText = "Termin";
            this.terminiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.terminiDataGridViewTextBoxColumn.Name = "terminiDataGridViewTextBoxColumn";
            this.terminiDataGridViewTextBoxColumn.Width = 64;
            // 
            // rokrezervacijeDataGridViewTextBoxColumn
            // 
            this.rokrezervacijeDataGridViewTextBoxColumn.DataPropertyName = "rok_rezervacije";
            this.rokrezervacijeDataGridViewTextBoxColumn.HeaderText = "Rok rezervacije";
            this.rokrezervacijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rokrezervacijeDataGridViewTextBoxColumn.Name = "rokrezervacijeDataGridViewTextBoxColumn";
            this.rokrezervacijeDataGridViewTextBoxColumn.Width = 97;
            // 
            // datumrezervacijeDataGridViewTextBoxColumn
            // 
            this.datumrezervacijeDataGridViewTextBoxColumn.DataPropertyName = "datum_rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn.HeaderText = "Datum rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumrezervacijeDataGridViewTextBoxColumn.Name = "datumrezervacijeDataGridViewTextBoxColumn";
            this.datumrezervacijeDataGridViewTextBoxColumn.Width = 107;
            // 
            // potvrdjenaDataGridViewCheckBoxColumn
            // 
            this.potvrdjenaDataGridViewCheckBoxColumn.DataPropertyName = "potvrdjena";
            this.potvrdjenaDataGridViewCheckBoxColumn.HeaderText = "Potvrđena";
            this.potvrdjenaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.potvrdjenaDataGridViewCheckBoxColumn.Name = "potvrdjenaDataGridViewCheckBoxColumn";
            this.potvrdjenaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.potvrdjenaDataGridViewCheckBoxColumn.Width = 63;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataSource = typeof(FindAndLearn.Rezervacije);
            // 
            // lblRezervacijeIns
            // 
            this.lblRezervacijeIns.AutoSize = true;
            this.lblRezervacijeIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezervacijeIns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblRezervacijeIns.Location = new System.Drawing.Point(85, 43);
            this.lblRezervacijeIns.Name = "lblRezervacijeIns";
            this.lblRezervacijeIns.Size = new System.Drawing.Size(122, 20);
            this.lblRezervacijeIns.TabIndex = 68;
            this.lblRezervacijeIns.Text = "REZERVACIJE";
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::FindAndLearn.Properties.Resources.Logo;
            this.pbLogo.Location = new System.Drawing.Point(6, 23);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(76, 55);
            this.pbLogo.TabIndex = 69;
            this.pbLogo.TabStop = false;
            // 
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.lblRezervacijeIns);
            this.gbProfil.Location = new System.Drawing.Point(-7, -12);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Size = new System.Drawing.Size(211, 100);
            this.gbProfil.TabIndex = 164;
            this.gbProfil.TabStop = false;
            // 
            // lblRezervacijeZaOdobrenje
            // 
            this.lblRezervacijeZaOdobrenje.AutoSize = true;
            this.lblRezervacijeZaOdobrenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRezervacijeZaOdobrenje.Location = new System.Drawing.Point(264, 72);
            this.lblRezervacijeZaOdobrenje.Name = "lblRezervacijeZaOdobrenje";
            this.lblRezervacijeZaOdobrenje.Size = new System.Drawing.Size(198, 17);
            this.lblRezervacijeZaOdobrenje.TabIndex = 165;
            this.lblRezervacijeZaOdobrenje.Text = "Rezervacije za odobrenje:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(18, 553);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(184, 31);
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
            this.gbIzbornik.Location = new System.Drawing.Point(-13, 31);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Size = new System.Drawing.Size(217, 657);
            this.gbIzbornik.TabIndex = 162;
            this.gbIzbornik.TabStop = false;
            // 
            // lblOdobreneRezervacije
            // 
            this.lblOdobreneRezervacije.AutoSize = true;
            this.lblOdobreneRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOdobreneRezervacije.Location = new System.Drawing.Point(264, 356);
            this.lblOdobreneRezervacije.Name = "lblOdobreneRezervacije";
            this.lblOdobreneRezervacije.Size = new System.Drawing.Size(170, 17);
            this.lblOdobreneRezervacije.TabIndex = 169;
            this.lblOdobreneRezervacije.Text = "Odobrene rezervacije:";
            // 
            // dgvOdobreneRezervacije
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.dgvOdobreneRezervacije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOdobreneRezervacije.AutoGenerateColumns = false;
            this.dgvOdobreneRezervacije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOdobreneRezervacije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOdobreneRezervacije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOdobreneRezervacije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOdobreneRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdobreneRezervacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentiDataGridViewTextBoxColumn1,
            this.terminiDataGridViewTextBoxColumn1,
            this.rokrezervacijeDataGridViewTextBoxColumn1,
            this.datumrezervacijeDataGridViewTextBoxColumn1,
            this.potvrdjenaDataGridViewCheckBoxColumn1});
            this.dgvOdobreneRezervacije.DataSource = this.rezervacijeBindingSource;
            this.dgvOdobreneRezervacije.Location = new System.Drawing.Point(267, 382);
            this.dgvOdobreneRezervacije.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOdobreneRezervacije.Name = "dgvOdobreneRezervacije";
            this.dgvOdobreneRezervacije.RowHeadersWidth = 51;
            this.dgvOdobreneRezervacije.RowTemplate.Height = 24;
            this.dgvOdobreneRezervacije.Size = new System.Drawing.Size(500, 233);
            this.dgvOdobreneRezervacije.TabIndex = 170;
            // 
            // studentiDataGridViewTextBoxColumn1
            // 
            this.studentiDataGridViewTextBoxColumn1.DataPropertyName = "Studenti";
            this.studentiDataGridViewTextBoxColumn1.HeaderText = "Student";
            this.studentiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.studentiDataGridViewTextBoxColumn1.Name = "studentiDataGridViewTextBoxColumn1";
            this.studentiDataGridViewTextBoxColumn1.Width = 69;
            // 
            // terminiDataGridViewTextBoxColumn1
            // 
            this.terminiDataGridViewTextBoxColumn1.DataPropertyName = "Termini";
            this.terminiDataGridViewTextBoxColumn1.HeaderText = "Termin";
            this.terminiDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.terminiDataGridViewTextBoxColumn1.Name = "terminiDataGridViewTextBoxColumn1";
            this.terminiDataGridViewTextBoxColumn1.Width = 64;
            // 
            // rokrezervacijeDataGridViewTextBoxColumn1
            // 
            this.rokrezervacijeDataGridViewTextBoxColumn1.DataPropertyName = "rok_rezervacije";
            this.rokrezervacijeDataGridViewTextBoxColumn1.HeaderText = "Rok rezervacije";
            this.rokrezervacijeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.rokrezervacijeDataGridViewTextBoxColumn1.Name = "rokrezervacijeDataGridViewTextBoxColumn1";
            this.rokrezervacijeDataGridViewTextBoxColumn1.Width = 97;
            // 
            // datumrezervacijeDataGridViewTextBoxColumn1
            // 
            this.datumrezervacijeDataGridViewTextBoxColumn1.DataPropertyName = "datum_rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn1.HeaderText = "Datum rezervacije";
            this.datumrezervacijeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.datumrezervacijeDataGridViewTextBoxColumn1.Name = "datumrezervacijeDataGridViewTextBoxColumn1";
            this.datumrezervacijeDataGridViewTextBoxColumn1.Width = 107;
            // 
            // potvrdjenaDataGridViewCheckBoxColumn1
            // 
            this.potvrdjenaDataGridViewCheckBoxColumn1.DataPropertyName = "potvrdjena";
            this.potvrdjenaDataGridViewCheckBoxColumn1.HeaderText = "Potvrđena";
            this.potvrdjenaDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.potvrdjenaDataGridViewCheckBoxColumn1.Name = "potvrdjenaDataGridViewCheckBoxColumn1";
            this.potvrdjenaDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.potvrdjenaDataGridViewCheckBoxColumn1.Width = 63;
            // 
            // frmOdobriRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 644);
            this.Controls.Add(this.dgvOdobreneRezervacije);
            this.Controls.Add(this.lblOdobreneRezervacije);
            this.Controls.Add(this.dgvRezervacije);
            this.Controls.Add(this.lblRezervacijeZaOdobrenje);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.btnOdobriRezervaciju);
            this.Controls.Add(this.gbInstruktor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmOdobriRezervaciju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Odobri rezervacije";
            this.Load += new System.EventHandler(this.frmOdobriRezervaciju_Load);
            this.gbInstruktor.ResumeLayout(false);
            this.gbInstruktor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            this.gbIzbornik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdobreneRezervacije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.GroupBox gbInstruktor;
        private System.Windows.Forms.Button btnOdobriRezervaciju;
        private System.Windows.Forms.DataGridView dgvRezervacije;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private System.Windows.Forms.Label lblRezervacijeIns;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.Label lblRezervacijeZaOdobrenje;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.Label lblOdobreneRezervacije;
        private System.Windows.Forms.DataGridView dgvOdobreneRezervacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokrezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn potvrdjenaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rokrezervacijeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrezervacijeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn potvrdjenaDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label lblTrenutniInstruktor;
    }
}