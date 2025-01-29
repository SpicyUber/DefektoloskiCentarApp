namespace Klijent
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            PrijavaBtn = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            PrijavaKorisnikaLbl = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            sifraTxt = new TextBox();
            korisnickoImeTxt = new TextBox();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PrijavaBtn
            // 
            PrijavaBtn.Anchor = AnchorStyles.None;
            PrijavaBtn.BackColor = Color.FromArgb(211, 194, 214);
            PrijavaBtn.FlatAppearance.BorderColor = Color.FromArgb(25, 25, 35);
            PrijavaBtn.FlatAppearance.BorderSize = 2;
            PrijavaBtn.FlatStyle = FlatStyle.Flat;
            PrijavaBtn.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PrijavaBtn.ForeColor = Color.FromArgb(25, 25, 35);
            PrijavaBtn.Location = new Point(351, 247);
            PrijavaBtn.Name = "PrijavaBtn";
            PrijavaBtn.Size = new Size(112, 29);
            PrijavaBtn.TabIndex = 0;
            PrijavaBtn.Text = "prijavi se";
            PrijavaBtn.UseVisualStyleBackColor = false;
            PrijavaBtn.Click += PrijavaBtn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(48, 204, 67);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(PrijavaKorisnikaLbl);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 55);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(745, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // PrijavaKorisnikaLbl
            // 
            PrijavaKorisnikaLbl.Anchor = AnchorStyles.None;
            PrijavaKorisnikaLbl.AutoSize = true;
            PrijavaKorisnikaLbl.Font = new Font("Roboto Cn", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            PrijavaKorisnikaLbl.ForeColor = Color.FromArgb(235, 235, 235);
            PrijavaKorisnikaLbl.Location = new Point(295, 11);
            PrijavaKorisnikaLbl.Name = "PrijavaKorisnikaLbl";
            PrijavaKorisnikaLbl.Size = new Size(231, 38);
            PrijavaKorisnikaLbl.TabIndex = 2;
            PrijavaKorisnikaLbl.Text = "Prijava Korisnika";
            PrijavaKorisnikaLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sifraTxt);
            panel1.Controls.Add(korisnickoImeTxt);
            panel1.Controls.Add(PrijavaBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 420);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(211, 194, 214);
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(25, 25, 35);
            label2.Location = new Point(318, 141);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 4;
            label2.Text = "šifra:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(211, 194, 214);
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Roboto Condensed Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(25, 25, 35);
            label1.Location = new Point(318, 49);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 3;
            label1.Text = "korisničko ime:";
            // 
            // sifraTxt
            // 
            sifraTxt.Anchor = AnchorStyles.None;
            sifraTxt.BackColor = Color.FromArgb(211, 194, 214);
            sifraTxt.BorderStyle = BorderStyle.FixedSingle;
            sifraTxt.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sifraTxt.ForeColor = Color.FromArgb(25, 25, 35);
            sifraTxt.Location = new Point(318, 179);
            sifraTxt.Name = "sifraTxt";
            sifraTxt.Size = new Size(177, 27);
            sifraTxt.TabIndex = 2;
            // 
            // korisnickoImeTxt
            // 
            korisnickoImeTxt.Anchor = AnchorStyles.None;
            korisnickoImeTxt.BackColor = Color.FromArgb(211, 194, 214);
            korisnickoImeTxt.BorderStyle = BorderStyle.FixedSingle;
            korisnickoImeTxt.Font = new Font("Roboto Cn", 12F, FontStyle.Bold, GraphicsUnit.Point);
            korisnickoImeTxt.ForeColor = Color.FromArgb(25, 25, 35);
            korisnickoImeTxt.Location = new Point(318, 90);
            korisnickoImeTxt.MaximumSize = new Size(177, 27);
            korisnickoImeTxt.MinimumSize = new Size(177, 27);
            korisnickoImeTxt.Name = "korisnickoImeTxt";
            korisnickoImeTxt.Size = new Size(177, 27);
            korisnickoImeTxt.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -462);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 879);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(800, 471);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginFrm";
            Text = "Defektološki Centar (Klijent)";
            WindowState = FormWindowState.Maximized;
            Load += LoginFrm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button PrijavaBtn;
        private Panel panel2;
        private Label PrijavaKorisnikaLbl;
        private Panel panel1;
        private TextBox korisnickoImeTxt;
        private TextBox sifraTxt;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}