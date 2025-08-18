using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Specijalizacija : IOpstiDomenskiObjekat
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Institucija { get; set; }
        public string AliasTabele()
        {
            return "sp";
        }

        public string ImeTabele()
        {
            return "specijalizacija";
        }

        public string InsertVrednosti()
        {
            return $"\'{Naziv}\',\'{Institucija}\'";
        }

        public string JoinTabela()
        {
            return "";
        }

        public string JoinUslov()
        {
            return "";
        }

        public string SelectVrednosti()
        {
            return "*";
        }

        public string UpdateVrednosti()
        {
           return $" naziv = \'{Naziv}\', institucija = \'{Institucija}\' ";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac)
        {
            List<IOpstiDomenskiObjekat> lista = new();
            while(citac.Read())
            {
               
                lista.Add(new Specijalizacija() { Id = citac.GetInt32(0), Institucija = citac.GetString(2), Naziv = citac.GetString(1) });

            }

            if(zatvoriCitac)citac.Close();

            return lista;

        }

        public string WhereUslov()
        {
            string whereString = "";
            if (Id > 0)
            {
              whereString=  WhereUslovNadjiPostojeci();
            }
            else
            {
                whereString = WhereUslovPretrazivanje();
            }
            return whereString;
        }

        private string WhereUslovNadjiPostojeci()
        {
            return $"idSpecijalizacija={Id}";
        }

        private string WhereUslovPretrazivanje()
        {
            string whereString = "";
            int propBr = 0;
            if (Naziv != null && !Naziv.Equals(""))
            {

                whereString += $"{ImeTabele()}.naziv = \'{Naziv}\'"; propBr++;
            }
            if (Institucija != null && !Institucija.Equals(""))
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.institucija = \'{Institucija}\'";
                propBr++;
            }
            if (propBr == 0)
            {
                whereString = "1=1";
            }
            return whereString;
        }

        public string DefaultInsertVrednosti()
        {
            throw new NotImplementedException();
        }

        public string OrderUslov()
        {
            return "";
        }
    }
}
