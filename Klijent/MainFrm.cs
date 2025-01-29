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
    }
}
