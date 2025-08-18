using Domen;
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
    public partial class StavkeEvidencijeTretmanaFrm : Form
    {

        BindingList<StavkaEvidencijeTretmana> stavke;
        BindingList<DefektoloskaUsluga> usluga;
        EvidencijaTretmana prvobitnaEvidencija;
        int idEvidencije;

        public StavkeEvidencijeTretmanaFrm(EvidencijaTretmana et, BindingList<DefektoloskaUsluga> usluga, bool promena)
        {


            InitializeComponent();
            if(!promena)StavkeDgv.Dock = DockStyle.Fill; 
            idEvidencije = et.Id;
            this.Text = $"Stavke Evidencije Tretmana (Evidencija Br {idEvidencije})";
            this.usluga = usluga;
            UslugaCmb.DataSource = usluga;
            UslugaCmb.ValueMember = "Id";
            UslugaCmb.DisplayMember = "CmbValue";
            
            prvobitnaEvidencija = et;
            this.stavke = new BindingList<StavkaEvidencijeTretmana>(et.StavkeEvidencijeTretmana);
            StavkeDgv.DataSource = this.stavke;
            PromeniPnl.Visible = promena;
        }

        private void StavkeEvidencijeTretmanaFrm_Load(object sender, EventArgs e)
        {

        }

        private void StavkeEvidencijeTretmanaFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            prvobitnaEvidencija.StavkeEvidencijeTretmana = new List<StavkaEvidencijeTretmana>(stavke);
        }

        private void StavkeDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DodajBtn_Click(object sender, EventArgs e)
        {
            stavke.Add(new StavkaEvidencijeTretmana() { Usluga = UslugaCmb.SelectedItem as DefektoloskaUsluga, Rb = stavke.Count + 1, IdEvidencije = idEvidencije });
        }

        private void IzbaciCmb_Click(object sender, EventArgs e)
        {
            stavke.RemoveAt(stavke.Count - 1);
        }
    }
}
