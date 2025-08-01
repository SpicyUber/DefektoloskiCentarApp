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
        BindingList<Domen.Dete> deca;
        private SK trenutniSK;
        private Domen.Dete deteZaPromenu = null;

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
            HelpBtn.Visible = false;
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
            Odgovor odg = Konekcija.Instanca.PretraziDete(new Domen.Dete());
            if (odg != null && obavesti) MessageBox.Show(odg.Poruka);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null) { deca = new BindingList<Domen.Dete>((List<Domen.Dete>)odg.Objekat); }
            DecaDgv.DataSource = null;

            DecaDgv.DataSource = deca;
            DecaDgv.Columns["CmbValue"].Visible = false;
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



                    break;
                case SK.PROMENI:
                    Pretraga();

                    break;
            }
        }

        private void Obrisi()
        {
            if (deca.Count == 0) { return; }
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
            Domen.Dete dete;
            try { dete = new() { Ime = ImeTxt.Text, Prezime = PrezimeTxt.Text, Staratelj = new() { Id = (int)StarateljCmb.SelectedValue } }; } catch (Exception ex) { MessageBox.Show("Sistem ne može kreirati dete!"); return; }

            Odgovor odg;
            odg = Konekcija.Instanca.KreirajDete(dete);

            if (odg != null) MessageBox.Show(odg.Poruka);
            if (odg == null || odg.Objekat == null) return;
            PromeniOperaciju(SK.PROMENI);
            deteZaPromenu = (Dete)odg.Objekat;
            Debug.WriteLine(deteZaPromenu.Ime + deteZaPromenu.Prezime + deteZaPromenu.Id + deteZaPromenu.Staratelj.Id);
            PromeniIdLbl.Text = deteZaPromenu.Id.ToString();
            PromeniImeTxt.Text = "";
            PromeniPrezimeTxt.Text = "";


        }

        private void Pretraga()
        {
            Odgovor odg;
            if (DecaKriterijumBtn.Checked)
            {
                odg = Konekcija.Instanca.PretraziDete(new Domen.Dete() { Id = 0, Ime = ImeTxt.Text, Prezime = PrezimeTxt.Text });
            }
            else
            {
                odg = Konekcija.Instanca.VratiListuDetePoKriterijumuOdgovorniStaratelj(new() { Id = (int)StarateljCmb.SelectedValue });
            }
            if (odg != null) MessageBox.Show(odg.Poruka);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null) { deca = new BindingList<Domen.Dete>((List<Domen.Dete>)odg.Objekat); }
            DecaDgv.DataSource = null;
            DecaDgv.DataSource = deca;
            DecaDgv.Columns["CmbValue"].Visible = false;
        }

        private void KreirajBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.KREIRAJ);
        }

        private void PromeniOperaciju(SK sk)
        {
            HelpBtn.Visible = (sk == SK.PROMENI);
            PotvrdiBrisanjeBtn.Visible = (sk == SK.OBRISI);
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
                    DecaKriterijumBtn.Checked = true;
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



            OperacijaLbl.Text = sk.ToString();
            if (SK.PROMENI == sk || SK.OBRISI == sk) OperacijaBtn.Text = "PRETRAGA";
            else
                OperacijaBtn.Text = sk.ToString();
            if (trenutniSK == SK.KREIRAJ && sk == SK.PROMENI)
            {

                OperacijaBtn.Visible = false;
                HelpBtn.Visible = false; StarateljCmb.Visible = label1.Visible = label2.Visible = label4.Visible = KriterijumStarateljBtn.Visible = DecaKriterijumBtn.Visible = ImeTxt.Visible = PrezimeTxt.Visible = false;
                OperacijaLbl.Text = "KREIRAJ";

            }
            else
            {
                OperacijaBtn.Visible = true;
                StarateljCmb.Visible = label1.Visible = label2.Visible = label4.Visible = KriterijumStarateljBtn.Visible = DecaKriterijumBtn.Visible = ImeTxt.Visible = PrezimeTxt.Visible = true;


            }

            trenutniSK = sk;
            PromeniPnl.Visible = (SK.PROMENI == trenutniSK);
            if (trenutniSK == SK.KREIRAJ) { IzvrsiSK(trenutniSK); }
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
            if (OperacijaLbl.Text == "KREIRAJ") PromeniOperaciju(SK.PRETRAGA);
        }

        private void DecaDgv_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DecaDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DecaDgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (OperacijaLbl.Text == "KREIRAJ") return;
            Odgovor odg;
            if (DecaDgv.SelectedRows.Count > 0 && trenutniSK != SK.PROMENI)
            {
                odg = Konekcija.Instanca.PretraziDete((Domen.Dete)DecaDgv.SelectedRows[0].DataBoundItem);


                if (odg != null && odg.Uspeh == true && odg.Objekat != null && ((List<Dete>)odg.Objekat).Count > 0) { deca = new BindingList<Domen.Dete>((List<Domen.Dete>)odg.Objekat); MessageBox.Show("Sistem je našao dete"); }
                else
                    MessageBox.Show("Sistem ne može da nađe dete");
                DecaDgv.DataSource = null;
                DecaDgv.DataSource = deca;
                DecaDgv.Columns["CmbValue"].Visible = false;
                return;
            }


            if (trenutniSK != SK.PROMENI || DecaDgv.SelectedRows.Count < 1) { return; }

            deteZaPromenu = (Domen.Dete)DecaDgv.SelectedRows[0].DataBoundItem;
            odg = Konekcija.Instanca.PretraziDete((Domen.Dete)DecaDgv.SelectedRows[0].DataBoundItem);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null && ((List<Dete>)odg.Objekat).Count > 0) { deca = new BindingList<Domen.Dete>((List<Domen.Dete>)odg.Objekat); MessageBox.Show("Sistem je našao dete"); }
            else
                MessageBox.Show("Sistem ne može da nađe dete");
            Debug.WriteLine(deteZaPromenu.Ime + deteZaPromenu.Prezime + deteZaPromenu.Id + deteZaPromenu.Staratelj.Id);
            PromeniIdLbl.Text = deteZaPromenu.Id.ToString();
            PromeniImeTxt.Text = deteZaPromenu.Ime;
            PromeniPrezimeTxt.Text = deteZaPromenu.Prezime;
            PromeniStarateljCmb.SelectedItem = deteZaPromenu.Staratelj.Id;
        }

        private void DecaDgv_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KriterijumStarateljBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klikni na rezultat pretrage koji želis da promeniš, izmeni ga u donjem desnom uglu prozora, potom potvrdi promene.", "Pomoć", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PotvrdiBrisanjeBtn_Click(object sender, EventArgs e)
        {
            if (deca == null || deca.Count == 0) { return; }
            DialogResult dg = MessageBox.Show("Da li želite da obrišete PRVO pronađeno dete na listi?", "Obriši Dete", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
                Obrisi();
        }
    }
}
