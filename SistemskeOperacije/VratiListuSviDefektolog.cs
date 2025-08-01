using Domen;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiListuSviDefektolog : OpstaSistemskaOperacija
    {
        public List<Defektolog> Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
          Rezultat = broker.VratiSve(odo).Cast<Defektolog>().ToList();
            
        }
    }
}
