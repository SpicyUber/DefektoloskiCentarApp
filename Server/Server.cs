using Domen;
using Komunikacija;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        public Socket Soket;
        public bool ServerAktivan=false;
        public List<Defektolog> ListaKorisnika=null;
       // public int BrojKlijenata = 0;
         

        public void Kreni()
        { if (ServerAktivan) return;

            try {
                ListaKorisnika = new List<Defektolog>();
            Soket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerAktivan = true;
            Soket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4444));
            Soket.Listen(5);
            
            Thread t = new Thread(KomunikacijaSaKlijentom);
            t.Start();


            }catch (Exception ex)
            {
                Stani();
                Debug.WriteLine(ex.Message);
            }





        }
        public void KomunikacijaSaKlijentom()
        {
            
            try
            {
                while (ServerAktivan)
                {
                    Socket klijent = Soket.Accept();
                    
                     
                    
                   Thread t1=new(()=>IzvrsiOperaciju(klijent));
                    t1.Start();
                    
                     
                     
                     

                }
            }
            catch (Exception ex)
            {
                Stani();
                Debug.WriteLine(ex.Message);
            }
        }

        public void Stani() { ListaKorisnika = null;   Soket?.Close(); ServerAktivan = false; }

        public void IzvrsiOperaciju(Socket klijent)
        {
           
            try {
                ObradaZahteva obrada = new(klijent);
                while (ServerAktivan)
                {
                    Zahtev? z = obrada.PrimiZahtevOdKlijenta();
                Debug.WriteLine("IZVRSIO OEPRACIJU" + "\n" +z);
                if (z == null) {  continue; }

                obrada.PosaljiOdgovorKlijentu(IzborOperacije(z,obrada));

                    
                   

                }
            }catch (Exception ex) {  Debug.WriteLine(ex.Message); }
        }

        private Odgovor IzborOperacije(Zahtev z, ObradaZahteva obrada)
        {

            Odgovor o = new() { Objekat = null, Poruka = "Operacija " + z.Operacija + " nije uspela!", Uspeh = false };
            try { 

            switch (z.Operacija)
            {
                case Operacija.PrijaviDefektolog:
                 //   Debug.WriteLine(z.Objekat+":z.Objekat!"+z.Objekat.GetType().ToString());
                  o=  Kontroler.Instanca.Prijava(obrada.VratiObjekatTipa<Defektolog>(z.Objekat),ListaKorisnika);
                       
                        break;
                    case Operacija.PretraziDete:

                        o= Kontroler.Instanca.PretraziDete(obrada.VratiObjekatTipa<Dete>(z.Objekat));



                        break;
                    case Operacija.VratiListuDetePoKriterijumuOdgovorniStaratelj:

                        o = Kontroler.Instanca.VratiListuDetePoKriterijumuOdgovorniStaratelj(obrada.VratiObjekatTipa<OdgovorniStaratelj>(z.Objekat));

                        break;
                    case Operacija.VratiListuSviOdgovorniStaratelj:

                        o = Kontroler.Instanca.VratiListuSviOdgovorniStaratelj();

                        break;

                    case Operacija.KreirajDete:
                        o = Kontroler.Instanca.KreirajDete(obrada.VratiObjekatTipa<Dete>(z.Objekat));
                        break;

                    case Operacija.ObrisiDete:
                        o = Kontroler.Instanca.ObrisiDete(obrada.VratiObjekatTipa<Dete>(z.Objekat));
                        break;
                    case Operacija.PromeniDete:
                        o = Kontroler.Instanca.PromeniDete(obrada.VratiObjekatTipa<Dete>(z.Objekat));
                        break;
                    case Operacija.VratiListuSviSpecijalizacija:
                        o = Kontroler.Instanca.VratiListuSviSpecijalizacija();
                        break;
                    case Operacija.UbaciSpecijalizacija:
                        o = Kontroler.Instanca.UbaciSpecijalizacija(obrada.VratiObjekatTipa<Specijalizacija>(z.Objekat));
                        break;
                    case Operacija.PretraziEvidencijaTretmana:
                        o = Kontroler.Instanca.PretraziEvidencijaTretmana(obrada.VratiObjekatTipa<EvidencijaTretmana>(z.Objekat));
                        break;
                    case Operacija.VratiListuSviDefektolog:
                        o = Kontroler.Instanca.VratiListuSviDefektolog();
                        break;
                    case Operacija.VratiListuSviDefektoloskaUsluga:
                        o = Kontroler.Instanca.VratiListuSviDefektoloskaUsluga();
                        break;
                    case Operacija.VratiListuEvidencijaTretmanaPoKriterijumuDete:
                        o = Kontroler.Instanca.VratiListuEvidencijaTretmanaPoKriterijumuDete(obrada.VratiObjekatTipa<Dete>(z.Objekat));
                        break;
                    case Operacija.VratiListuEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga:
                        o = Kontroler.Instanca.VratiListuEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga(obrada.VratiObjekatTipa<DefektoloskaUsluga>(z.Objekat));
                        break;
                    case Operacija.VratiListuEvidencijaTretmanaPoKriterijumuDefektolog:
                        o = Kontroler.Instanca.VratiListuEvidencijaTretmanaPoKriterijumuDefektolog(obrada.VratiObjekatTipa<Defektolog>(z.Objekat));
                        break;
                    case Operacija.KreirajEvidencijaTretmana:
                        o = Kontroler.Instanca.KreirajEvidencijaTretmana(obrada.VratiObjekatTipa<EvidencijaTretmana>(z.Objekat));
                            break;
                    case Operacija.PromeniEvidencijaTretmana:
                        o = Kontroler.Instanca.PromeniEvidencijaTretmana(obrada.VratiObjekatTipa<EvidencijaTretmana>(z.Objekat));
                        break;
                    case Operacija.OdjaviDefektolog:
                        o = Kontroler.Instanca.Odjava(obrada.VratiObjekatTipa<Defektolog>(z.Objekat), ListaKorisnika);
                        break;
                    

                }
            }catch(Exception e)
            {

                o.Poruka += "(" + e.Message + ")"; 
            }

            return o;
        }

       
    }
}
