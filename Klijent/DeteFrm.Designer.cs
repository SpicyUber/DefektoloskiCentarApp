namespace Klijent
{
    partial class DeteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeteFrm));
            DecaDgv = new DataGridView();
            DecaKriterijumBtn = new RadioButton();
            KriterijumStarateljBtn = new RadioButton();
            ImeTxt = new TextBox();
            PrezimeTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            OperacijaBtn = new Button();
            StarateljCmb = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            KreirajBtn = new Button();
            ObrisiBtn = new Button();
            PromeniBtn = new Button();
            PretragaBtn = new Button();
            PretragaPnl = new Panel();
            HelpBtn = new Button();
            PromeniPnl = new Panel();
            PromeniIdLbl = new Label();
            PotvrdiPromeneBtn = new Button();
            PromeniStarateljCmb = new ComboBox();
            PromeniPrezimeTxt = new TextBox();
            PromeniImeTxt = new TextBox();
            label4 = new Label();
            OperacijaLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)DecaDgv).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            PretragaPnl.SuspendLayout();
            PromeniPnl.SuspendLayout();
            SuspendLayout();
            // 
            // DecaDgv
            // 
            DecaDgv.AllowUserToAddRows = false;
            DecaDgv.AllowUserToDeleteRows = false;
            DecaDgv.BackgroundColor = Color.FromArgb(235, 235, 235);
            DecaDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DecaDgv.Dock = DockStyle.Fill;
            DecaDgv.GridColor = Color.FromArgb(235, 235, 235);
            DecaDgv.Location = new Point(0, 0);
            DecaDgv.MultiSelect = false;
            DecaDgv.Name = "DecaDgv";
            DecaDgv.ReadOnly = true;
            DecaDgv.RowTemplate.Height = 25;
            DecaDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DecaDgv.Size = new Size(499, 728);
            DecaDgv.TabIndex = 0;
            DecaDgv.CellClick += DecaDgv_CellClick_1;
            DecaDgv.CellContentClick += DecaDgv_CellContentClick_2;
            // 
            // DecaKriterijumBtn
            // 
            DecaKriterijumBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DecaKriterijumBtn.AutoSize = true;
            DecaKriterijumBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DecaKriterijumBtn.Location = new Point(51, 90);
            DecaKriterijumBtn.Name = "DecaKriterijumBtn";
            DecaKriterijumBtn.Size = new Size(209, 23);
            DecaKriterijumBtn.TabIndex = 1;
            DecaKriterijumBtn.TabStop = true;
            DecaKriterijumBtn.Text = "Na osnovu imena, prezimena";
            DecaKriterijumBtn.UseVisualStyleBackColor = true;
            DecaKriterijumBtn.CheckedChanged += DecaKriterijumBtn_CheckedChanged;
            // 
            // KriterijumStarateljBtn
            // 
            KriterijumStarateljBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KriterijumStarateljBtn.AutoSize = true;
            KriterijumStarateljBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KriterijumStarateljBtn.Location = new Point(266, 90);
            KriterijumStarateljBtn.Name = "KriterijumStarateljBtn";
            KriterijumStarateljBtn.Size = new Size(156, 23);
            KriterijumStarateljBtn.TabIndex = 2;
            KriterijumStarateljBtn.TabStop = true;
            KriterijumStarateljBtn.Text = "Na osnovu staratelja";
            KriterijumStarateljBtn.UseVisualStyleBackColor = true;
            KriterijumStarateljBtn.CheckedChanged += KriterijumStarateljBtn_CheckedChanged;
            // 
            // ImeTxt
            // 
            ImeTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ImeTxt.BackColor = Color.FromArgb(211, 194, 214);
            ImeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ImeTxt.Location = new Point(51, 155);
            ImeTxt.Name = "ImeTxt";
            ImeTxt.Size = new Size(155, 29);
            ImeTxt.TabIndex = 3;
            // 
            // PrezimeTxt
            // 
            PrezimeTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PrezimeTxt.BackColor = Color.FromArgb(211, 194, 214);
            PrezimeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PrezimeTxt.Location = new Point(51, 216);
            PrezimeTxt.Name = "PrezimeTxt";
            PrezimeTxt.Size = new Size(155, 29);
            PrezimeTxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 132);
            label1.Name = "label1";
            label1.Size = new Size(32, 19);
            label1.TabIndex = 5;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 198);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 6;
            label2.Text = "Prezime";
            // 
            // OperacijaBtn
            // 
            OperacijaBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OperacijaBtn.BackColor = Color.FromArgb(211, 194, 214);
            OperacijaBtn.FlatStyle = FlatStyle.Flat;
            OperacijaBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OperacijaBtn.ForeColor = Color.Black;
            OperacijaBtn.Location = new Point(150, 263);
            OperacijaBtn.Name = "OperacijaBtn";
            OperacijaBtn.Size = new Size(174, 28);
            OperacijaBtn.TabIndex = 7;
            OperacijaBtn.Text = "PRETRAGA";
            OperacijaBtn.UseVisualStyleBackColor = false;
            OperacijaBtn.Click += OperacijaBtn_Click;
            // 
            // StarateljCmb
            // 
            StarateljCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            StarateljCmb.BackColor = Color.FromArgb(211, 194, 214);
            StarateljCmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            StarateljCmb.FormattingEnabled = true;
            StarateljCmb.Location = new Point(266, 155);
            StarateljCmb.Name = "StarateljCmb";
            StarateljCmb.Size = new Size(176, 29);
            StarateljCmb.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(211, 194, 214);
            flowLayoutPanel1.Controls.Add(KreirajBtn);
            flowLayoutPanel1.Controls.Add(ObrisiBtn);
            flowLayoutPanel1.Controls.Add(PromeniBtn);
            flowLayoutPanel1.Controls.Add(PretragaBtn);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 728);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(967, 41);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // KreirajBtn
            // 
            KreirajBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            KreirajBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KreirajBtn.Location = new Point(861, 3);
            KreirajBtn.Name = "KreirajBtn";
            KreirajBtn.Size = new Size(103, 26);
            KreirajBtn.TabIndex = 1;
            KreirajBtn.Text = "Kreiraj";
            KreirajBtn.UseVisualStyleBackColor = true;
            KreirajBtn.Click += KreirajBtn_Click;
            // 
            // ObrisiBtn
            // 
            ObrisiBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ObrisiBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ObrisiBtn.Location = new Point(746, 3);
            ObrisiBtn.Name = "ObrisiBtn";
            ObrisiBtn.Size = new Size(109, 26);
            ObrisiBtn.TabIndex = 2;
            ObrisiBtn.Text = "Obrisi";
            ObrisiBtn.UseVisualStyleBackColor = true;
            ObrisiBtn.Click += ObrisiBtn_Click;
            // 
            // PromeniBtn
            // 
            PromeniBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PromeniBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PromeniBtn.Location = new Point(624, 3);
            PromeniBtn.Name = "PromeniBtn";
            PromeniBtn.Size = new Size(116, 26);
            PromeniBtn.TabIndex = 3;
            PromeniBtn.Text = "Promeni";
            PromeniBtn.UseVisualStyleBackColor = true;
            PromeniBtn.Click += PromeniBtn_Click;
            // 
            // PretragaBtn
            // 
            PretragaBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PretragaBtn.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PretragaBtn.Location = new Point(511, 3);
            PretragaBtn.Name = "PretragaBtn";
            PretragaBtn.Size = new Size(107, 26);
            PretragaBtn.TabIndex = 0;
            PretragaBtn.Text = "Pretraga";
            PretragaBtn.UseVisualStyleBackColor = true;
            PretragaBtn.Click += PretragaBtn_Click;
            // 
            // PretragaPnl
            // 
            PretragaPnl.BackColor = Color.FromArgb(48, 204, 67);
            PretragaPnl.Controls.Add(HelpBtn);
            PretragaPnl.Controls.Add(PromeniPnl);
            PretragaPnl.Controls.Add(label4);
            PretragaPnl.Controls.Add(OperacijaLbl);
            PretragaPnl.Controls.Add(OperacijaBtn);
            PretragaPnl.Controls.Add(ImeTxt);
            PretragaPnl.Controls.Add(DecaKriterijumBtn);
            PretragaPnl.Controls.Add(StarateljCmb);
            PretragaPnl.Controls.Add(KriterijumStarateljBtn);
            PretragaPnl.Controls.Add(label2);
            PretragaPnl.Controls.Add(PrezimeTxt);
            PretragaPnl.Controls.Add(label1);
            PretragaPnl.Dock = DockStyle.Right;
            PretragaPnl.Location = new Point(499, 0);
            PretragaPnl.Name = "PretragaPnl";
            PretragaPnl.Size = new Size(468, 728);
            PretragaPnl.TabIndex = 10;
            PretragaPnl.Paint += PretragaPnl_Paint;
            // 
            // HelpBtn
            // 
            HelpBtn.BackColor = Color.FromArgb(211, 194, 214);
            HelpBtn.FlatStyle = FlatStyle.Flat;
            HelpBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HelpBtn.Location = new Point(428, 564);
            HelpBtn.Name = "HelpBtn";
            HelpBtn.Size = new Size(28, 28);
            HelpBtn.TabIndex = 14;
            HelpBtn.Text = "?";
            HelpBtn.UseVisualStyleBackColor = false;
            HelpBtn.Click += HelpBtn_Click;
            // 
            // PromeniPnl
            // 
            PromeniPnl.BorderStyle = BorderStyle.FixedSingle;
            PromeniPnl.Controls.Add(PromeniIdLbl);
            PromeniPnl.Controls.Add(PotvrdiPromeneBtn);
            PromeniPnl.Controls.Add(PromeniStarateljCmb);
            PromeniPnl.Controls.Add(PromeniPrezimeTxt);
            PromeniPnl.Controls.Add(PromeniImeTxt);
            PromeniPnl.Dock = DockStyle.Bottom;
            PromeniPnl.Location = new Point(0, 598);
            PromeniPnl.Name = "PromeniPnl";
            PromeniPnl.Size = new Size(468, 130);
            PromeniPnl.TabIndex = 11;
            PromeniPnl.Visible = false;
            // 
            // PromeniIdLbl
            // 
            PromeniIdLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PromeniIdLbl.AutoSize = true;
            PromeniIdLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PromeniIdLbl.Location = new Point(52, 15);
            PromeniIdLbl.Name = "PromeniIdLbl";
            PromeniIdLbl.Size = new Size(23, 21);
            PromeniIdLbl.TabIndex = 13;
            PromeniIdLbl.Text = "Id";
            // 
            // PotvrdiPromeneBtn
            // 
            PotvrdiPromeneBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PotvrdiPromeneBtn.BackColor = Color.FromArgb(211, 194, 214);
            PotvrdiPromeneBtn.FlatStyle = FlatStyle.Flat;
            PotvrdiPromeneBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PotvrdiPromeneBtn.ForeColor = Color.Black;
            PotvrdiPromeneBtn.Location = new Point(149, 78);
            PotvrdiPromeneBtn.Name = "PotvrdiPromeneBtn";
            PotvrdiPromeneBtn.Size = new Size(174, 28);
            PotvrdiPromeneBtn.TabIndex = 12;
            PotvrdiPromeneBtn.Text = "POTVRDI PROMENE";
            PotvrdiPromeneBtn.UseVisualStyleBackColor = false;
            PotvrdiPromeneBtn.Click += PotvrdiPromeneBtn_Click;
            // 
            // PromeniStarateljCmb
            // 
            PromeniStarateljCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PromeniStarateljCmb.BackColor = Color.FromArgb(211, 194, 214);
            PromeniStarateljCmb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PromeniStarateljCmb.FormattingEnabled = true;
            PromeniStarateljCmb.Location = new Point(344, 12);
            PromeniStarateljCmb.Name = "PromeniStarateljCmb";
            PromeniStarateljCmb.Size = new Size(102, 29);
            PromeniStarateljCmb.TabIndex = 12;
            // 
            // PromeniPrezimeTxt
            // 
            PromeniPrezimeTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PromeniPrezimeTxt.BackColor = Color.FromArgb(211, 194, 214);
            PromeniPrezimeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PromeniPrezimeTxt.Location = new Point(248, 12);
            PromeniPrezimeTxt.Name = "PromeniPrezimeTxt";
            PromeniPrezimeTxt.Size = new Size(80, 29);
            PromeniPrezimeTxt.TabIndex = 12;
            // 
            // PromeniImeTxt
            // 
            PromeniImeTxt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PromeniImeTxt.BackColor = Color.FromArgb(211, 194, 214);
            PromeniImeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PromeniImeTxt.Location = new Point(149, 12);
            PromeniImeTxt.Name = "PromeniImeTxt";
            PromeniImeTxt.Size = new Size(86, 29);
            PromeniImeTxt.TabIndex = 12;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(266, 132);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 10;
            label4.Text = "Staratelj";
            // 
            // OperacijaLbl
            // 
            OperacijaLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OperacijaLbl.AutoSize = true;
            OperacijaLbl.Font = new Font("Roboto Cn", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OperacijaLbl.Location = new Point(158, 26);
            OperacijaLbl.Name = "OperacijaLbl";
            OperacijaLbl.Size = new Size(157, 38);
            OperacijaLbl.TabIndex = 9;
            OperacijaLbl.Text = "PRETRAGA";
            OperacijaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeteFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 769);
            Controls.Add(DecaDgv);
            Controls.Add(PretragaPnl);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeteFrm";
            Text = "Dete";
            WindowState = FormWindowState.Maximized;
            Load += DeteFrm_Load;
            ((System.ComponentModel.ISupportInitialize)DecaDgv).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            PretragaPnl.ResumeLayout(false);
            PretragaPnl.PerformLayout();
            PromeniPnl.ResumeLayout(false);
            PromeniPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DecaDgv;
        private RadioButton DecaKriterijumBtn;
        private RadioButton KriterijumStarateljBtn;
        private TextBox ImeTxt;
        private TextBox PrezimeTxt;
        private Label label1;
        private Label label2;
        private Button OperacijaBtn;
        private ComboBox StarateljCmb;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel PretragaPnl;
        private Label OperacijaLbl;
        private Label label4;
        private Button PretragaBtn;
        private Button KreirajBtn;
        private Button ObrisiBtn;
        private Button PromeniBtn;
        private Panel PromeniPnl;
        private ComboBox PromeniStarateljCmb;
        private TextBox PromeniPrezimeTxt;
        private TextBox PromeniImeTxt;
        private Button PotvrdiPromeneBtn;
        private Label PromeniIdLbl;
        private Button HelpBtn;
    }
}