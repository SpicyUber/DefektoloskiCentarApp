using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuSviDefektoloskaUsluga : OpstaSistemskaOperacija
    {
        public List<DefektoloskaUsluga> Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            Rezultat= broker.VratiSve(odo).Cast<DefektoloskaUsluga>().ToList();
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            return (odo is DefektoloskaUsluga);
        }
    }
}
