using Domen;
using System;
using System.Collections.Generic;
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
            foreach(StavkaEvidencijeTretmana stavka in stavke)
            {
                
                    broker.Ubaci(stavka);
                

            }
        }
    }
}
