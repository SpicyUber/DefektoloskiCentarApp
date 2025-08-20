using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PromeniEvidencijaTretmana : OpstaSistemskaOperacija
    {
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            broker.Promeni(odo);
            List<StavkaEvidencijeTretmana> stavke = ((EvidencijaTretmana)odo).StavkeEvidencijeTretmana;
            if(broker.VratiSveSaUslovom(new StavkaEvidencijeTretmana() { IdEvidencije = ((EvidencijaTretmana)odo).Id }).Count>0)
            broker.Obrisi(new StavkaEvidencijeTretmana() { IdEvidencije = ((EvidencijaTretmana)odo).Id });
            if (stavke != null)
            foreach(StavkaEvidencijeTretmana stavka in stavke)
            {
                
                    broker.Ubaci(stavka);
                

            }
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            try
            {
                if (!(odo is EvidencijaTretmana)) return false;

                bool temp = false;

                EvidencijaTretmana et = (EvidencijaTretmana)odo;

                temp = (et.Id > 0 && et.VremePocetkaTretmanaUCasovima < 25 && et.VremePocetkaTretmanaUCasovima > 0);
                if (temp == false) return false;

                if (et.StavkeEvidencijeTretmana != null)
                    foreach (StavkaEvidencijeTretmana set in et.StavkeEvidencijeTretmana)
                    {
                        if (set.Rb <= 0 || set.Usluga == null || set.Usluga.Id < 1 || set.Usluga.CenaUDinarima == 0) return false;
                    }

                EvidencijaTretmana evidencija = (EvidencijaTretmana)odo;
                broker.Command.CommandText = $"SELECT {evidencija.SelectVrednosti()} FROM {evidencija.ImeTabele()} JOIN {evidencija.JoinTabela()} ON({evidencija.JoinUslov()}) JOIN {evidencija.JoinTabela2()} ON ({evidencija.JoinUslov2()} ) WHERE " + evidencija.WhereUslov() + " ORDER BY " + evidencija.OrderUslov();
                Debug.WriteLine(broker.Command.CommandText);
                SqlDataReader citac = broker.Command.ExecuteReader();
                List<EvidencijaTretmana> list = new EvidencijaTretmana() { Id = et.Id }.VratiListu(citac, true).Cast<EvidencijaTretmana>().ToList();
                if (list == null || list.Count == 0) return false;
                if (list[0].EvidencijaJeStornirana != null && list[0].EvidencijaJeStornirana == true) return false;
                if (list[0].TretmanJePlacen != null && list[0].TretmanJePlacen == false)
                    return true;
                else if (et.VremePocetkaTretmanaUCasovima != list[0].VremePocetkaTretmanaUCasovima || et.DatumTretmana.Date != list[0].DatumTretmana.Date || et.TretmanJePlacen != list[0].TretmanJePlacen || !UporediStavke(et.StavkeEvidencijeTretmana, broker.VratiSveSaUslovom(new StavkaEvidencijeTretmana() { IdEvidencije = et.Id }).Cast<StavkaEvidencijeTretmana>().ToList())) return false;
            return true;
            }
            catch (Exception e) { return false; }
        }
        private bool UporediStavke(List<StavkaEvidencijeTretmana> s1,List<StavkaEvidencijeTretmana> s2)
        {
            if(s1 == null && s2 == null) return true;
            if(s1==null && s2!=null) return false;
            if(s1!=null && s2==null) return false;
            if(s1.Count!=s2.Count) return false;

            for(int i =0; i < s1.Count; i++)
            {
                if (s1[i].Usluga.Id != s2[i].Usluga.Id) return false;
            }

            return true;
        }
    }



}
