using Domen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PretraziDete : OpstaSistemskaOperacija
    {
      public List<Dete>? Rezultat { get;set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
           Rezultat= broker.VratiSveSaUslovom(odo ).Cast<Dete>().ToList() ;
            if (Rezultat == null || Rezultat.Count == 0) { Rezultat = null; throw new Exception("Rezultat pretrage dece je prazan."); }
        ;
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            return (odo is Dete  && ((Dete)odo).Id > -1 && (((Dete)odo).Staratelj == null || ((Dete)odo).Staratelj.Id > 0) );

        }
    }
}
