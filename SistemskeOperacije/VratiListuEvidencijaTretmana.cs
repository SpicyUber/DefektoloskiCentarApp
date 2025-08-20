using Domen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuEvidencijaTretmana : OpstaSistemskaOperacija
    {
       public List<EvidencijaTretmana> Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            try { 
            EvidencijaTretmana evidencija = (EvidencijaTretmana)odo;
            broker.Command.CommandText = $"SELECT {evidencija.SelectVrednosti()} FROM {evidencija.ImeTabele()} JOIN {evidencija.JoinTabela()} ON({evidencija.JoinUslov()}) JOIN {evidencija.JoinTabela2()} ON ({evidencija.JoinUslov2()} ) WHERE "+evidencija.WhereUslov() + " ORDER BY "+ evidencija.OrderUslov();
            Debug.WriteLine(broker.Command.CommandText);    
            SqlDataReader citac = broker.Command.ExecuteReader();
            Rezultat = odo.VratiListu(citac,true).Cast<EvidencijaTretmana>().ToList();
                if (Rezultat.Count != 0)
                    foreach (EvidencijaTretmana et in Rezultat)
                    {

                       
                       
                        et.StavkeEvidencijeTretmana = broker.VratiSveSaUslovom(new StavkaEvidencijeTretmana() { IdEvidencije = et.Id }).Cast<StavkaEvidencijeTretmana>().ToList();



                    }
                if (Rezultat == null || Rezultat.Count == 0) { Rezultat = null; throw new Exception(); };
                broker.Command.Dispose();
            }catch(Exception ex) { broker.Command.Dispose(); throw ex; }
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {

            if (!(odo is EvidencijaTretmana)) return false;

            bool temp = false;

            EvidencijaTretmana et = (EvidencijaTretmana)odo;

            temp = ( et.VremePocetkaTretmanaUCasovima < 25 && et.DatumTretmana!=null ) ;

            return temp;
        }
    }
}
