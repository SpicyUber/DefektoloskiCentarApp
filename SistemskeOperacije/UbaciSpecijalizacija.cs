using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class UbaciSpecijalizacija : OpstaSistemskaOperacija
    {
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
           broker.Ubaci(odo);
             
        }
    }
}
