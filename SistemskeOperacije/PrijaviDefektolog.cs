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
        public bool Rezultat { get; set; }
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            Rezultat=(broker.VratiSveSaUslovom(odo).Count>0);

        }
    }
}
