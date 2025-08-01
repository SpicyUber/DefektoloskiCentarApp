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
    public class PretraziEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga : OpstaSistemskaOperacija
    {
        public List<EvidencijaTretmana> Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            try{ EvidencijaTretmana evidencija = new();
            broker.Command.CommandText = $"SELECT {evidencija.ImeTabele()}.* , {evidencija.JoinTabela()}.* , {evidencija.JoinTabela2()}.* FROM {evidencija.ImeTabele()} JOIN {evidencija.JoinTabela()} ON({evidencija.JoinUslov()}) JOIN {evidencija.JoinTabela2()} ON ({evidencija.JoinUslov2()} ) JOIN {evidencija.JoinTabela3()} ON ({evidencija.JoinUslov3()} ) WHERE {odo.WhereUslov()} ";
            Debug.WriteLine(broker.Command.CommandText);
            SqlDataReader citac = broker.Command.ExecuteReader();
            Rezultat = VratiUnikatneEvidencijeTretmana(evidencija.VratiListu(citac, true).Cast<EvidencijaTretmana>().ToList());
            broker.Command.Dispose();
        }catch(Exception ex) { broker.Command.Dispose(); throw ex; }
}

        private List<EvidencijaTretmana> VratiUnikatneEvidencijeTretmana(List<EvidencijaTretmana> staraLista)
        {
             

            return staraLista.GroupBy(a => a.Id).Select(g => g.First()).OfType<EvidencijaTretmana>().ToList(); 

            


        }
    }
}
