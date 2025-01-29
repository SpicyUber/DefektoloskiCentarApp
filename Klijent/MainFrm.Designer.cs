namespace Klijent
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            DobrodosliLbl = new Label();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            dokumentiToolStripMenuItem = new ToolStripMenuItem();
            evidencijaTretmanaToolStripMenuItem = new ToolStripMenuItem();
            pružalacUslugeToolStripMenuItem = new ToolStripMenuItem();
            defektologToolStripMenuItem = new ToolStripMenuItem();
            primalacUslugeToolStripMenuItem = new ToolStripMenuItem();
            deteToolStripMenuItem = new ToolStripMenuItem();
            šifarniciToolStripMenuItem = new ToolStripMenuItem();
            defektoloskaUslugaToolStripMenuItem = new ToolStripMenuItem();
            odgovorniStarateljToolStripMenuItem = new ToolStripMenuItem();
            specijalizacijaToolStripMenuItem = new ToolStripMenuItem();
            podešavanjaSoftverskogSistemaToolStripMenuItem = new ToolStripMenuItem();
            oProgramuToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // DobrodosliLbl
            // 
            DobrodosliLbl.Anchor = AnchorStyles.None;
            DobrodosliLbl.AutoSize = true;
            DobrodosliLbl.Font = new Font("Roboto Cn", 24F, FontStyle.Bold, GraphicsUnit.Point);
            DobrodosliLbl.ForeColor = Color.FromArgb(235, 235, 235);
            DobrodosliLbl.Location = new Point(445, 158);
            DobrodosliLbl.Name = "DobrodosliLbl";
            DobrodosliLbl.Size = new Size(204, 38);
            DobrodosliLbl.TabIndex = 0;
            DobrodosliLbl.Text = "Dobrodošli/la, ";
            DobrodosliLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(48, 204, 67);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(DobrodosliLbl);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 705);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Roboto Cn", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(235, 235, 235);
            label1.Location = new Point(422, 567);
            label1.Name = "label1";
            label1.Size = new Size(339, 38);
            label1.TabIndex = 3;
            label1.Text = "Sidarta Softverski Sistem";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(391, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 365);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(235, 235, 235);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dokumentiToolStripMenuItem, pružalacUslugeToolStripMenuItem, primalacUslugeToolStripMenuItem, šifarniciToolStripMenuItem, podešavanjaSoftverskogSistemaToolStripMenuItem, oProgramuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1165, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dokumentiToolStripMenuItem
            // 
            dokumentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { evidencijaTretmanaToolStripMenuItem });
            dokumentiToolStripMenuItem.Name = "dokumentiToolStripMenuItem";
            dokumentiToolStripMenuItem.Size = new Size(78, 20);
            dokumentiToolStripMenuItem.Text = "Dokumenti";
            // 
            // evidencijaTretmanaToolStripMenuItem
            // 
            evidencijaTretmanaToolStripMenuItem.Name = "evidencijaTretmanaToolStripMenuItem";
            evidencijaTretmanaToolStripMenuItem.Size = new Size(178, 22);
            evidencijaTretmanaToolStripMenuItem.Text = "Evidencija tretmana";
            // 
            // pružalacUslugeToolStripMenuItem
            // 
            pružalacUslugeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defektologToolStripMenuItem });
            pružalacUslugeToolStripMenuItem.Name = "pružalacUslugeToolStripMenuItem";
            pružalacUslugeToolStripMenuItem.Size = new Size(101, 20);
            pružalacUslugeToolStripMenuItem.Text = "Pružalac usluge";
            // 
            // defektologToolStripMenuItem
            // 
            defektologToolStripMenuItem.Name = "defektologToolStripMenuItem";
            defektologToolStripMenuItem.Size = new Size(132, 22);
            defektologToolStripMenuItem.Text = "Defektolog";
            // 
            // primalacUslugeToolStripMenuItem
            // 
            primalacUslugeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deteToolStripMenuItem });
            primalacUslugeToolStripMenuItem.Name = "primalacUslugeToolStripMenuItem";
            primalacUslugeToolStripMenuItem.Size = new Size(103, 20);
            primalacUslugeToolStripMenuItem.Text = "Primalac usluge";
            // 
            // deteToolStripMenuItem
            // 
            deteToolStripMenuItem.Name = "deteToolStripMenuItem";
            deteToolStripMenuItem.Size = new Size(98, 22);
            deteToolStripMenuItem.Text = "Dete";
            deteToolStripMenuItem.Click += deteToolStripMenuItem_Click;
            // 
            // šifarniciToolStripMenuItem
            // 
            šifarniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { defektoloskaUslugaToolStripMenuItem, odgovorniStarateljToolStripMenuItem, specijalizacijaToolStripMenuItem });
            šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            šifarniciToolStripMenuItem.Size = new Size(61, 20);
            šifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // defektoloskaUslugaToolStripMenuItem
            // 
            defektoloskaUslugaToolStripMenuItem.Name = "defektoloskaUslugaToolStripMenuItem";
            defektoloskaUslugaToolStripMenuItem.Size = new Size(180, 22);
            defektoloskaUslugaToolStripMenuItem.Text = "Defektološka usluga";
            // 
            // odgovorniStarateljToolStripMenuItem
            // 
            odgovorniStarateljToolStripMenuItem.Name = "odgovorniStarateljToolStripMenuItem";
            odgovorniStarateljToolStripMenuItem.Size = new Size(180, 22);
            odgovorniStarateljToolStripMenuItem.Text = "Odgovorni staratelj";
            // 
            // specijalizacijaToolStripMenuItem
            // 
            specijalizacijaToolStripMenuItem.Name = "specijalizacijaToolStripMenuItem";
            specijalizacijaToolStripMenuItem.Size = new Size(180, 22);
            specijalizacijaToolStripMenuItem.Text = "Specijalizacija";
            specijalizacijaToolStripMenuItem.Click += specijalizacijaToolStripMenuItem_Click;
            // 
            // podešavanjaSoftverskogSistemaToolStripMenuItem
            // 
            podešavanjaSoftverskogSistemaToolStripMenuItem.Name = "podešavanjaSoftverskogSistemaToolStripMenuItem";
            podešavanjaSoftverskogSistemaToolStripMenuItem.Size = new Size(192, 20);
            podešavanjaSoftverskogSistemaToolStripMenuItem.Text = "Podešavanja softverskog sistema";
            // 
            // oProgramuToolStripMenuItem
            // 
            oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            oProgramuToolStripMenuItem.Size = new Size(84, 20);
            oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(1164, 704);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainFrm";
            Text = "MainFrm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label DobrodosliLbl;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem dokumentiToolStripMenuItem;
        private ToolStripMenuItem evidencijaTretmanaToolStripMenuItem;
        private ToolStripMenuItem pružalacUslugeToolStripMenuItem;
        private ToolStripMenuItem primalacUslugeToolStripMenuItem;
        private ToolStripMenuItem šifarniciToolStripMenuItem;
        private ToolStripMenuItem podešavanjaSoftverskogSistemaToolStripMenuItem;
        private ToolStripMenuItem oProgramuToolStripMenuItem;
        private ToolStripMenuItem defektologToolStripMenuItem;
        private ToolStripMenuItem deteToolStripMenuItem;
        private ToolStripMenuItem defektoloskaUslugaToolStripMenuItem;
        private ToolStripMenuItem odgovorniStarateljToolStripMenuItem;
        private ToolStripMenuItem specijalizacijaToolStripMenuItem;
        private Label label1;
    }
}