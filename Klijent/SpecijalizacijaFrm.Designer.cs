namespace Klijent
{
    partial class SpecijalizacijaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecijalizacijaFrm));
            SpecijalizacijaDgv = new DataGridView();
            panel1 = new Panel();
            OperacijaBtn = new Button();
            InstitucijaTxt = new TextBox();
            NazivTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            OperacijaLbl = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            UbaciBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)SpecijalizacijaDgv).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SpecijalizacijaDgv
            // 
            SpecijalizacijaDgv.AllowUserToAddRows = false;
            SpecijalizacijaDgv.AllowUserToDeleteRows = false;
            SpecijalizacijaDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SpecijalizacijaDgv.BackgroundColor = Color.FromArgb(235, 235, 235);
            SpecijalizacijaDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SpecijalizacijaDgv.Dock = DockStyle.Fill;
            SpecijalizacijaDgv.Location = new Point(0, 0);
            SpecijalizacijaDgv.Name = "SpecijalizacijaDgv";
            SpecijalizacijaDgv.ReadOnly = true;
            SpecijalizacijaDgv.RowTemplate.Height = 25;
            SpecijalizacijaDgv.Size = new Size(636, 672);
            SpecijalizacijaDgv.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(48, 204, 67);
            panel1.Controls.Add(OperacijaBtn);
            panel1.Controls.Add(InstitucijaTxt);
            panel1.Controls.Add(NazivTxt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(OperacijaLbl);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(636, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 672);
            panel1.TabIndex = 1;
            // 
            // OperacijaBtn
            // 
            OperacijaBtn.BackColor = Color.FromArgb(211, 194, 214);
            OperacijaBtn.FlatAppearance.BorderColor = Color.Black;
            OperacijaBtn.FlatStyle = FlatStyle.Flat;
            OperacijaBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OperacijaBtn.Location = new Point(132, 175);
            OperacijaBtn.Name = "OperacijaBtn";
            OperacijaBtn.Size = new Size(75, 27);
            OperacijaBtn.TabIndex = 5;
            OperacijaBtn.Text = "UBACI";
            OperacijaBtn.UseVisualStyleBackColor = false;
            OperacijaBtn.Click += OperacijaBtn_Click;
            // 
            // InstitucijaTxt
            // 
            InstitucijaTxt.BackColor = Color.FromArgb(211, 194, 214);
            InstitucijaTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            InstitucijaTxt.Location = new Point(183, 121);
            InstitucijaTxt.Name = "InstitucijaTxt";
            InstitucijaTxt.Size = new Size(100, 29);
            InstitucijaTxt.TabIndex = 4;
            // 
            // NazivTxt
            // 
            NazivTxt.BackColor = Color.FromArgb(211, 194, 214);
            NazivTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NazivTxt.Location = new Point(65, 121);
            NazivTxt.Name = "NazivTxt";
            NazivTxt.Size = new Size(100, 29);
            NazivTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(183, 99);
            label2.Name = "label2";
            label2.Size = new Size(72, 19);
            label2.TabIndex = 2;
            label2.Text = "Institucija";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 99);
            label1.Name = "label1";
            label1.Size = new Size(44, 19);
            label1.TabIndex = 1;
            label1.Text = "Naziv";
            // 
            // OperacijaLbl
            // 
            OperacijaLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OperacijaLbl.AutoSize = true;
            OperacijaLbl.Font = new Font("Roboto Cn", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OperacijaLbl.Location = new Point(122, 42);
            OperacijaLbl.Name = "OperacijaLbl";
            OperacijaLbl.Size = new Size(98, 38);
            OperacijaLbl.TabIndex = 0;
            OperacijaLbl.Text = "UBACI";
            OperacijaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.FromArgb(211, 194, 214);
            flowLayoutPanel1.Controls.Add(UbaciBtn);
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 633);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(976, 39);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // UbaciBtn
            // 
            UbaciBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UbaciBtn.Location = new Point(869, 3);
            UbaciBtn.Name = "UbaciBtn";
            UbaciBtn.Size = new Size(104, 29);
            UbaciBtn.TabIndex = 0;
            UbaciBtn.Text = "Ubaci";
            UbaciBtn.UseVisualStyleBackColor = true;
            UbaciBtn.Click += UbaciBtn_Click;
            // 
            // SpecijalizacijaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 672);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(SpecijalizacijaDgv);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SpecijalizacijaFrm";
            Text = "Specijalizacija";
            WindowState = FormWindowState.Maximized;
            Load += SpecijalizacijaFrm_Load;
            ((System.ComponentModel.ISupportInitialize)SpecijalizacijaDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SpecijalizacijaDgv;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button UbaciBtn;
        private TextBox InstitucijaTxt;
        private TextBox NazivTxt;
        private Label label2;
        private Label label1;
        private Label OperacijaLbl;
        private Button OperacijaBtn;
    }
}