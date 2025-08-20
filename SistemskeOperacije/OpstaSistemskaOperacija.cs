using Baza;
using Domen;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected Broker broker;

        protected OpstaSistemskaOperacija() { broker = new(); }

        public bool IzvrsiOperaciju(IOpstiDomenskiObjekat odo)
        {

            bool signal = false;

            try
            {
                broker.OtvoriVezu();
                broker.PokreniTransakciju();
                if (Validacija(odo))
                    IzvrsiPodoperaciju(odo);
                else throw new Exception("Neuspešna validacija!");
                
                broker.Commit();
                signal = true;
            }
            catch (Exception)
            {
                broker.Rollback();
                signal = false;
            }
            finally
            {
                broker.ZatvoriVezu();
                
            }

            return signal;
        }

        protected abstract bool Validacija(IOpstiDomenskiObjekat odo);
        protected abstract void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo);
    }
}