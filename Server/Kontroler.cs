using Domen;
using Komunikacija;
using Microsoft.VisualBasic.ApplicationServices;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Kontroler
    {
        private Kontroler() { return; }

        private static Kontroler instanca =null;
        public static Kontroler Instanca { get { if (instanca == null) instanca = new Kontroler(); return instanca; }   }

        public Odgovor Prijava(IOpstiDomenskiObjekat odo)
        {
            try {
            PrijaviDefektolog so = new PrijaviDefektolog();
            so.IzvrsiOperaciju(odo);
          return new() { Uspeh=so.Rezultat,
          Objekat = null, Poruka = (so.Rezultat) ?("Upešna Prijava! Dobrodošli.") :("Neuspesna prijava! Pokušajte opet.") 
          
          };
            }catch(Exception e)
            {
                return new(){
                    Uspeh = false,
          Objekat = null, Poruka = "Greška na strani servera!"+e.Message
                };
            }
        }

        public Odgovor PretraziDete(IOpstiDomenskiObjekat odo)
        {
            try {
            PretraziDete so = new PretraziDete();
                string poruka = "Pretraga Uspešna!";
                so.IzvrsiOperaciju(odo);
                List<Dete> lista = so.Rezultat;
                if (lista == null || lista.Count == 0) { poruka = "Nije pronađeno nijedno dete po kriterijumu!"; }
                return new()
                {
                    Uspeh = true,
                    Objekat = lista,
                    Poruka = poruka

                };

            }catch(Exception e)
            {
                return new()
                {
                    Uspeh = false,
                    Objekat = null,
                    Poruka = "Greška na strani servera!" + e.Message
                };
            }
        }

        public Odgovor VratiListuDetePoKriterijumuOdgovorniStaratelj(IOpstiDomenskiObjekat odo)
        {
            try
            {
               odo= new Dete() { Id = 0, Staratelj = (OdgovorniStaratelj)odo };
                VratiListuDetePoKriterijumuOdgovorniStaratelj so = new VratiListuDetePoKriterijumuOdgovorniStaratelj();
                string poruka = "Pretraga Uspešna!";
                so.IzvrsiOperaciju(odo);
                List<Dete> lista = so.Rezultat;
                if (lista == null || lista.Count == 0) { poruka = "Nije pronađeno nijedno dete po kriterijumu!"; }
                return new()
                {
                    Uspeh = true,
                    Objekat = lista,
                    Poruka = poruka

                };

            }
            catch (Exception e)
            {
                return new()
                {
                    Uspeh = false,
                    Objekat = null,
                    Poruka = "Greška na strani servera!" + e.Message
                };
            }
        }

        public Odgovor VratiListuSviOdgovorniStaratelj()
        {
            try { VratiListuSviOdgovorniStaratelj so = new();
                so.IzvrsiOperaciju(new OdgovorniStaratelj());
                return new()
                {
                    Uspeh = true,
                    Objekat = so.Rezultat,
                    Poruka = "Uspešno vraćena lista svih odgovornih staratelja!"
                };
            }
            catch(Exception e)
            {
                return new()
                {
                    Uspeh = false,
                    Objekat = null,
                    Poruka = "Greška na strani servera!" + e.Message
                };
            }
        }

       public Odgovor KreirajDete(IOpstiDomenskiObjekat odo)
        {
            try { 
          KreirajDete so = new();
            so.IzvrsiOperaciju(odo);
            return new() { Objekat=null, Uspeh = true, Poruka="Sistem je zapamtio dete." };
            }catch(Exception e) { return new() { Objekat = null, Uspeh = false, Poruka = "Sistem ne može da zapamti dete." }; }
        }

        public Odgovor ObrisiDete(IOpstiDomenskiObjekat odo)
        {
            try
            {
                ObrisiDete so = new();
                so.IzvrsiOperaciju(odo);
                return new() { Objekat = null, Uspeh = true, Poruka = "Sistem je obrisao dete." };
            }
            catch (Exception ex) { return new() { Objekat = null, Uspeh = false, Poruka = "Sistem ne može da obriše dete." }; }
        }

        public Odgovor PromeniDete(IOpstiDomenskiObjekat odo)
        {
            if (odo == null || ((Dete)odo).Id<1) return new() { Objekat = null, Uspeh = false, Poruka = "Sistem ne može da nađe dete!" };
            try {
                PromeniDete so = new();
                so.IzvrsiOperaciju(odo);
                return new() { Uspeh = true, Objekat = null, Poruka = "Sistem je našao dete!\nSistem je zapamtio dete!" };
            }catch(Exception e) { return new() {Poruka="Sistem ne može da zapamti dete!", Uspeh=false, Objekat = null }; }
        }

        public Odgovor UbaciSpecijalizacija(IOpstiDomenskiObjekat odo)
        {
            try
            {
                UbaciSpecijalizacija so = new();
                so.IzvrsiOperaciju(odo);
                return new() { Objekat = null, Uspeh = true, Poruka = "Sistem je zapamtio specijalizaciju." };
            }
            catch (Exception e) { return new() { Objekat = null, Uspeh = false, Poruka = "Sistem ne može da zapamti specijalizaciju." }; }


        }

        public Odgovor VratiListuSviSpecijalizacija()
        {
            try
            {
                VratiListuSviSpecijalizacija so = new();
                so.IzvrsiOperaciju(new Specijalizacija());
                return new()
                {
                    Uspeh = true,
                    Objekat = so.Rezultat,
                    Poruka = "Uspešno vraćena lista svih specijalizacija!"
                };
            }
            catch (Exception e)
            {
                return new()
                {
                    Uspeh = false,
                    Objekat = null,
                    Poruka = "Greška na strani servera!" + e.Message
                };
            }

        }
    }
}
