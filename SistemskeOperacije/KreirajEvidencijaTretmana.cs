using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class KreirajEvidencijaTretmana : OpstaSistemskaOperacija
    {
        public EvidencijaTretmana Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            try
            {
                EvidencijaTretmana evidencija = new();
                evidencija.Id = broker.Kreiraj(odo);
               Rezultat = evidencija;
                 
            }
            catch (Exception ex) { throw new Exception("Sistem ne može da kreira evidenciju tretmana."); }
          
        }
    }
}
