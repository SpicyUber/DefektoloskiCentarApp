using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            DobrodosliLbl.Text += Konekcija.Instanca.KorisnickoIme;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeteFrm dete = new();
            dete.Show();
        }

        private void specijalizacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpecijalizacijaFrm specijalizacija = new();
            specijalizacija.Show();
        }

        private void evidencijaTretmanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvidencijaTretmanaFrm evidencija = new();
            evidencija.Show();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("Doviđenja! " + Konekcija.Instanca.Odjava().Poruka);
        }
    }
}
