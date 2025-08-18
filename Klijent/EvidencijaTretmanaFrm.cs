using Domen;
using Komunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class EvidencijaTretmanaFrm : Form
    {
        BindingList<EvidencijaTretmana> evidencije;
        BindingList<DefektoloskaUsluga> usluge;
        BindingList<Domen.Dete> deca;
        BindingList<Defektolog> defektolozi;
        SK trenutniSK = SK.PRETRAGA;
        Kriterijum trenutniKriterijum = Kriterijum.Evidencija;
        private enum Kriterijum { Evidencija, Dete, Defektolog, Usluga }
        private enum SK { KREIRAJ, PRETRAGA, PROMENI }

        private int promenaIdCache = -1;
        private EvidencijaTretmana promenaObjekatCache;

        public EvidencijaTretmanaFrm()
        {
            trenutniSK = SK.PRETRAGA;
            trenutniKriterijum = Kriterijum.Evidencija;
            InitializeComponent();
            VratiSveEvidencije(true);
            UcitajDecu();
            UcitajDefektologe();
            UcitajUsluge();
            DeteCmb.DisplayMember = "CmbValue";
            UslugaCmb.DisplayMember = "CmbValue";
            DefektologCmb.DisplayMember = "CmbValue";
            DeteCmb.ValueMember = "Id";
            UslugaCmb.ValueMember = "Id";
            DefektologCmb.ValueMember = "Id";
            EvidencijaBtn.Checked = true;
        }

        private void PromeniOperaciju(SK noviSK)
        {
            switch (noviSK)
            {
                case SK.PRETRAGA:
                    EvidencijaBtn.Enabled = true;
                    DefektologBtn.Enabled = true;
                    DeteBtn.Enabled = true;
                    EvidencijaBtn.Visible = true;
                    DefektologBtn.Visible = true;
                    DeteBtn.Visible = true;
                    UslugaBtn.Enabled = true;
                    UslugaBtn.Visible = true;
                    DatumPicker.Enabled = true;
                    StorniranCmb.Enabled = true;
                    PlacenaCmb.Enabled = true;
                    DatumDefaultCb.Enabled = true;
                    DatumDefaultCb.Visible = true;
                    EvidencijaBtn.Checked = true;
                    label6.Visible = false;
                    EvidencijaBtn_CheckedChanged(null, null);
                    OpisLbl.Text = "PRETAŽI PO KRITERIJUMU:";

                    break;
                case SK.KREIRAJ:
                    EvidencijaBtn.Enabled = true;
                    EvidencijaBtn_CheckedChanged(null, null);
                    EvidencijaBtn.Enabled = false;
                    DefektologBtn.Enabled = false;
                    DeteBtn.Enabled = false;
                    EvidencijaBtn.Visible = false;
                    DefektologBtn.Visible = false;
                    DeteBtn.Visible = false;
                    UslugaBtn.Enabled = false;
                    UslugaBtn.Visible = false;
                    DatumDefaultCb.Enabled = false;
                    DatumDefaultCb.Visible = false;
                    DatumPicker.Enabled = true;
                    StorniranCmb.Enabled = true;
                    PlacenaCmb.Enabled = true;
                    DefektologCmb.Enabled = true;
                    UslugaCmb.Enabled = false;
                    DeteCmb.Enabled = true;
                    label6.Visible = true;
                    VremePocetkaTxt.Enabled = true;
                    OpisLbl.Text = "KREIRAJ EVIDENCIJU TRETMANA:";


                    break;
                case SK.PROMENI:
                    EvidencijaBtn.Enabled = true;
                    EvidencijaBtn_CheckedChanged(null, null);
                    EvidencijaBtn.Enabled = false;
                    EvidencijaBtn.Enabled = false;
                    DefektologBtn.Enabled = false;
                    DeteBtn.Enabled = false;
                    EvidencijaBtn.Visible = false;
                    DefektologBtn.Visible = false;
                    DatumPicker.Enabled = true;
                    DeteBtn.Visible = false;
                    UslugaBtn.Enabled = false;
                    UslugaBtn.Visible = false;
                    DatumDefaultCb.Enabled = false;
                    DatumDefaultCb.Visible = false;
                    DefektologCmb.Enabled = true;
                    UslugaCmb.Enabled = false;
                    DeteCmb.Enabled = true;
                    DatumPicker.Enabled = true;
                    StorniranCmb.Enabled = true;
                    PlacenaCmb.Enabled = true;
                    OpisLbl.Text = "KLIKNI NA EVIDENCIJU IZ LISTE KOJU ŽELIŠ DA IZMENIŠ.";
                    label6.Text = "";
                    DatumPicker.Value = DateTime.Now;
                    StorniranCmb.SelectedIndex = -1;

                    PlacenaCmb.SelectedIndex = -1;
                    UkupnaCenaTxt.Text = "";
                    VremePocetkaTxt.Text = "";

                    label6.Visible = false;
                    break;

            }

            trenutniSK = noviSK;
            OperacijaBtn.Text = trenutniSK.ToString();
            OperacijaLbl.Text = trenutniSK.ToString();
            UkupnaCenaTxt.Enabled = (trenutniSK == SK.PRETRAGA);
            UkupnaCenaTxt.Visible = (trenutniSK == SK.PRETRAGA);
            UkupnaCenaLbl.Visible = (trenutniSK == SK.PRETRAGA);
            UslugaLbl.Visible = (trenutniSK == SK.PRETRAGA);
            UslugaCmb.Visible = (trenutniSK == SK.PRETRAGA);
            OperacijaBtn.Enabled = (trenutniSK != SK.PROMENI);
            if (trenutniSK == SK.KREIRAJ) Kreiraj();
        }

        private void IzvrsiOperaciju()
        {
            switch (trenutniSK)
            {
                case SK.PRETRAGA:
                    Pretrazi();
                    break;
                case SK.KREIRAJ:
                    Promeni();
                    break;
                case SK.PROMENI:
                    Promeni();
                    break;
            }

        }

        private void Promeni()
        {
            if (!ValidacijaVrednosti()) return;
            Odgovor odg = Konekcija.Instanca.PromeniEvidencijaTretmana(new EvidencijaTretmana() { Id = promenaIdCache, DatumTretmana = DatumPicker.Value, VremePocetkaTretmanaUCasovima = Convert.ToInt32(VremePocetkaTxt.Text), EvidencijaJeStornirana = VratiNullBullVrednost(StorniranCmb), TretmanJePlacen = VratiNullBullVrednost(PlacenaCmb), Defektolog = new() { Id = Convert.ToInt32(DefektologCmb.SelectedValue) }, Dete = new() { Id = Convert.ToInt32(DeteCmb.SelectedValue) }, StavkeEvidencijeTretmana = (promenaObjekatCache == null) ? new List<StavkaEvidencijeTretmana>() : promenaObjekatCache.StavkeEvidencijeTretmana });
            if (odg != null) { MessageBox.Show(odg.Poruka); }
            if (odg != null && odg.Uspeh) { VratiSveEvidencije(false); }
            PromeniOperaciju(SK.PRETRAGA);
        }

        private void Kreiraj()
        {



            Odgovor odg = Konekcija.Instanca.KreirajEvidencijaTretmana(new EvidencijaTretmana() { Defektolog = new(), Dete = new() });
            if (odg != null) { MessageBox.Show(odg.Poruka); if (!odg.Uspeh) { PromeniOperaciju(SK.PRETRAGA); return; } }
            if (odg.Objekat != null)
            {
                EvidencijaTretmana et = (EvidencijaTretmana)(odg.Objekat);
                promenaObjekatCache = et;
                label6.Text = $"Id:{et.Id}";
                promenaIdCache = et.Id; OpisLbl.Text = "UKUCAJ ŽELJENE VREDNOSTI:";
            }

        }

        private bool ValidacijaVrednosti()
        {
            if (VratiNullBullVrednost(StorniranCmb) == null) { MessageBox.Show($"Odgovor na ''Stornirana?'' mora biti ''DA'' ili ''NE''."); return false; }
            if (VratiNullBullVrednost(PlacenaCmb) == null) { MessageBox.Show($"Odgovor na ''Plaćena?'' mora biti ''DA'' ili ''NE''."); return false; }
            try { Convert.ToInt32(VremePocetkaTxt.Text); } catch (Exception ex) { MessageBox.Show($"Vreme tretmana mora biti u celobrojnom opsegu [1-24]."); return false; }

            return true;
        }

        private void Pretrazi()
        {
            Odgovor odg = null;
            switch (trenutniKriterijum)
            {
                case Kriterijum.Evidencija:
                    odg = Konekcija.Instanca.PretraziEvidencijaTretmana(
                       new EvidencijaTretmana() { DatumTretmana = (DatumDefaultCb.Checked ? DateTime.MinValue : DatumPicker.Value), EvidencijaJeStornirana = VratiNullBullVrednost(StorniranCmb), TretmanJePlacen = VratiNullBullVrednost(PlacenaCmb), VremePocetkaTretmanaUCasovima = (VremePocetkaTxt.Text.Equals("") ? 0 : int.Parse(VremePocetkaTxt.Text)), UkupnaCenaUDinarima = (UkupnaCenaTxt.Text.Equals("") ? -1 : int.Parse(UkupnaCenaTxt.Text)), Dete = new(), Defektolog = new() });

                    break;
                case Kriterijum.Usluga:
                    odg = Konekcija.Instanca.VratiListuEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga(new DefektoloskaUsluga() { Id = Convert.ToInt32(UslugaCmb.SelectedValue) });
                    break;
                case Kriterijum.Dete:
                    odg = Konekcija.Instanca.VratiListuEvidencijaTretmanaPoKriterijumuDete(
                       new Domen.Dete() { Id = (int)DeteCmb.SelectedValue });

                    break;
                case Kriterijum.Defektolog:
                    odg = Konekcija.Instanca.VratiListuEvidencijaTretmanaPoKriterijumuDefektolog(
                      new Defektolog() { Id = (int)DefektologCmb.SelectedValue });

                    break;

            }
            if (odg != null) MessageBox.Show(odg.Poruka);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null) { evidencije = new BindingList<EvidencijaTretmana>((List<EvidencijaTretmana>)odg.Objekat); }
            EvidencijaTretmanaDgv.DataSource = null;

            EvidencijaTretmanaDgv.DataSource = evidencije;

        }

        private bool? VratiNullBullVrednost(ComboBox cmb)
        {
            if (cmb.Text.Equals("DA")) return true;
            else if (cmb.Text.Equals("NE")) return false;
            else return null;
        }

        private void UcitajDecu()
        {
            Odgovor odg = Konekcija.Instanca.PretraziDete(new Domen.Dete());
            if (odg != null && odg.Objekat != null)
                deca = new BindingList<Domen.Dete>((List<Domen.Dete>)odg.Objekat);
            else deca = new BindingList<Domen.Dete>();
            DeteCmb.DataSource = null;
            DeteCmb.DataSource = deca;
        }

        private void UcitajDefektologe()
        {
            Odgovor odg = Konekcija.Instanca.VratiListuSviDefektolog();
            if (odg != null && odg.Objekat != null)
            {
                Debug.WriteLine("1");
                defektolozi = new BindingList<Defektolog>((List<Defektolog>)odg.Objekat);
            }
            else { defektolozi = new BindingList<Defektolog>(); Debug.WriteLine("2"); }
            DefektologCmb.DataSource = null;
            DefektologCmb.DataSource = defektolozi;

        }

        private void UcitajUsluge()
        {
            Odgovor odg = Konekcija.Instanca.VratiListuSviDefektoloskaUsluga();
            if (odg != null && odg.Objekat != null)
                usluge = new BindingList<DefektoloskaUsluga>((List<DefektoloskaUsluga>)odg.Objekat);
            else usluge = new BindingList<DefektoloskaUsluga>();

            UslugaCmb.DataSource = null;
            UslugaCmb.DataSource = usluge;

        }



        private void VratiSveEvidencije(bool obavesti)
        {
            Odgovor odg = Konekcija.Instanca.PretraziEvidencijaTretmana(new EvidencijaTretmana());
            if (odg != null && obavesti) MessageBox.Show(odg.Poruka);
            if (odg != null && odg.Uspeh == true && odg.Objekat != null) { evidencije = new BindingList<EvidencijaTretmana>((List<EvidencijaTretmana>)odg.Objekat); }
            EvidencijaTretmanaDgv.DataSource = null;
            EvidencijaTretmanaDgv.DataSource = evidencije;

        }

        private void EvidencijaTretmanaFrm_Load(object sender, EventArgs e)
        {

        }

        private void UslugaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DefektologCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DeteCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PlacenaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UkupnaCenaTxt_TextChanged(object sender, EventArgs e)
        {
            try { UkupnaCenaTxt.Text = Math.Abs(int.Parse(UkupnaCenaTxt.Text)).ToString(); }
            catch (Exception ex)
            {
                UkupnaCenaTxt.Text = "";
            }
        }

        private void VremePocetkaTxt_TextChanged(object sender, EventArgs e)
        {
            try { if (int.Parse(VremePocetkaTxt.Text) < 1 || int.Parse(VremePocetkaTxt.Text) > 24) VremePocetkaTxt.Text = ""; }
            catch (Exception ex)
            {
                VremePocetkaTxt.Text = "";
            }
        }

        private void OperacijaBtn_Click(object sender, EventArgs e)
        {
            IzvrsiOperaciju();
        }

        private void KreirajBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.KREIRAJ);
        }

        private void EvidencijaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (EvidencijaBtn.Checked)
            {
                DatumPicker.Enabled = true;
                DatumDefaultCb.Checked = false;
                UkupnaCenaTxt.Enabled = true;
                VremePocetkaTxt.Enabled = true;
                StorniranCmb.Enabled = true;
                PlacenaCmb.Enabled = true;
                UslugaCmb.Enabled = false;
                DefektologCmb.Enabled = false;
                UslugaCmb.Enabled = false;
                DeteCmb.Enabled = false;

                trenutniKriterijum = Kriterijum.Evidencija;
            }

        }

        private void UslugaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (UslugaBtn.Checked)
            {
                DatumPicker.Enabled = false;
                DatumDefaultCb.Checked = true;
                UkupnaCenaTxt.Enabled = false;
                VremePocetkaTxt.Enabled = false;
                StorniranCmb.Enabled = false;
                PlacenaCmb.Enabled = false;
                DefektologCmb.Enabled = false;
                UslugaCmb.Enabled = true;
                DeteCmb.Enabled = false;
                trenutniKriterijum = Kriterijum.Usluga;
            }
        }

        private void DefektologBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DefektologBtn.Checked)
            {
                DatumPicker.Enabled = false;
                DatumDefaultCb.Checked = true;
                UkupnaCenaTxt.Enabled = false;
                VremePocetkaTxt.Enabled = false;
                StorniranCmb.Enabled = false;
                PlacenaCmb.Enabled = false;
                DefektologCmb.Enabled = true;
                UslugaCmb.Enabled = false;
                DeteCmb.Enabled = false;
                trenutniKriterijum = Kriterijum.Defektolog;
            }
        }

        private void DeteBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DeteBtn.Checked)
            {
                DatumPicker.Enabled = false;
                DatumDefaultCb.Checked = true;
                UkupnaCenaTxt.Enabled = false;
                VremePocetkaTxt.Enabled = false;
                StorniranCmb.Enabled = false;
                PlacenaCmb.Enabled = false;
                DefektologCmb.Enabled = false;
                UslugaCmb.Enabled = false;
                DeteCmb.Enabled = true;
                trenutniKriterijum = Kriterijum.Dete;
            }
        }

        private void PretragaBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.PRETRAGA);
        }

        private void PromeniBtn_Click(object sender, EventArgs e)
        {
            PromeniOperaciju(SK.PROMENI);
        }

        private void StorniranCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void UslugaLbl_Click(object sender, EventArgs e)
        {

        }

        private void DefektologLbl_Click(object sender, EventArgs e)
        {

        }

        private void EvidencijaTretmanaDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EvidencijaTretmanaDgv.SelectedCells.Count == 0 || (trenutniSK != SK.PROMENI && trenutniSK != SK.PRETRAGA)) { return; }


            EvidencijaTretmana ev = EvidencijaTretmanaDgv.SelectedCells[0].OwningRow.DataBoundItem as EvidencijaTretmana;
            Odgovor o = Konekcija.Instanca.PretraziEvidencijaTretmana(new() { Id = ev.Id });
            if (!o.Uspeh || ((List<EvidencijaTretmana>)o.Objekat).Count == 0) { MessageBox.Show("Sistem ne može da nađe evidenciju tretmana."); }
            else
            {
                MessageBox.Show("Sistem je našao evidenciju tretmana.");
                if (trenutniSK == SK.PROMENI) { AzuriranjeVrednostiPromeni(((List<EvidencijaTretmana>)o.Objekat)[0]); OpisLbl.Text = "UKUCAJ ŽELJENE PROMENE:"; } else { EvidencijaTretmanaDgv.DataSource = null; EvidencijaTretmanaDgv.DataSource = ((List<EvidencijaTretmana>)o.Objekat); }
            }
        }

        private void AzuriranjeVrednostiPromeni(EvidencijaTretmana ed)
        {
            label6.Text = $"Id:{ed.Id}";
            promenaIdCache = ed.Id;
            promenaObjekatCache = ed;
            label6.Visible = true;
            UkupnaCenaTxt.Text = ed.UkupnaCenaUDinarima + "";
            VremePocetkaTxt.Text = ed.VremePocetkaTretmanaUCasovima + "";
            DeteCmb.SelectedValue = ed.Dete.Id;
            DefektologCmb.SelectedValue = ed.Defektolog.Id;
            StorniranCmb.SelectedItem = (ed.EvidencijaJeStornirana.Value ? "DA" : "NE");
            PlacenaCmb.SelectedItem = (ed.TretmanJePlacen.Value ? "DA" : "NE");


            OperacijaBtn.Enabled = true;
        }

        private void EvidencijaTretmanaDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StavkeBtn_Click(object sender, EventArgs e)
        {
            if (EvidencijaTretmanaDgv.SelectedCells.Count == 0 && trenutniSK == SK.PRETRAGA)
            {
                MessageBox.Show("Označite red (evidenciju) u tabeli pre klika na dugme [Stavke]!");
                return;
            }
            EvidencijaTretmana et = null;
            if (SK.PRETRAGA == trenutniSK)
            {
                et = EvidencijaTretmanaDgv.SelectedCells[0].OwningRow.DataBoundItem as EvidencijaTretmana;
            }
            else { et = promenaObjekatCache; }
            if (et != null)
            {
                if (et.StavkeEvidencijeTretmana == null) { et.StavkeEvidencijeTretmana = new(); }
                StavkeEvidencijeTretmanaFrm StavkeFrm = new(et, usluge, trenutniSK != SK.PRETRAGA);
                StavkeFrm.ShowDialog();



            }
            else { MessageBox.Show("Izaberite evidenciju za promenu pre klika na dugme [Stavke]!"); return; }
        }
    }
}
