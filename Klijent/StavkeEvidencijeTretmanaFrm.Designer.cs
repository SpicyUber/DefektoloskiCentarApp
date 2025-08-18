namespace Klijent
{
    partial class StavkeEvidencijeTretmanaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StavkeEvidencijeTretmanaFrm));
            StavkeDgv = new DataGridView();
            PromeniPnl = new Panel();
            IzbaciCmb = new Button();
            DodajBtn = new Button();
            UslugaLbl = new Label();
            UslugaCmb = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)StavkeDgv).BeginInit();
            PromeniPnl.SuspendLayout();
            SuspendLayout();
            // 
            // StavkeDgv
            // 
            StavkeDgv.AllowUserToAddRows = false;
            StavkeDgv.AllowUserToDeleteRows = false;
            StavkeDgv.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StavkeDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StavkeDgv.BackgroundColor = SystemColors.Control;
            StavkeDgv.BorderStyle = BorderStyle.None;
            StavkeDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StavkeDgv.Location = new Point(0, 0);
            StavkeDgv.Name = "StavkeDgv";
            StavkeDgv.ReadOnly = true;
            StavkeDgv.RowTemplate.Height = 25;
            StavkeDgv.Size = new Size(634, 450);
            StavkeDgv.TabIndex = 1;
            StavkeDgv.CellContentClick += StavkeDgv_CellContentClick;
            // 
            // PromeniPnl
            // 
            PromeniPnl.BackColor = Color.FromArgb(48, 204, 67);
            PromeniPnl.BorderStyle = BorderStyle.FixedSingle;
            PromeniPnl.Controls.Add(IzbaciCmb);
            PromeniPnl.Controls.Add(DodajBtn);
            PromeniPnl.Controls.Add(UslugaLbl);
            PromeniPnl.Controls.Add(UslugaCmb);
            PromeniPnl.Dock = DockStyle.Right;
            PromeniPnl.Location = new Point(629, 0);
            PromeniPnl.Name = "PromeniPnl";
            PromeniPnl.Size = new Size(171, 450);
            PromeniPnl.TabIndex = 2;
            // 
            // IzbaciCmb
            // 
            IzbaciCmb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            IzbaciCmb.BackColor = Color.FromArgb(211, 194, 214);
            IzbaciCmb.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IzbaciCmb.Location = new Point(86, 414);
            IzbaciCmb.Name = "IzbaciCmb";
            IzbaciCmb.Size = new Size(60, 23);
            IzbaciCmb.TabIndex = 3;
            IzbaciCmb.Text = "IZBACI";
            IzbaciCmb.UseVisualStyleBackColor = false;
            IzbaciCmb.Click += IzbaciCmb_Click;
            // 
            // DodajBtn
            // 
            DodajBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DodajBtn.BackColor = Color.FromArgb(211, 194, 214);
            DodajBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DodajBtn.Location = new Point(25, 414);
            DodajBtn.Name = "DodajBtn";
            DodajBtn.Size = new Size(60, 23);
            DodajBtn.TabIndex = 2;
            DodajBtn.Text = "UBACI";
            DodajBtn.UseVisualStyleBackColor = false;
            DodajBtn.Click += DodajBtn_Click;
            // 
            // UslugaLbl
            // 
            UslugaLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UslugaLbl.AutoSize = true;
            UslugaLbl.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UslugaLbl.Location = new Point(18, 27);
            UslugaLbl.Name = "UslugaLbl";
            UslugaLbl.Size = new Size(140, 19);
            UslugaLbl.TabIndex = 1;
            UslugaLbl.Text = "Defektološka Usluga";
            UslugaLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UslugaCmb
            // 
            UslugaCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            UslugaCmb.BackColor = Color.FromArgb(211, 194, 214);
            UslugaCmb.FormattingEnabled = true;
            UslugaCmb.Location = new Point(25, 56);
            UslugaCmb.Name = "UslugaCmb";
            UslugaCmb.Size = new Size(121, 23);
            UslugaCmb.TabIndex = 0;
            // 
            // StavkeEvidencijeTretmanaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(PromeniPnl);
            Controls.Add(StavkeDgv);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StavkeEvidencijeTretmanaFrm";
            Text = "Stavke Evidencije Tretmana";
            FormClosing += StavkeEvidencijeTretmanaFrm_FormClosing;
            Load += StavkeEvidencijeTretmanaFrm_Load;
            ((System.ComponentModel.ISupportInitialize)StavkeDgv).EndInit();
            PromeniPnl.ResumeLayout(false);
            PromeniPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView StavkeDgv;
        private Panel PromeniPnl;
        private ComboBox UslugaCmb;
        private Label UslugaLbl;
        private Button DodajBtn;
        private Button IzbaciCmb;
    }
}