namespace Server
{
    partial class ServerFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerFrm));
            KreniBtn = new Button();
            panel1 = new Panel();
            StatusLbl = new Label();
            StaniBtn = new Button();
            pictureBox1 = new PictureBox();
            DobrodosliLbl = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // KreniBtn
            // 
            KreniBtn.Anchor = AnchorStyles.None;
            KreniBtn.BackColor = Color.FromArgb(211, 194, 214);
            KreniBtn.FlatAppearance.BorderColor = Color.FromArgb(98, 59, 90);
            KreniBtn.FlatStyle = FlatStyle.Flat;
            KreniBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            KreniBtn.ForeColor = Color.FromArgb(25, 25, 35);
            KreniBtn.Location = new Point(300, 99);
            KreniBtn.Name = "KreniBtn";
            KreniBtn.Size = new Size(205, 63);
            KreniBtn.TabIndex = 0;
            KreniBtn.Text = "Pokreni Server";
            KreniBtn.UseVisualStyleBackColor = false;
            KreniBtn.Click += KreniBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(StatusLbl);
            panel1.Controls.Add(StaniBtn);
            panel1.Controls.Add(KreniBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 415);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // StatusLbl
            // 
            StatusLbl.Anchor = AnchorStyles.None;
            StatusLbl.AutoSize = true;
            StatusLbl.BackColor = Color.FromArgb(211, 194, 214);
            StatusLbl.BorderStyle = BorderStyle.FixedSingle;
            StatusLbl.FlatStyle = FlatStyle.Flat;
            StatusLbl.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StatusLbl.ForeColor = Color.FromArgb(25, 25, 35);
            StatusLbl.Location = new Point(300, 55);
            StatusLbl.Name = "StatusLbl";
            StatusLbl.Size = new Size(105, 21);
            StatusLbl.TabIndex = 3;
            StatusLbl.Text = "Status servera:";
            // 
            // StaniBtn
            // 
            StaniBtn.Anchor = AnchorStyles.None;
            StaniBtn.BackColor = Color.FromArgb(211, 194, 214);
            StaniBtn.FlatAppearance.BorderColor = Color.FromArgb(98, 59, 90);
            StaniBtn.FlatStyle = FlatStyle.Flat;
            StaniBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StaniBtn.ForeColor = Color.FromArgb(25, 25, 35);
            StaniBtn.Location = new Point(300, 196);
            StaniBtn.Name = "StaniBtn";
            StaniBtn.Size = new Size(205, 63);
            StaniBtn.TabIndex = 1;
            StaniBtn.Text = "Zaustavi Server";
            StaniBtn.UseVisualStyleBackColor = false;
            StaniBtn.Click += StaniBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, -241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(811, 653);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // DobrodosliLbl
            // 
            DobrodosliLbl.Anchor = AnchorStyles.None;
            DobrodosliLbl.AutoSize = true;
            DobrodosliLbl.Font = new Font("Roboto Cn", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DobrodosliLbl.ForeColor = Color.FromArgb(235, 235, 235);
            DobrodosliLbl.Location = new Point(327, 8);
            DobrodosliLbl.Name = "DobrodosliLbl";
            DobrodosliLbl.Size = new Size(163, 38);
            DobrodosliLbl.TabIndex = 2;
            DobrodosliLbl.Text = "Dobrodošli!";
            DobrodosliLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(48, 204, 67);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(DobrodosliLbl);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 53);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(749, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // ServerFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(808, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ServerFrm";
            Text = "Defektološki Centar (Server)";
            WindowState = FormWindowState.Maximized;
            FormClosing += ServerFrm_FormClosing;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button KreniBtn;
        private Panel panel1;
        private Button StaniBtn;
        private Label DobrodosliLbl;
        private Label StatusLbl;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}