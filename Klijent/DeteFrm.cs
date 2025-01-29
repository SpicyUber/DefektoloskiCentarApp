using Domen;
using Komunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Klijent
{
    public partial class DeteFrm : Form
    {
        BindingList<Dete> deca;
        private SK trenutniSK;
        private Dete deteZaPromenu = null;

        internal enum SK
        {
            PRETRAGA, KREIRAJ, OBRISI,
            PROMENI
        }
        public DeteFrm()
        {
            trenutniSK = SK.PRETRAGA;
            InitializeComponent();
            UcitajOdgovorneStaratelje();
            UcitajDecu(true);
            DecaKriterijumBtn.Checked = true;

        }

        private void UcitajOdgovorneStaratelje()
        {
            BindingList<OdgovorniStaratelj> lista = new BindingList<OdgovorniStaratelj>((List<OdgovorniStaratelj>)Konekcija.Instanca.VratiListuSviOdgovorniStaratelj().Objekat);
            StarateljCmb.DataSource = lista;
            StarateljCmb.ValueMember = "Id";
            StarateljCmb.DisplayMember = "CmbValue";
            PromeniStarateljCmb.DataSource = lista;
            PromeniStarateljCmb.ValueMember = "Id";
            PromeniStarateljCmb.DisplayMember = "CmbValue";
        }

        private void UcitajDecu(bool obavesti)
        {
            Odgovor odg = Konekcija.Instanca.PretraziDete(new Dete());
            if (odg != null && obavesti) MessageBox.Show(odg.Poruka);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null) { deca = new BindingList<Dete>((List<Dete>)odg.Objekat); }
            DecaDgv.DataSource = null;
            DecaDgv.DataSource = deca;
        }

        private void DeteFrm_Load(object sender, EventArgs e)
        {

        }

        private void DecaKriterijumBtn_CheckedChanged(object sender, EventArgs e)
        {
            ImeTxt.Enabled = DecaKriterijumBtn.Checked;
            PrezimeTxt.Enabled = DecaKriterijumBtn.Checked;
            StarateljCmb.Enabled = !DecaKriterijumBtn.Checked;
        }

        private void PretraziBtn_Click(object sender, EventArgs e)
        {


        }

        private void IzvrsiSK(SK sk)
        {
            switch (sk)
            {
                case SK.PRETRAGA:
                    Pretraga();

                    break;
                case SK.KREIRAJ:
                    Kreiraj();
                    UcitajOdgovorneStaratelje();
                    UcitajDecu(false);
                    break;
                case SK.OBRISI:
                    UcitajOdgovorneStaratelje();
                    Pretraga();
                    if (deca == null || deca.Count == 0) { return; }
                    DialogResult dg = MessageBox.Show("Da li želite da obrišete PRVO pronađeno dete na listi?", "Obriši Dete", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                        Obrisi();


                    break;
                case SK.PROMENI:
                    Pretraga();

                    break;
            }
        }

        private void Obrisi()
        {
            MessageBox.Show(Konekcija.Instanca.ObrisiDete(deca[0]).Poruka);
            DecaKriterijumBtn.Enabled = true;
            KriterijumStarateljBtn.Enabled = true;
            DecaKriterijumBtn.Checked = true;
            ImeTxt.Enabled = DecaKriterijumBtn.Checked;
            PrezimeTxt.Enabled = DecaKriterijumBtn.Checked;
            StarateljCmb.Enabled = !DecaKriterijumBtn.Checked;
            DecaKriterijumBtn.Visible = true;
            KriterijumStarateljBtn.Visible = true;
            ImeTxt.Text = "";
            PrezimeTxt.Text = "";


            UcitajOdgovorneStaratelje();
            UcitajDecu(false);
        }

        private void Kreiraj()
        {
            Dete dete;
            try { dete = new() { Ime = ImeTxt.Text, Prezime = PrezimeTxt.Text, Staratelj = new() { Id = (int)StarateljCmb.SelectedValue } }; } catch (Exception ex) { MessageBox.Show("Sistem ne može kreirati dete!"); return; }
            DialogResult dr = MessageBox.Show("Sistem je kreirao dete, da li želite da ga sačuvate? ", "Kreiraj Dete", MessageBoxButtons.YesNo);
            if (dr != DialogResult.Yes) return;

            Odgovor odg;
            odg = Konekcija.Instanca.KreirajDete(dete);

            if (odg != null) MessageBox.Show(odg.Poruka);

        }

        private void Pretraga()
        {
            Odgovor odg;
            if (DecaKriterijumBtn.Checked)
            {
                odg = Konekcija.Instanca.PretraziDete(new Dete() { Id = 0, Ime = ImeTxt.Text, Prezime = PrezimeTxt.Text });
            }
            else
            {
                odg = Konekcija.Instanca.VratiListuDetePoKriterijumuOdgovorniStaratelj(new() { Id = (int)StarateljCmb.SelectedValue });
            }
            if (odg != null) MessageBox.Show(odg.Poruka);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null) { deca = new BindingList<Dete>((List<Dete>)odg.Objekat); }
            DecaDgv.DataSource = null;
            DecaDgv.DataSource = deca;
        }

        private void KreirajBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.KREIRAJ);
        }

        private void PromeniOperaciju(SK sk)
        {
            switch (sk)
            {
                case SK.PRETRAGA:
                    DecaKriterijumBtn.Enabled = true;
                    KriterijumStarateljBtn.Enabled = true;
                    KriterijumStarateljBtn.Checked = true;
                    ImeTxt.Enabled = DecaKriterijumBtn.Checked;
                    PrezimeTxt.Enabled = DecaKriterijumBtn.Checked;
                    StarateljCmb.Enabled = !DecaKriterijumBtn.Checked;
                    DecaKriterijumBtn.Visible = true;
                    KriterijumStarateljBtn.Visible = true;

                    UcitajOdgovorneStaratelje();
                    UcitajDecu(false);

                    break;
                case SK.KREIRAJ:

                    ImeTxt.Enabled = true;
                    PrezimeTxt.Enabled = true;
                    StarateljCmb.Enabled = true;
                    DecaKriterijumBtn.Visible = false;
                    KriterijumStarateljBtn.Visible = false;
                    DecaKriterijumBtn.Enabled = false;
                    KriterijumStarateljBtn.Enabled = false;
                    UcitajOdgovorneStaratelje();
                    UcitajDecu(false);

                    break;

                case SK.OBRISI:

                    DecaKriterijumBtn.Enabled = true;
                    KriterijumStarateljBtn.Enabled = true;
                    KriterijumStarateljBtn.Checked = true;
                    ImeTxt.Enabled = DecaKriterijumBtn.Checked;
                    PrezimeTxt.Enabled = DecaKriterijumBtn.Checked;
                    StarateljCmb.Enabled = !DecaKriterijumBtn.Checked;
                    DecaKriterijumBtn.Visible = true;
                    KriterijumStarateljBtn.Visible = true;

                    UcitajOdgovorneStaratelje();
                    UcitajDecu(false);
                    break;
                case SK.PROMENI:
                    deteZaPromenu = null;
                    DecaKriterijumBtn.Enabled = true;
                    KriterijumStarateljBtn.Enabled = true;
                    KriterijumStarateljBtn.Checked = true;
                    ImeTxt.Enabled = DecaKriterijumBtn.Checked;
                    PrezimeTxt.Enabled = DecaKriterijumBtn.Checked;
                    StarateljCmb.Enabled = !DecaKriterijumBtn.Checked;
                    DecaKriterijumBtn.Visible = true;
                    KriterijumStarateljBtn.Visible = true;
                    PromeniIdLbl.Text = "0";
                    UcitajOdgovorneStaratelje();
                    UcitajDecu(false);
                    break;
            }
            trenutniSK = sk;
            if (SK.PROMENI == trenutniSK) OperacijaBtn.Text = "PRETRAGA";
            else
                OperacijaBtn.Text = trenutniSK.ToString();
            OperacijaLbl.Text = trenutniSK.ToString();

            PromeniPnl.Visible = (SK.PROMENI == trenutniSK);
        }

        private void OperacijaBtn_Click(object sender, EventArgs e)
        {
            IzvrsiSK(trenutniSK);
        }

        private void PretragaPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.OBRISI);
        }

        private void PretragaBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.PRETRAGA);
        }

        private void PromeniBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.PROMENI);
        }

        private void DecaDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void PotvrdiPromeneBtn_Click(object sender, EventArgs e)
        {
            PromeniDete();

            PromeniIdLbl.Text = "0";
            PromeniImeTxt.Text = "";
            PromeniPrezimeTxt.Text = "";
            deteZaPromenu = null;
            UcitajOdgovorneStaratelje();
            UcitajDecu(false);


        }

        private void PromeniDete()
        {
            if (deteZaPromenu == null) { MessageBox.Show("Pomoć - Pokušajte da kliknete red sa leve strane ekrana"); return; }
            Odgovor odg = Konekcija.Instanca.PromeniDete(new() { Id = deteZaPromenu.Id, Ime = PromeniImeTxt.Text, Prezime = PromeniPrezimeTxt.Text, Staratelj = new() { Id = (int)StarateljCmb.SelectedValue } });
            if (odg != null) MessageBox.Show(odg.Poruka);
        }

        private void DecaDgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DecaDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DecaDgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("whoops" + trenutniSK);
            if (trenutniSK != SK.PROMENI || DecaDgv.SelectedRows.Count < 1) { return; }

            deteZaPromenu = (Dete)DecaDgv.SelectedRows[0].DataBoundItem;
            Debug.WriteLine(deteZaPromenu.Ime + deteZaPromenu.Prezime + deteZaPromenu.Id + deteZaPromenu.Staratelj.Id);
            PromeniIdLbl.Text = deteZaPromenu.Id.ToString();
            PromeniImeTxt.Text = deteZaPromenu.Ime;
            PromeniPrezimeTxt.Text = deteZaPromenu.Prezime;
            PromeniStarateljCmb.SelectedItem = deteZaPromenu.Staratelj.Id;
        }
    }
}
