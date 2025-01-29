using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuSviSpecijalizacija : OpstaSistemskaOperacija
    {
       public List<Specijalizacija> Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            Rezultat = broker.VratiSve(odo).Cast<Specijalizacija>().ToList();
        }
    }
}
