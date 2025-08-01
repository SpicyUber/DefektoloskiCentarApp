

using Domen;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Baza
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        public SqlCommand Command;
        public Broker()
        {
            connection = new SqlConnection(new SqlConnectionStringBuilder("Data Source=KABYLAKE;Initial Catalog=defektoloski_centar;Integrated Security=True;Connect Timeout=30;Encrypt=False;").ConnectionString);
        }
        public void Commit()
        {
            transaction.Commit();
        }

        public void OtvoriVezu()
        {
            connection.Open();

        }

        public void PokreniTransakciju()
        {
            transaction = connection.BeginTransaction();
            Command = connection.CreateCommand();
            Command.Transaction = transaction;
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public void ZatvoriVezu()
        {
            connection.Close();
        }


        public List<IOpstiDomenskiObjekat> VratiSve(IOpstiDomenskiObjekat odo)
        {
            Command.CommandText = "SELECT " + odo.SelectVrednosti() + " FROM " + odo.ImeTabele();
            if (odo.JoinTabela() != null && odo.JoinTabela() != "") { Command.CommandText += " JOIN " + odo.JoinTabela() + " ON ( " + odo.JoinUslov() + " )"; }
            Debug.WriteLine(Command.CommandText);
            SqlDataReader citac = Command.ExecuteReader();

            List<IOpstiDomenskiObjekat> list = odo.VratiListu(citac, true);

            return list;
        }

        public List<IOpstiDomenskiObjekat> VratiSveSaUslovom(IOpstiDomenskiObjekat odo)
        {
            Command.CommandText = "SELECT " + odo.SelectVrednosti() + " FROM " + odo.ImeTabele();
            if (odo.JoinTabela() != null && odo.JoinTabela() != "") { Command.CommandText += " JOIN " + odo.JoinTabela() + " ON ( " + odo.JoinUslov() + " )"; }
            Command.CommandText += " WHERE " + odo.WhereUslov();
            Debug.WriteLine(Command.CommandText);
            SqlDataReader citac = Command.ExecuteReader();

            List<IOpstiDomenskiObjekat> list = odo.VratiListu(citac, true);

            return list;

        }

        public int Kreiraj(IOpstiDomenskiObjekat odo)
        {
            Command.CommandText = $"INSERT INTO {odo.ImeTabele()} VALUES ({odo.DefaultInsertVrednosti()}) SELECT SCOPE_IDENTITY()";
            Debug.WriteLine(Command.CommandText);
            
           return Convert.ToInt32(Command.ExecuteScalar());
            
        }

        public void Ubaci(IOpstiDomenskiObjekat odo)
        {
            Command.CommandText = $"INSERT INTO {odo.ImeTabele()} VALUES ({odo.InsertVrednosti()})";
            Debug.WriteLine(Command.CommandText);
            if (Command.ExecuteNonQuery() == 0)
            {
                throw new Exception("Greška pri ubacivanju u bazu!");
            }

        }

        public void Obrisi(IOpstiDomenskiObjekat odo)
        {
            Command.CommandText = $"DELETE FROM {odo.ImeTabele()} WHERE ({odo.WhereUslov()})";
            Debug.WriteLine(Command.CommandText);
            if (Command.ExecuteNonQuery() == 0)
            {
                throw new Exception("Greška pri brisanju u bazi!");
            }

        }

        public void Promeni(IOpstiDomenskiObjekat odo)
        {
            Command.CommandText = $"UPDATE {odo.ImeTabele()} SET {odo.UpdateVrednosti()} WHERE {odo.WhereUslov()}";
            Debug.WriteLine(Command.CommandText);
            if (Command.ExecuteNonQuery() == 0)
            {
                throw new Exception("Greška pri promeni u bazi!");
            }
        }

    }
}