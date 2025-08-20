using Baza;
using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PrijaviDefektolog : OpstaSistemskaOperacija
    {
        
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            if(broker.VratiSveSaUslovom(odo).Count<=0)throw new Exception("Nije pronadjen nijedan defektolog sa tim podacima.");

        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            return (odo is Defektolog && ((Defektolog)odo).KorisnickoIme!=null && ((Defektolog)odo).Sifra!=null && ((Defektolog)odo).Sifra.Length<=30 && ((Defektolog)odo).KorisnickoIme.Length <= 30 );
        }
    }
}
