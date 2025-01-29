using Baza;
using Domen;
using System.Security.Principal;

namespace SistemskeOperacije
{
    public abstract class OpstaSistemskaOperacija
    {
        protected Broker broker;

        protected OpstaSistemskaOperacija() { broker = new(); }

        public void IzvrsiOperaciju(IOpstiDomenskiObjekat odo)
        {
            try
            {
                broker.OtvoriVezu();
                broker.PokreniTransakciju();
                IzvrsiPodoperaciju(odo);
                
                broker.Commit();
            }
            catch (Exception)
            {
                broker.Rollback();
                throw;
            }
            finally
            {
                broker.ZatvoriVezu();
            }
        }

        protected abstract void IzvrsiPodoperaciju(IOpstiDomenskiObjekat odo);
    }
}