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
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            try
            {
                EvidencijaTretmana evidencija = (EvidencijaTretmana)odo;
                evidencija.Id = broker.Kreiraj(odo);
            }
            catch (Exception ex) { throw new Exception("Sistem ne može da kreira evidenciju tretmana."); }
            try
            {
                broker.Promeni(odo);
            }
            catch (Exception ex)
            {
                throw new Exception("Sistem ne može da zapamti evidenciju tretmana.");
            }
        }
    }
}
