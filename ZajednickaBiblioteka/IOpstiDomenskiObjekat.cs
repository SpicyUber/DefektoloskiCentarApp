using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IOpstiDomenskiObjekat
    {
        public string ImeTabele();
        public string AliasTabele();
       public string SelectVrednosti();
        public string UpdateVrednosti();
        public string InsertVrednosti();

        public string OrderUslov();

        public string DefaultInsertVrednosti();
        public string JoinTabela();
        public string JoinUslov();
        public string WhereUslov();

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac);
       
    }
}
