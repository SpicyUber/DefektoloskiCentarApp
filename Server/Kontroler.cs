using Domen;
using Komunikacija;
using Microsoft.VisualBasic.ApplicationServices;
using SistemskeOperacije;
using System;
using System.Collections;
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

        public Odgovor Prijava(IOpstiDomenskiObjekat odo,List<Defektolog> listaKorisnika)
        {
            try {
            PrijaviDefektolog so = new PrijaviDefektolog();
            so.IzvrsiOperaciju(odo);
                if (so.Rezultat)
                {
                    DodajUListuKorisnika(odo,listaKorisnika);
                }
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

        private void DodajUListuKorisnika(IOpstiDomenskiObjekat odo, List<Defektolog> listaKorisnika)
        {
            Defektolog defektolog = (Defektolog)odo;
            lock (listaKorisnika)
            {
                int id = defektolog.Id;

                foreach (Defektolog korisnik in listaKorisnika) { if (id == korisnik.Id) return; }
                listaKorisnika.Add(defektolog);

            }
        }

        private void UkloniIzListeKorisnika(IOpstiDomenskiObjekat odo, List<Defektolog> listaKorisnika)
        {
            Defektolog defektolog = (Defektolog)odo;
            lock (listaKorisnika)
            {
                int id = defektolog.Id;

                for(int i=0;i<listaKorisnika.Count;i++) { if (id == listaKorisnika.ElementAt(i).Id) { listaKorisnika.RemoveAt(i); return; } }
                

            }
        }

        public Odgovor PretraziDete(IOpstiDomenskiObjekat odo)
        {
            try {
            PretraziDete so = new PretraziDete();
                string poruka = "Sistem je našao decu po zadatim kriterijumima!!";
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
                string poruka = "Sistem je našao decu po zadatim kriterijumima!";
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
            return new() { Objekat=so.Rezultat, Uspeh = true, Poruka="Sistem je kreirao dete." };
            }catch(Exception e) { return new() { Objekat = null, Uspeh = false, Poruka = e.Message }; }
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
            if (odo == null || ((Dete)odo).Id<1) return new() { Objekat = null, Uspeh = false, Poruka = "Sistem ne može da zapamti dete!" };
            try {
                PromeniDete so = new();
                so.IzvrsiOperaciju(odo);
                return new() { Uspeh = true, Objekat = null, Poruka = "Sistem je zapamtio dete!" };
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

        public Odgovor PretraziEvidencijaTretmana(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string poruka = "Sistem je našao evidencije tretmana po zadatim kriterijumima!";
                PretraziEvidencijaTretmana so = new();
                so.IzvrsiOperaciju(odo);
                List<EvidencijaTretmana> lista = so.Rezultat;
                if (lista == null || lista.Count == 0) { poruka = "Nije pronađena nijedna evidencija tretmana po kriterijumu!"; }
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

         public Odgovor VratiListuSviDefektolog()
        {
            try
            {
                VratiListuSviDefektolog so = new();
                so.IzvrsiOperaciju(new Defektolog());
               
                return new() { Objekat = so.Rezultat, Uspeh = true, Poruka = "Uspešno vraćena lista svih defektologa!" };



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

        public Odgovor VratiListuSviDefektoloskaUsluga()
        {
            try
            {
                VratiListuSviDefektoloskaUsluga so = new();
                so.IzvrsiOperaciju(new DefektoloskaUsluga());

                return new() { Objekat = so.Rezultat, Uspeh = true, Poruka = "Uspešno vraćena lista svih defektoloških usluga!" };



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

        public Odgovor Odjava(IOpstiDomenskiObjekat odo, List<Defektolog> listaKorisnika)
        {
            try
            {
                PrijaviDefektolog so = new PrijaviDefektolog();
                so.IzvrsiOperaciju(odo);
                if (so.Rezultat)
                {
                    UkloniIzListeKorisnika(odo, listaKorisnika);
                }
                return new()
                {
                    Uspeh = so.Rezultat,
                    Objekat = null,
                    Poruka = (so.Rezultat) ? ("Upešna odjava!") : ("Neuspesna odjava! Pokušajte opet.")

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

        public Odgovor VratiListuEvidencijaTretmanaPoKriterijumuDete(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string poruka = "Sistem je našao evidencije tretmana po zadatim kriterijumima!";
                PretraziEvidencijaTretmana so = new();
                so.IzvrsiOperaciju(new EvidencijaTretmana() { DatumTretmana = DateTime.MinValue, EvidencijaJeStornirana = null, TretmanJePlacen = null, VremePocetkaTretmanaUCasovima = 0, UkupnaCenaUDinarima = -1, Dete = (Dete)odo, Defektolog = new() });
                List<EvidencijaTretmana> lista = so.Rezultat;
                if (lista == null || lista.Count == 0) { poruka = "Nije pronađena nijedna evidencija tretmana po kriterijumu!"; }
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

        public Odgovor VratiListuEvidencijaTretmanaPoKriterijumuDefektolog(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string poruka = "Sistem je našao evidencije tretmana po zadatim kriterijumima!";
                PretraziEvidencijaTretmana so = new();
                so.IzvrsiOperaciju(new EvidencijaTretmana() { DatumTretmana = DateTime.MinValue, EvidencijaJeStornirana = null, TretmanJePlacen = null, VremePocetkaTretmanaUCasovima = 0, UkupnaCenaUDinarima = -1, Dete= new Dete(), Defektolog = (Defektolog)odo });
                List<EvidencijaTretmana> lista = so.Rezultat;
                if (lista == null || lista.Count == 0) { poruka = "Nije pronađena nijedna evidencija tretmana po kriterijumu!"; }
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

        public Odgovor KreirajEvidencijaTretmana(IOpstiDomenskiObjekat odo)
        {
            try
            {
                KreirajEvidencijaTretmana so = new();
                so.IzvrsiOperaciju(odo);
                return new() { Objekat = so.Rezultat, Uspeh = true, Poruka = "Sistem je kreirao evidenciju tretmana." };
            }
            catch (Exception e) { return new() { Objekat = null, Uspeh = false, Poruka = e.Message }; }

        }

        public Odgovor PromeniEvidencijaTretmana(IOpstiDomenskiObjekat odo)
        {
            try
            {
                PromeniEvidencijaTretmana so = new();
                so.IzvrsiOperaciju(odo);
                return new() { Objekat = null, Uspeh = true, Poruka = "Sistem je zapamtio evidenciju tretmana." };

            }
            catch (Exception e)
            {
                return new() { Objekat = null, Uspeh = false, Poruka = "Sistem ne može da zapamti evidenciju tretmana." };
            }
        }

        public Odgovor VratiListuEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string poruka = "Sistem je našao evidencije tretmana po zadatim kriterijumima!";
                PretraziEvidencijaTretmanaPoKriterijumuDefektoloskaUsluga so = new();
                so.IzvrsiOperaciju(odo);
                List<EvidencijaTretmana> lista = so.Rezultat;
                if (lista == null || lista.Count == 0) { poruka = "Nije pronađena nijedna evidencija tretmana po kriterijumu!"; }
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
    }
}
