using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class OdgovorniStaratelj : IOpstiDomenskiObjekat
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }   
        
        public string BrojTelefona { get; set; }

        public string CmbValue { get { return Ime +" "+ Prezime; } }
        public string AliasTabele()
        {
            return "o";
        }

        public string ImeTabele()
        {
            return "odgovornistaratelj";
        }

        public string InsertVrednosti()
        {
            return $"{Ime},\'{Prezime}\',\'{BrojTelefona}\'"; 
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

        public override string ToString()
        {
            return Ime +" "+ Prezime;
        }

        public string UpdateVrednosti()
        {
           return $" ime = \'{Ime}\',prezime=\'{Prezime}\',brojTelefona=\'{BrojTelefona}\'"; ;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac)
        {
            List < IOpstiDomenskiObjekat > lista = new();

            while (citac.Read()) {
                OdgovorniStaratelj staratelj = new OdgovorniStaratelj()
                {
                    Id = citac.GetInt32(0),
                    Ime = citac.GetString(1),
                    Prezime = citac.GetString(2),
                    BrojTelefona = citac.GetString(3)

                };

                
                lista.Add(staratelj); }
            if (zatvoriCitac) citac.Close();

            return lista;
        }

        public string WhereUslov()
        {
            string whereString = "";
            if(Id>0) { whereString = $" Id={Id}"; }
            else { WhereUslovPretrazivanje(); }
            return whereString ;
        
        }
        private string WhereUslovPretrazivanje()
        {
            string whereString = "";
            int propBr = 0;
            if (Ime != null && !Ime.Equals(""))
            {

                whereString += $"{ImeTabele()}.ime = \'{Ime}\'"; propBr++;
            }
            if (Prezime != null && !Prezime.Equals(""))
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.prezime = \'{Prezime}\'";
                propBr++;
            }

            if (BrojTelefona != null && !BrojTelefona.Equals(""))
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.brojtelefona = {BrojTelefona}";
                propBr++;
            }
            if (propBr == 0)
            {
                whereString = "1=1";
            }
            return whereString;
        }
    }
}
