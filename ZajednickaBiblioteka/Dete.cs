using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Dete : IOpstiDomenskiObjekat
    {
       public int Id { get; set; }
       public string Ime { get; set; }

        public string Prezime { get; set; }

        public OdgovorniStaratelj Staratelj { get; set; }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }

        public string CmbValue { get { return Ime + " " + Prezime; } }
        public string AliasTabele()
        {
            return "det";
        }

        public string ImeTabele()
        {
           return "dete";
        }

        public string InsertVrednosti()
        {
            return $"\'{Ime}\',\'{Prezime}\',\'{Staratelj.Id}\'";
        }

        public string JoinTabela()
        {
            return "odgovornistaratelj";
        }

        public string JoinUslov()
        {
            return ImeTabele()+ ".idOdgovorniStaratelj = " + JoinTabela()+".idOdgovorniStaratelj" ;
        }

        public string SelectVrednosti()
        {
           return "*";
        }

        public string UpdateVrednosti()
        {
            return $" {ImeTabele()}.ime = \'{Ime}\', {ImeTabele()}.prezime=\'{Prezime}\', {ImeTabele()}.idOdgovorniStaratelj={Staratelj.Id}";

        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac)
        {
            List<IOpstiDomenskiObjekat> l = new List<IOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                Dete d = new Dete()
                {
                    Id = citac.GetInt32(0),
                    Ime = citac.GetString(1),
                    Prezime = citac.GetString(2),
                    Staratelj = new() { Id = citac.GetInt32(3),  Ime = citac.GetString(5), Prezime = citac.GetString(6), BrojTelefona = citac.GetString(7)}
                };
                l.Add(d);
            }
            if (zatvoriCitac) { citac.Close();}
            return l;
        }

        public string WhereUslov()
        {
            string whereString = "";
            if (Id > 0)
                whereString = WhereUslovNadjiPostojeci();
            else {

                whereString = WhereUslovPretrazivanje();
            }
            return whereString;
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

            if (Staratelj != null  && Staratelj.Id>0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.idOdgovorniStaratelj = {Staratelj.Id}";
                propBr++;
            }
            if (propBr == 0)
            {
                whereString = "1=1";
            }
            return whereString;
        }

        private string WhereUslovNadjiPostojeci()
        {
            return $"idDete={Id}";
        }

        public string DefaultInsertVrednosti()
        {
            string defaultIme = "",defaultPrezime="";
            string defaultStarateljId = "(SELECT MIN(idOdgovorniStaratelj) FROM odgovornistaratelj)";
            

            return $"\'{defaultIme}\',\'{defaultPrezime}\',{defaultStarateljId}";
        }

        public string OrderUslov()
        {
            return $"{ImeTabele()}.ime";
        }
    }
}
