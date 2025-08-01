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
    public class PretraziEvidencijaTretmana : OpstaSistemskaOperacija
    {
       public List<EvidencijaTretmana> Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            try { 
            EvidencijaTretmana evidencija = (EvidencijaTretmana)odo;
            broker.Command.CommandText = $"SELECT {evidencija.SelectVrednosti()} FROM {evidencija.ImeTabele()} JOIN {evidencija.JoinTabela()} ON({evidencija.JoinUslov()}) JOIN {evidencija.JoinTabela2()} ON ({evidencija.JoinUslov2()} ) WHERE "+evidencija.WhereUslov();
            Debug.WriteLine(broker.Command.CommandText);    
            SqlDataReader citac = broker.Command.ExecuteReader();
            Rezultat = odo.VratiListu(citac,true).Cast<EvidencijaTretmana>().ToList();
                broker.Command.Dispose();
            }catch(Exception ex) { broker.Command.Dispose(); throw ex; }
        }
    }
}
