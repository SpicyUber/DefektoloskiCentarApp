using Domen;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PromeniDete : OpstaSistemskaOperacija
    {
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            broker.Promeni(odo);
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            return (odo is Dete && ((Dete)odo).Ime!=null && ((Dete)odo).Prezime != null && ((Dete)odo).Ime.Length <= 30 && ((Dete)odo).Prezime.Length <= 30 && ((Dete)odo).Id > 0 && ((Dete)odo).Staratelj.Id > 0);

        }
    }
}
