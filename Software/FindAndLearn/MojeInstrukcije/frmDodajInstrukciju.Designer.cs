
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblInstrukcije = new System.Windows.Forms.Label();
            this.gbProfil = new System.Windows.Forms.GroupBox();
            this.lblInstruktor = new System.Windows.Forms.Label();
            this.gbIzbornik = new System.Windows.Forms.GroupBox();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.gbInstruktor = new System.Windows.Forms.GroupBox();
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
            this.gbDodajInstrukciju = new System.Windows.Forms.GroupBox();
            this.lblTrenutniInstruktor = new System.Windows.Forms.Label();
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
            this.gbDodajInstrukciju.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // lblInstrukcije
            // 
            this.lblInstrukcije.AutoSize = true;
            this.lblInstrukcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstrukcije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstrukcije.Location = new System.Drawing.Point(103, 34);
            this.lblInstrukcije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstrukcije.Name = "lblInstrukcije";
            this.lblInstrukcije.Size = new System.Drawing.Size(143, 25);
            this.lblInstrukcije.TabIndex = 68;
            this.lblInstrukcije.Text = "INSTRUKCIJE";
            // 
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbProfil.Controls.Add(this.pbLogo);
            this.gbProfil.Controls.Add(this.lblInstrukcije);
            this.gbProfil.Location = new System.Drawing.Point(-3, -4);
            this.gbProfil.Margin = new System.Windows.Forms.Padding(4);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Padding = new System.Windows.Forms.Padding(4);
            this.gbProfil.Size = new System.Drawing.Size(281, 92);
            this.gbProfil.TabIndex = 108;
            this.gbProfil.TabStop = false;
            // 
            // lblInstruktor
            // 
            this.lblInstruktor.AutoSize = true;
            this.lblInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblInstruktor.Location = new System.Drawing.Point(77, 21);
            this.lblInstruktor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruktor.Name = "lblInstruktor";
            this.lblInstruktor.Size = new System.Drawing.Size(101, 20);
            this.lblInstruktor.TabIndex = 3;
            this.lblInstruktor.Text = "Instruktor: ";
            // 
            // gbIzbornik
            // 
            this.gbIzbornik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(50)))));
            this.gbIzbornik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbIzbornik.Controls.Add(this.btnZatvori);
            this.gbIzbornik.Location = new System.Drawing.Point(-11, 49);
            this.gbIzbornik.Margin = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Name = "gbIzbornik";
            this.gbIzbornik.Padding = new System.Windows.Forms.Padding(4);
            this.gbIzbornik.Size = new System.Drawing.Size(289, 809);
            this.gbIzbornik.TabIndex = 106;
            this.gbIzbornik.TabStop = false;
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZatvori.Location = new System.Drawing.Point(24, 507);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4);
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
            this.gbInstruktor.Controls.Add(this.lblTrenutniInstruktor);
            this.gbInstruktor.Controls.Add(this.btnHelp);
            this.gbInstruktor.Controls.Add(this.lblInstruktor);
            this.gbInstruktor.Location = new System.Drawing.Point(231, -2);
            this.gbInstruktor.Margin = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Name = "gbInstruktor";
            this.gbInstruktor.Padding = new System.Windows.Forms.Padding(4);
            this.gbInstruktor.Size = new System.Drawing.Size(1613, 60);
            this.gbInstruktor.TabIndex = 107;
            this.gbInstruktor.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.Location = new System.Drawing.Point(1465, 17);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblTipInstrukcija.Location = new System.Drawing.Point(11, 38);
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
            this.lblVrstaKolegija.Location = new System.Drawing.Point(11, 86);
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
            this.lblOpisInstrukcije.Location = new System.Drawing.Point(11, 143);
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
            this.lblCijenaInstrukcije.Location = new System.Drawing.Point(11, 485);
            this.lblCijenaInstrukcije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCijenaInstrukcije.Name = "lblCijenaInstrukcije";
            this.lblCijenaInstrukcije.Size = new System.Drawing.Size(161, 20);
            this.lblCijenaInstrukcije.TabIndex = 111;
            this.lblCijenaInstrukcije.Text = "Cijena instrukcije:";
            // 
            // comboTipInstrukcija
            // 
            this.comboTipInstrukcija.FormattingEnabled = true;
            this.comboTipInstrukcija.Location = new System.Drawing.Point(172, 38);
            this.comboTipInstrukcija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTipInstrukcija.Name = "comboTipInstrukcija";
            this.comboTipInstrukcija.Size = new System.Drawing.Size(221, 26);
            this.comboTipInstrukcija.TabIndex = 112;
            // 
            // comboVrstaKolegija
            // 
            this.comboVrstaKolegija.FormattingEnabled = true;
            this.comboVrstaKolegija.Location = new System.Drawing.Point(172, 80);
            this.comboVrstaKolegija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboVrstaKolegija.Name = "comboVrstaKolegija";
            this.comboVrstaKolegija.Size = new System.Drawing.Size(221, 26);
            this.comboVrstaKolegija.TabIndex = 113;
            // 
            // txtOpisInstrukcije
            // 
            this.txtOpisInstrukcije.Location = new System.Drawing.Point(15, 184);
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
            this.btnDodajInstrukciju.Location = new System.Drawing.Point(380, 480);
            this.btnDodajInstrukciju.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajInstrukciju.Name = "btnDodajInstrukciju";
            this.btnDodajInstrukciju.Size = new System.Drawing.Size(203, 31);
            this.btnDodajInstrukciju.TabIndex = 30;
            this.btnDodajInstrukciju.Text = "Dodaj instrukciju";
            this.btnDodajInstrukciju.UseVisualStyleBackColor = false;
            this.btnDodajInstrukciju.Click += new System.EventHandler(this.btnDodajInstrukciju_Click);
            // 
            // dgvMojeInstrukcije
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.dgvMojeInstrukcije.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMojeInstrukcije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMojeInstrukcije.AutoGenerateColumns = false;
            this.dgvMojeInstrukcije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMojeInstrukcije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMojeInstrukcije.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMojeInstrukcije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMojeInstrukcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMojeInstrukcije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipinstrukcijaDataGridViewTextBoxColumn,
            this.kolegijiDataGridViewTextBoxColumn,
            this.opisinstrukcijeDataGridViewTextBoxColumn,
            this.cijenainstrukcijeDataGridViewTextBoxColumn});
            this.dgvMojeInstrukcije.DataSource = this.instrukcijeBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMojeInstrukcije.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMojeInstrukcije.Location = new System.Drawing.Point(992, 110);
            this.dgvMojeInstrukcije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMojeInstrukcije.Name = "dgvMojeInstrukcije";
            this.dgvMojeInstrukcije.RowHeadersWidth = 51;
            this.dgvMojeInstrukcije.RowTemplate.Height = 24;
            this.dgvMojeInstrukcije.Size = new System.Drawing.Size(779, 292);
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
            this.btnTermin.Location = new System.Drawing.Point(1614, 433);
            this.btnTermin.Margin = new System.Windows.Forms.Padding(4);
            this.btnTermin.Name = "btnTermin";
            this.btnTermin.Size = new System.Drawing.Size(157, 31);
            this.btnTermin.TabIndex = 119;
            this.btnTermin.Text = "Termini";
            this.btnTermin.UseVisualStyleBackColor = false;
            this.btnTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // textCijenaInstrukcije
            // 
            this.textCijenaInstrukcije.Location = new System.Drawing.Point(199, 485);
            this.textCijenaInstrukcije.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCijenaInstrukcije.Name = "textCijenaInstrukcije";
            this.textCijenaInstrukcije.Size = new System.Drawing.Size(88, 24);
            this.textCijenaInstrukcije.TabIndex = 120;
            // 
            // btnObrisiInstrukciju
            // 
            this.btnObrisiInstrukciju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.btnObrisiInstrukciju.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObrisiInstrukciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiInstrukciju.Location = new System.Drawing.Point(992, 433);
            this.btnObrisiInstrukciju.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblKn.Location = new System.Drawing.Point(292, 488);
            this.lblKn.Name = "lblKn";
            this.lblKn.Size = new System.Drawing.Size(26, 18);
            this.lblKn.TabIndex = 122;
            this.lblKn.Text = "Kn";
            // 
            // gbDodajInstrukciju
            // 
            this.gbDodajInstrukciju.Controls.Add(this.txtOpisInstrukcije);
            this.gbDodajInstrukciju.Controls.Add(this.lblKn);
            this.gbDodajInstrukciju.Controls.Add(this.lblTipInstrukcija);
            this.gbDodajInstrukciju.Controls.Add(this.lblVrstaKolegija);
            this.gbDodajInstrukciju.Controls.Add(this.textCijenaInstrukcije);
            this.gbDodajInstrukciju.Controls.Add(this.lblOpisInstrukcije);
            this.gbDodajInstrukciju.Controls.Add(this.lblCijenaInstrukcije);
            this.gbDodajInstrukciju.Controls.Add(this.comboTipInstrukcija);
            this.gbDodajInstrukciju.Controls.Add(this.comboVrstaKolegija);
            this.gbDodajInstrukciju.Controls.Add(this.btnDodajInstrukciju);
            this.gbDodajInstrukciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDodajInstrukciju.Location = new System.Drawing.Point(312, 76);
            this.gbDodajInstrukciju.Name = "gbDodajInstrukciju";
            this.gbDodajInstrukciju.Size = new System.Drawing.Size(622, 519);
            this.gbDodajInstrukciju.TabIndex = 123;
            this.gbDodajInstrukciju.TabStop = false;
            this.gbDodajInstrukciju.Text = "Dodaj instrukciju";
            // 
            // lblTrenutniInstruktor
            // 
            this.lblTrenutniInstruktor.AutoSize = true;
            this.lblTrenutniInstruktor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutniInstruktor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(210)))), ((int)(((byte)(135)))));
            this.lblTrenutniInstruktor.Location = new System.Drawing.Point(186, 21);
            this.lblTrenutniInstruktor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrenutniInstruktor.Name = "lblTrenutniInstruktor";
            this.lblTrenutniInstruktor.Size = new System.Drawing.Size(101, 20);
            this.lblTrenutniInstruktor.TabIndex = 23;
            this.lblTrenutniInstruktor.Text = "Instruktor: ";
            // 
            // tipinstrukcijaDataGridViewTextBoxColumn
            // 
            this.tipinstrukcijaDataGridViewTextBoxColumn.DataPropertyName = "Tip_instrukcija";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipinstrukcijaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tipinstrukcijaDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipinstrukcijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipinstrukcijaDataGridViewTextBoxColumn.Name = "tipinstrukcijaDataGridViewTextBoxColumn";
            this.tipinstrukcijaDataGridViewTextBoxColumn.Width = 57;
            // 
            // kolegijiDataGridViewTextBoxColumn
            // 
            this.kolegijiDataGridViewTextBoxColumn.DataPropertyName = "Kolegiji";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolegijiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.kolegijiDataGridViewTextBoxColumn.HeaderText = "Kolegij";
            this.kolegijiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolegijiDataGridViewTextBoxColumn.Name = "kolegijiDataGridViewTextBoxColumn";
            this.kolegijiDataGridViewTextBoxColumn.Width = 79;
            // 
            // opisinstrukcijeDataGridViewTextBoxColumn
            // 
            this.opisinstrukcijeDataGridViewTextBoxColumn.DataPropertyName = "opis_instrukcije";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opisinstrukcijeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.opisinstrukcijeDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisinstrukcijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisinstrukcijeDataGridViewTextBoxColumn.Name = "opisinstrukcijeDataGridViewTextBoxColumn";
            this.opisinstrukcijeDataGridViewTextBoxColumn.Width = 66;
            // 
            // cijenainstrukcijeDataGridViewTextBoxColumn
            // 
            this.cijenainstrukcijeDataGridViewTextBoxColumn.DataPropertyName = "cijena_instrukcije";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cijenainstrukcijeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.cijenainstrukcijeDataGridViewTextBoxColumn.HeaderText = "Cijena (HRK)";
            this.cijenainstrukcijeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenainstrukcijeDataGridViewTextBoxColumn.Name = "cijenainstrukcijeDataGridViewTextBoxColumn";
            this.cijenainstrukcijeDataGridViewTextBoxColumn.Width = 119;
            // 
            // instrukcijeBindingSource
            // 
            this.instrukcijeBindingSource.DataSource = typeof(FindAndLearn.Instrukcije);
            // 
            // frmDodajInstrukciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1837, 612);
            this.Controls.Add(this.gbDodajInstrukciju);
            this.Controls.Add(this.btnObrisiInstrukciju);
            this.Controls.Add(this.btnTermin);
            this.Controls.Add(this.lblMojeInstrukcije);
            this.Controls.Add(this.dgvMojeInstrukcije);
            this.Controls.Add(this.gbProfil);
            this.Controls.Add(this.gbIzbornik);
            this.Controls.Add(this.gbInstruktor);
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
            this.gbDodajInstrukciju.ResumeLayout(false);
            this.gbDodajInstrukciju.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instrukcijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblInstrukcije;
        private System.Windows.Forms.GroupBox gbProfil;
        private System.Windows.Forms.Label lblInstruktor;
        private System.Windows.Forms.GroupBox gbIzbornik;
        private System.Windows.Forms.GroupBox gbInstruktor;
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
        private System.Windows.Forms.Button btnObrisiInstrukciju;
        private System.Windows.Forms.Label lblKn;
        private System.Windows.Forms.GroupBox gbDodajInstrukciju;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipinstrukcijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolegijiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisinstrukcijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenainstrukcijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTrenutniInstruktor;
    }
}