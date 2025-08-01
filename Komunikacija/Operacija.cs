using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komunikacija
{
    public enum Operacija
    {
        KreirajDefektolog,
        PretraziDete,
        PrijaviDefektolog,
        VratiListuDetePoKriterijumuOdgovorniStaratelj,
        VratiListuSviOdgovorniStaratelj,
        KreirajDete,
        ObrisiDete,
        PromeniDete,
        UbaciSpecijalizacija,
        VratiListuSviSpecijalizacija,
        PretraziEvidencijaTretmana,
        VratiListuSviDefektolog,
        VratiListuSviDefektoloskaUsluga,
        OdjaviDefektolog,
        VratiListuEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga,
        VratiListuEvidencijaTretmanaPoKriterijumuDete,
        VratiListuEvidencijaTretmanaPoKriterijumuDefektolog,
        KreirajEvidencijaTretmana,
        PromeniEvidencijaTretmana
    }
}
