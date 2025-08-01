namespace Klijent
{
    partial class EvidencijaTretmanaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EvidencijaTretmanaFrm));
            EvidencijaTretmanaDgv = new DataGridView();
            DeteCmb = new ComboBox();
            DefektologCmb = new ComboBox();
            UslugaCmb = new ComboBox();
            panel1 = new Panel();
            DeteLbl = new Label();
            DefektologLbl = new Label();
            UslugaLbl = new Label();
            UkupnaCenaLbl = new Label();
            OperacijaBtn = new Button();
            UkupnaCenaTxt = new TextBox();
            OperacijaLbl = new Label();
            OpisLbl = new Label();
            DatumDefaultCb = new CheckBox();
            PlacenaCmb = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            StorniranCmb = new ComboBox();
            label3 = new Label();
            VremePocetkaTxt = new TextBox();
            label2 = new Label();
            DatumPicker = new DateTimePicker();
            label1 = new Label();
            EvidencijaBtn = new RadioButton();
            DeteBtn = new RadioButton();
            DefektologBtn = new RadioButton();
            UslugaBtn = new RadioButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PromeniBtn = new Button();
            PretragaBtn = new Button();
            KreirajBtn = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)EvidencijaTretmanaDgv).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EvidencijaTretmanaDgv
            // 
            EvidencijaTretmanaDgv.AllowUserToAddRows = false;
            EvidencijaTretmanaDgv.AllowUserToDeleteRows = false;
            EvidencijaTretmanaDgv.BackgroundColor = Color.FromArgb(235, 235, 235);
            EvidencijaTretmanaDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EvidencijaTretmanaDgv.Dock = DockStyle.Fill;
            EvidencijaTretmanaDgv.Location = new Point(0, 0);
            EvidencijaTretmanaDgv.Name = "EvidencijaTretmanaDgv";
            EvidencijaTretmanaDgv.ReadOnly = true;
            EvidencijaTretmanaDgv.RowTemplate.Height = 25;
            EvidencijaTretmanaDgv.Size = new Size(1075, 670);
            EvidencijaTretmanaDgv.TabIndex = 0;
            EvidencijaTretmanaDgv.CellClick += EvidencijaTretmanaDgv_CellClick;
            EvidencijaTretmanaDgv.CellContentClick += EvidencijaTretmanaDgv_CellContentClick;
            // 
            // DeteCmb
            // 
            DeteCmb.BackColor = Color.FromArgb(211, 194, 214);
            DeteCmb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DeteCmb.FormattingEnabled = true;
            DeteCmb.Location = new Point(391, 251);
            DeteCmb.Name = "DeteCmb";
            DeteCmb.Size = new Size(121, 40);
            DeteCmb.TabIndex = 1;
            DeteCmb.SelectedIndexChanged += DeteCmb_SelectedIndexChanged;
            // 
            // DefektologCmb
            // 
            DefektologCmb.BackColor = Color.FromArgb(211, 194, 214);
            DefektologCmb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DefektologCmb.FormattingEnabled = true;
            DefektologCmb.Location = new Point(391, 345);
            DefektologCmb.Name = "DefektologCmb";
            DefektologCmb.Size = new Size(121, 40);
            DefektologCmb.TabIndex = 2;
            DefektologCmb.SelectedIndexChanged += DefektologCmb_SelectedIndexChanged;
            // 
            // UslugaCmb
            // 
            UslugaCmb.BackColor = Color.FromArgb(211, 194, 214);
            UslugaCmb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            UslugaCmb.FormattingEnabled = true;
            UslugaCmb.Location = new Point(391, 452);
            UslugaCmb.Name = "UslugaCmb";
            UslugaCmb.Size = new Size(121, 40);
            UslugaCmb.TabIndex = 3;
            UslugaCmb.SelectedIndexChanged += UslugaCmb_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 204, 67);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(DeteLbl);
            panel1.Controls.Add(DefektologLbl);
            panel1.Controls.Add(UslugaLbl);
            panel1.Controls.Add(UkupnaCenaLbl);
            panel1.Controls.Add(OperacijaBtn);
            panel1.Controls.Add(UkupnaCenaTxt);
            panel1.Controls.Add(OperacijaLbl);
            panel1.Controls.Add(OpisLbl);
            panel1.Controls.Add(DatumDefaultCb);
            panel1.Controls.Add(PlacenaCmb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(StorniranCmb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(VremePocetkaTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DatumPicker);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EvidencijaBtn);
            panel1.Controls.Add(DeteBtn);
            panel1.Controls.Add(DefektologBtn);
            panel1.Controls.Add(UslugaBtn);
            panel1.Controls.Add(UslugaCmb);
            panel1.Controls.Add(DeteCmb);
            panel1.Controls.Add(DefektologCmb);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(485, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 670);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // DeteLbl
            // 
            DeteLbl.AutoSize = true;
            DeteLbl.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeteLbl.Location = new Point(395, 215);
            DeteLbl.Name = "DeteLbl";
            DeteLbl.Size = new Size(37, 19);
            DeteLbl.TabIndex = 25;
            DeteLbl.Text = "Dete";
            // 
            // DefektologLbl
            // 
            DefektologLbl.AutoSize = true;
            DefektologLbl.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DefektologLbl.Location = new Point(395, 308);
            DefektologLbl.Name = "DefektologLbl";
            DefektologLbl.Size = new Size(78, 19);
            DefektologLbl.TabIndex = 24;
            DefektologLbl.Text = "Defektolog";
            DefektologLbl.Click += DefektologLbl_Click;
            // 
            // UslugaLbl
            // 
            UslugaLbl.AutoSize = true;
            UslugaLbl.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UslugaLbl.Location = new Point(395, 414);
            UslugaLbl.Name = "UslugaLbl";
            UslugaLbl.Size = new Size(53, 19);
            UslugaLbl.TabIndex = 23;
            UslugaLbl.Text = "Usluga";
            UslugaLbl.Click += UslugaLbl_Click;
            // 
            // UkupnaCenaLbl
            // 
            UkupnaCenaLbl.AutoSize = true;
            UkupnaCenaLbl.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UkupnaCenaLbl.Location = new Point(67, 485);
            UkupnaCenaLbl.Name = "UkupnaCenaLbl";
            UkupnaCenaLbl.Size = new Size(93, 19);
            UkupnaCenaLbl.TabIndex = 22;
            UkupnaCenaLbl.Text = "Ukupna Cena";
            // 
            // OperacijaBtn
            // 
            OperacijaBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OperacijaBtn.BackColor = Color.FromArgb(211, 194, 214);
            OperacijaBtn.FlatStyle = FlatStyle.Flat;
            OperacijaBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OperacijaBtn.Location = new Point(203, 581);
            OperacijaBtn.Name = "OperacijaBtn";
            OperacijaBtn.Size = new Size(174, 28);
            OperacijaBtn.TabIndex = 20;
            OperacijaBtn.Text = "PRETRAGA";
            OperacijaBtn.UseVisualStyleBackColor = false;
            OperacijaBtn.Click += OperacijaBtn_Click;
            // 
            // UkupnaCenaTxt
            // 
            UkupnaCenaTxt.BackColor = Color.FromArgb(211, 194, 214);
            UkupnaCenaTxt.Location = new Point(67, 507);
            UkupnaCenaTxt.Name = "UkupnaCenaTxt";
            UkupnaCenaTxt.Size = new Size(100, 23);
            UkupnaCenaTxt.TabIndex = 21;
            UkupnaCenaTxt.TextChanged += UkupnaCenaTxt_TextChanged;
            // 
            // OperacijaLbl
            // 
            OperacijaLbl.AutoSize = true;
            OperacijaLbl.Font = new Font("Roboto Cn", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OperacijaLbl.Location = new Point(220, 30);
            OperacijaLbl.Name = "OperacijaLbl";
            OperacijaLbl.Size = new Size(157, 38);
            OperacijaLbl.TabIndex = 19;
            OperacijaLbl.Text = "PRETRAGA";
            // 
            // OpisLbl
            // 
            OpisLbl.AutoSize = true;
            OpisLbl.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OpisLbl.Location = new Point(70, 112);
            OpisLbl.Name = "OpisLbl";
            OpisLbl.Size = new Size(188, 19);
            OpisLbl.TabIndex = 18;
            OpisLbl.Text = "PRETAŽI PO KRITERIJUMU:";
            // 
            // DatumDefaultCb
            // 
            DatumDefaultCb.AutoSize = true;
            DatumDefaultCb.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DatumDefaultCb.Location = new Point(73, 266);
            DatumDefaultCb.Name = "DatumDefaultCb";
            DatumDefaultCb.Size = new Size(97, 23);
            DatumDefaultCb.TabIndex = 17;
            DatumDefaultCb.Text = "Svi Datumi";
            DatumDefaultCb.UseVisualStyleBackColor = true;
            // 
            // PlacenaCmb
            // 
            PlacenaCmb.BackColor = Color.FromArgb(211, 194, 214);
            PlacenaCmb.FormattingEnabled = true;
            PlacenaCmb.Items.AddRange(new object[] { "DA", "NE", "--" });
            PlacenaCmb.Location = new Point(155, 436);
            PlacenaCmb.Name = "PlacenaCmb";
            PlacenaCmb.Size = new Size(46, 23);
            PlacenaCmb.TabIndex = 16;
            PlacenaCmb.SelectedIndexChanged += PlacenaCmb_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(155, 414);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 15;
            label5.Text = "Plaćena?";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 414);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 14;
            label4.Text = "Stornirana?";
            label4.Click += label4_Click;
            // 
            // StorniranCmb
            // 
            StorniranCmb.BackColor = Color.FromArgb(211, 194, 214);
            StorniranCmb.FormattingEnabled = true;
            StorniranCmb.Items.AddRange(new object[] { "DA", "NE", "--" });
            StorniranCmb.Location = new Point(67, 436);
            StorniranCmb.Name = "StorniranCmb";
            StorniranCmb.Size = new Size(46, 23);
            StorniranCmb.TabIndex = 13;
            StorniranCmb.SelectedIndexChanged += StorniranCmb_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(173, 359);
            label3.Name = "label3";
            label3.Size = new Size(17, 19);
            label3.TabIndex = 12;
            label3.Text = "h";
            // 
            // VremePocetkaTxt
            // 
            VremePocetkaTxt.BackColor = Color.FromArgb(211, 194, 214);
            VremePocetkaTxt.Location = new Point(67, 359);
            VremePocetkaTxt.Name = "VremePocetkaTxt";
            VremePocetkaTxt.Size = new Size(100, 23);
            VremePocetkaTxt.TabIndex = 11;
            VremePocetkaTxt.TextChanged += VremePocetkaTxt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(67, 318);
            label2.Name = "label2";
            label2.Size = new Size(123, 38);
            label2.TabIndex = 10;
            label2.Text = "Početak Tretmana\r\n[1h-24h]";
            // 
            // DatumPicker
            // 
            DatumPicker.CalendarMonthBackground = Color.White;
            DatumPicker.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DatumPicker.Format = DateTimePickerFormat.Short;
            DatumPicker.Location = new Point(70, 237);
            DatumPicker.Name = "DatumPicker";
            DatumPicker.Size = new Size(100, 27);
            DatumPicker.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 215);
            label1.Name = "label1";
            label1.Size = new Size(50, 19);
            label1.TabIndex = 8;
            label1.Text = "Datum";
            // 
            // EvidencijaBtn
            // 
            EvidencijaBtn.AutoSize = true;
            EvidencijaBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            EvidencijaBtn.Location = new Point(72, 153);
            EvidencijaBtn.Name = "EvidencijaBtn";
            EvidencijaBtn.Size = new Size(108, 23);
            EvidencijaBtn.TabIndex = 7;
            EvidencijaBtn.TabStop = true;
            EvidencijaBtn.Text = "Po evidenciji";
            EvidencijaBtn.UseVisualStyleBackColor = true;
            EvidencijaBtn.CheckedChanged += EvidencijaBtn_CheckedChanged;
            // 
            // DeteBtn
            // 
            DeteBtn.AutoSize = true;
            DeteBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DeteBtn.Location = new Point(408, 153);
            DeteBtn.Name = "DeteBtn";
            DeteBtn.Size = new Size(88, 23);
            DeteBtn.TabIndex = 6;
            DeteBtn.TabStop = true;
            DeteBtn.Text = "Po detetu";
            DeteBtn.UseVisualStyleBackColor = true;
            DeteBtn.CheckedChanged += DeteBtn_CheckedChanged;
            // 
            // DefektologBtn
            // 
            DefektologBtn.AutoSize = true;
            DefektologBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DefektologBtn.Location = new Point(278, 153);
            DefektologBtn.Name = "DefektologBtn";
            DefektologBtn.Size = new Size(124, 23);
            DefektologBtn.TabIndex = 5;
            DefektologBtn.TabStop = true;
            DefektologBtn.Text = "Po defektologu";
            DefektologBtn.UseVisualStyleBackColor = true;
            DefektologBtn.CheckedChanged += DefektologBtn_CheckedChanged;
            // 
            // UslugaBtn
            // 
            UslugaBtn.AutoSize = true;
            UslugaBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UslugaBtn.Location = new Point(186, 153);
            UslugaBtn.Name = "UslugaBtn";
            UslugaBtn.Size = new Size(86, 23);
            UslugaBtn.TabIndex = 4;
            UslugaBtn.TabStop = true;
            UslugaBtn.Text = "Po usluzi";
            UslugaBtn.UseVisualStyleBackColor = true;
            UslugaBtn.CheckedChanged += UslugaBtn_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(211, 194, 214);
            flowLayoutPanel1.Controls.Add(PromeniBtn);
            flowLayoutPanel1.Controls.Add(PretragaBtn);
            flowLayoutPanel1.Controls.Add(KreirajBtn);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 633);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(64, 0, 64, 0);
            flowLayoutPanel1.Size = new Size(485, 37);
            flowLayoutPanel1.TabIndex = 23;
            // 
            // PromeniBtn
            // 
            PromeniBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PromeniBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PromeniBtn.Location = new Point(67, 3);
            PromeniBtn.Name = "PromeniBtn";
            PromeniBtn.Size = new Size(107, 26);
            PromeniBtn.TabIndex = 22;
            PromeniBtn.Text = "Promeni";
            PromeniBtn.UseVisualStyleBackColor = true;
            PromeniBtn.Click += PromeniBtn_Click;
            // 
            // PretragaBtn
            // 
            PretragaBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PretragaBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PretragaBtn.Location = new Point(180, 3);
            PretragaBtn.Name = "PretragaBtn";
            PretragaBtn.Size = new Size(107, 26);
            PretragaBtn.TabIndex = 24;
            PretragaBtn.Text = "Pretraga";
            PretragaBtn.UseVisualStyleBackColor = true;
            PretragaBtn.Click += PretragaBtn_Click;
            // 
            // KreirajBtn
            // 
            KreirajBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KreirajBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KreirajBtn.Location = new Point(293, 3);
            KreirajBtn.Name = "KreirajBtn";
            KreirajBtn.Size = new Size(107, 26);
            KreirajBtn.TabIndex = 21;
            KreirajBtn.Text = "Kreiraj";
            KreirajBtn.UseVisualStyleBackColor = true;
            KreirajBtn.Click += KreirajBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(70, 166);
            label6.Name = "label6";
            label6.Size = new Size(37, 19);
            label6.TabIndex = 26;
            label6.Text = "Id: 0";
            label6.Visible = false;
            // 
            // EvidencijaTretmanaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 670);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(EvidencijaTretmanaDgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EvidencijaTretmanaFrm";
            Text = "Evidencije Tretmana";
            WindowState = FormWindowState.Maximized;
            Load += EvidencijaTretmanaFrm_Load;
            ((System.ComponentModel.ISupportInitialize)EvidencijaTretmanaDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EvidencijaTretmanaDgv;
        private ComboBox DeteCmb;
        private ComboBox DefektologCmb;
        private ComboBox UslugaCmb;
        private Panel panel1;
        private RadioButton UslugaBtn;
        private RadioButton DefektologBtn;
        private RadioButton DeteBtn;
        private RadioButton EvidencijaBtn;
        private DateTimePicker DatumPicker;
        private Label label1;
        private TextBox VremePocetkaTxt;
        private Label label2;
        private ComboBox PlacenaCmb;
        private Label label5;
        private Label label4;
        private ComboBox StorniranCmb;
        private Label label3;
        private CheckBox DatumDefaultCb;
        private Label OperacijaLbl;
        private Label OpisLbl;
        private Button OperacijaBtn;
        private TextBox UkupnaCenaTxt;
        private Label UkupnaCenaLbl;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button KreirajBtn;
        private Button PromeniBtn;
        private Button PretragaBtn;
        private Label UslugaLbl;
        private Label DefektologLbl;
        private Label DeteLbl;
        private Label label6;
    }
}