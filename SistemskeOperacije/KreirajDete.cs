using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SistemskeOperacije
{
    public class KreirajDete : OpstaSistemskaOperacija
    {
        public Dete Rezultat;
        protected override void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo)
        {
            try { 
            Dete dete = (Dete)odo;
           dete.Id= broker.Kreiraj(odo);
                Rezultat = dete;
                
            }catch(Exception ex) { throw new Exception("Sistem ne može da kreira dete."); }
            /*try
            {
                broker.Promeni(odo);
            }
            catch (Exception ex)
            {
                throw new Exception("Sistem ne može da zapamti dete.");
            }*/
        }

        protected override bool Validacija(IOpstiDomenskiObjekat odo)
        {
            return (odo is Dete);
        }
    }
}
