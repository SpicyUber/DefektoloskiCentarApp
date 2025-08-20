using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PretraziDefektolog : OpstaSistemskaOperacija
    {
        public Defektolog? Rezultat = null;
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            List<Defektolog> lista = broker.VratiSveSaUslovom(odo).Cast<Defektolog>().ToList();
            if(lista == null || lista.Count==0) { throw new Exception("Defektolog ne postoji."); } else { Rezultat = lista[0]; }
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            return odo is Defektolog;
        }
    }
}
