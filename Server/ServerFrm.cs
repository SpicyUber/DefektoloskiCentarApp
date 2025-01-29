using System.Diagnostics;
using System.Net.Sockets;

namespace Server
{
    public partial class ServerFrm : Form
    {
        Server s;
        private bool izmeriStanje = false;
        private bool stanjeServera = false;

        public ServerFrm()
        {

            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            s = new Server();
            AzurirajStanje();
            Thread t1 = new(IzmeriStanje);
            t1.Start();
        }

        private void IzmeriStanje()
        {
            izmeriStanje = true;

            try
            {
                while (izmeriStanje)
                {
                    if (s.Soket == null) { stanjeServera = false; }
                    else
                    {

                        stanjeServera = s.ServerAktivan;


                    }

                    this?.Invoke((MethodInvoker)AzurirajStanje);
                }
            }
            catch (Exception e)
            {
                izmeriStanje = false; Debug.WriteLine(e.Message);
            }

        }

        private void AzurirajStanje()
        {
            StatusLbl.Text = (stanjeServera) ? "Status servera : AKTIVAN" : "Status servera : NIJE AKTIVAN";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* private void button1_Click(object sender, EventArgs e)
         {

         }*/

        private void StaniBtn_Click(object sender, EventArgs e)
        {
            s.Stani();
        }



        private void KreniBtn_Click(object sender, EventArgs e)
        {
            s.Kreni();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServerFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            izmeriStanje = false;
            s.Stani();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}