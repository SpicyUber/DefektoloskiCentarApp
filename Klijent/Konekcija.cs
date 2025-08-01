using Domen;
using Komunikacija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Klijent
{
    public class Konekcija
    {
        private Konekcija() { }
        private static Konekcija instanca = null;
        public string KorisnickoIme = "";

        public string Sifra = "";
        public static Konekcija Instanca {get{if(instanca==null)instanca=new(); return instanca;} }

        private Socket klijent;
        private ObradaZahteva obrada;
        public bool PoveziSaServerom()
        {
            try { 
            if (klijent != null && klijent.Connected) { return true; }

            klijent = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            klijent.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4444));

            obrada = new(klijent);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public Odgovor Prijava(string korisnickoIme, string sifra)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = new Defektolog() { Id = 0, KorisnickoIme = korisnickoIme, Sifra = sifra }, Operacija = Operacija.PrijaviDefektolog });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if (o.Uspeh == true) { KorisnickoIme = korisnickoIme; Sifra = sifra; }
            return o ;
            
        }

        public Odgovor VratiListuDetePoKriterijumuOdgovorniStaratelj(OdgovorniStaratelj staratelj)
        {   
            obrada.PosaljiZahtevServeru(new() { Objekat = staratelj, Operacija = Operacija.VratiListuDetePoKriterijumuOdgovorniStaratelj });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if (o.Objekat != null) { o.Objekat = obrada.VratiObjekatTipa<List<Domen.Dete>>(o.Objekat); }
            return o;
        }

        public Odgovor VratiListuEvidencijaTretmanaPoKriterijumuDete(Domen.Dete dete)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = dete, Operacija = Operacija.VratiListuEvidencijaTretmanaPoKriterijumuDete });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if (o.Objekat != null) { o.Objekat = obrada.VratiObjekatTipa<List<EvidencijaTretmana>>(o.Objekat); }
            return o;
        }

        public Odgovor VratiListuEvidencijaTretmanaPoKriterijumuDefektolog(Defektolog defektolog)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = defektolog, Operacija = Operacija.VratiListuEvidencijaTretmanaPoKriterijumuDefektolog });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if (o.Objekat != null) { o.Objekat = obrada.VratiObjekatTipa<List<EvidencijaTretmana>>(o.Objekat); }
            return o;
        }

        public Odgovor PretraziDete(Domen.Dete dete)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = dete, Operacija = Operacija.PretraziDete });
            Odgovor o= obrada.PrimiOdgovorOdServera();
            if (o.Objekat != null) { o.Objekat = obrada.VratiObjekatTipa<List<Domen.Dete>>(o.Objekat); }
            return o;
        }

        public Odgovor VratiListuSviOdgovorniStaratelj()
        {
            obrada.PosaljiZahtevServeru(new() { Operacija = Operacija.VratiListuSviOdgovorniStaratelj });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if (o.Objekat != null) { o.Objekat = obrada.VratiObjekatTipa<List<OdgovorniStaratelj>>(o.Objekat); }
            return o;
        }

       public Odgovor KreirajDete(Domen.Dete dete)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat=dete, Operacija=Operacija.KreirajDete });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if (o != null && o.Objekat != null) o.Objekat = obrada.VratiObjekatTipa<Dete>(o.Objekat);
            return o;
        }

        public Odgovor ObrisiDete(Domen.Dete dete)
        {
            obrada.PosaljiZahtevServeru(new Zahtev() { Objekat = dete, Operacija = Operacija.ObrisiDete });
            return obrada.PrimiOdgovorOdServera();
        }

        public Odgovor PromeniDete(Domen.Dete dete)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat=dete,Operacija=Operacija.PromeniDete});
            return obrada.PrimiOdgovorOdServera();
        }

        public Odgovor UbaciSpecijalizacija(Specijalizacija specijalizacija)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = specijalizacija, Operacija = Operacija.UbaciSpecijalizacija });
            return obrada.PrimiOdgovorOdServera() ;

        }

        public Odgovor VratiListuSviSpecijalizacija()
        {
            obrada.PosaljiZahtevServeru(new() { Operacija = Operacija.VratiListuSviSpecijalizacija });
            Odgovor o= obrada.PrimiOdgovorOdServera();
            if(o.Uspeh)
            o.Objekat = obrada.VratiObjekatTipa<List<Specijalizacija>>(o.Objekat);
            return o;
        }

        public Odgovor PretraziEvidencijaTretmana( EvidencijaTretmana et)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = et, Operacija = Operacija.PretraziEvidencijaTretmana });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if(o.Uspeh)
                o.Objekat = obrada.VratiObjekatTipa<List<EvidencijaTretmana>>(o.Objekat);
            return o;
        }

        public Odgovor VratiListuSviDefektolog()
        {
            obrada.PosaljiZahtevServeru(new() { Operacija = Operacija.VratiListuSviDefektolog });
             Odgovor o=  obrada.PrimiOdgovorOdServera();
            if (o.Uspeh)
                o.Objekat = obrada.VratiObjekatTipa<List<Defektolog>>(o.Objekat);
            return o;
        }

        public Odgovor VratiListuSviDefektoloskaUsluga()
        {
            obrada.PosaljiZahtevServeru(new() { Operacija = Operacija.VratiListuSviDefektoloskaUsluga });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if (o.Uspeh)
                o.Objekat = obrada.VratiObjekatTipa<List<DefektoloskaUsluga>>(o.Objekat);
            return o;
        }

        public Odgovor Odjava()
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = new Defektolog() { Id = 0, KorisnickoIme = this.KorisnickoIme, Sifra = this.Sifra }, Operacija = Operacija.OdjaviDefektolog });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            
            return o;
        }

        public Odgovor KreirajEvidencijaTretmana(EvidencijaTretmana evidencijaTretmana)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = evidencijaTretmana, Operacija = Operacija.KreirajEvidencijaTretmana });
            Odgovor o = obrada.PrimiOdgovorOdServera();
            if(o!=null && o.Objekat!= null) { o.Objekat = obrada.VratiObjekatTipa<Domen.EvidencijaTretmana>(o.Objekat); }
            return o;
        }

        public Odgovor VratiListuEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga(DefektoloskaUsluga defektoloskaUsluga)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = defektoloskaUsluga, Operacija = Operacija.VratiListuEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga });
            Odgovor o = obrada.PrimiOdgovorOdServera();
           if(o!=null && o.Objekat!=null) o.Objekat = obrada.VratiObjekatTipa<List<Domen.EvidencijaTretmana>>(o.Objekat);
            return o;
        }

        public Odgovor PromeniEvidencijaTretmana(EvidencijaTretmana evidencijaTretmana)
        {
            obrada.PosaljiZahtevServeru(new() { Objekat = evidencijaTretmana, Operacija = Operacija.PromeniEvidencijaTretmana });
            
            Odgovor o = obrada.PrimiOdgovorOdServera();
            return o;
        }
    }
}
