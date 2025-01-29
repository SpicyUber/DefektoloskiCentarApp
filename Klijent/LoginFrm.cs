using Komunikacija;
using System.Net;
using System.Net.Sockets;

namespace Klijent
{
    public partial class LoginFrm : Form
    {

        public LoginFrm()
        {


            InitializeComponent();

        }


        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }



        void Prijava()
        {
            if (!Konekcija.Instanca.PoveziSaServerom())
            {
                MessageBox.Show("Neuspešno povezivanje sa serverom!");
                return;
            }
            Odgovor o = Konekcija.Instanca.Prijava(korisnickoImeTxt.Text, sifraTxt.Text);
            MessageBox.Show(o.Poruka);
            if (o.Uspeh == true)
            {

                this.Visible = false;

                MainFrm mainFrm = new MainFrm();
                mainFrm.ShowDialog();

                this.Visible = true;

            }
        }

        private void PrijavaBtn_Click(object sender, EventArgs e)
        {
            Prijava();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}