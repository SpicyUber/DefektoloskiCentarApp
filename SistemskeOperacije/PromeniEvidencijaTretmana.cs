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
        }
    }
}
