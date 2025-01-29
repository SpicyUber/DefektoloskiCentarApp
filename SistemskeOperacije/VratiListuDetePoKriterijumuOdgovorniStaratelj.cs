using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuDetePoKriterijumuOdgovorniStaratelj : OpstaSistemskaOperacija
    {
        public List<Dete> Rezultat {get; set;}

        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            Rezultat = broker.VratiSveSaUslovom(odo).Cast<Dete>().ToList();
        }
    }
}
