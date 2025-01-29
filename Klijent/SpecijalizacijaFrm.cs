using Domen;
using Komunikacija;
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
    public partial class SpecijalizacijaFrm : Form
    {
        BindingList<Specijalizacija> specijalizacije;
        private SK trenutniSK = SK.UBACI;

        internal enum SK
        {
            UBACI
        }
        public SpecijalizacijaFrm()
        {
            InitializeComponent();
            UcitajSpecijalizacije(true);
        }

        private void PromeniOperaciju(SK sk)
        {
            switch (sk)
            {
                case SK.UBACI:
                    UcitajSpecijalizacije(false);
                    break;
            }
            OperacijaLbl.Text = sk.ToString();
            OperacijaBtn.Text = sk.ToString();
        }

        private void UcitajSpecijalizacije(bool obavesti)
        {
            Odgovor odg = Konekcija.Instanca.VratiListuSviSpecijalizacija();
            if (odg != null && obavesti) MessageBox.Show(odg.Poruka);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null) { specijalizacije = new BindingList<Specijalizacija>((List<Specijalizacija>)odg.Objekat); }
            SpecijalizacijaDgv.DataSource = null;
            SpecijalizacijaDgv.DataSource = specijalizacije;
        }

        private void SpecijalizacijaFrm_Load(object sender, EventArgs e)
        {

        }

        private void OperacijaBtn_Click(object sender, EventArgs e)
        {
            IzvrsiOperaciju();
        }

        private void IzvrsiOperaciju()
        {
            switch (trenutniSK)
            {
                case SK.UBACI:
                    UbaciSpecijalizaciju();
                    UcitajSpecijalizacije(false);
                    break;

            }
        }

        private void UbaciSpecijalizaciju()
        {
            if (MessageBox.Show("Specijalizacija je kreirana, da li želite da je sačuvate?", "Ubaci Specijalizaciju", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            Odgovor odg = Konekcija.Instanca.UbaciSpecijalizacija(new() { Id = 0, Institucija = InstitucijaTxt.Text, Naziv = NazivTxt.Text });
            if (odg != null) { MessageBox.Show(odg.Poruka); }
        }

        private void UbaciBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.UBACI);
        }
    }
}
