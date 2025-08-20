using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ObrisiDete : OpstaSistemskaOperacija
    {
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {

            broker.Obrisi(odo);
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            // return (odo.GetType() == typeof(Dete) && ((Dete)odo).Ime.Length<=30 && ((Dete)odo).Prezime.Length <= 30 && ((Dete)odo).Id>-1 && (((Dete)odo).Staratelj == null || ((Dete)odo).Staratelj.Id > 0) && (((Dete)odo).Staratelj == null || ((Dete)odo).Staratelj.Ime.Length <= 30)) ;
            return (odo is Dete && ((Dete)odo).Id>0);
        }
    }
}
