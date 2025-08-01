using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class DefektoloskaUsluga : IOpstiDomenskiObjekat
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public int TrajanjeUSatima { get; set; } 

        public int CenaUDinarima { get; set; } 

        public string CmbValue { get { return Naziv; } }
        public string AliasTabele()
        {
            return "du";
        }

        public string ImeTabele()
        {
            return "defektoloskausluga";
        }

        public string InsertVrednosti()
        {
            return $" \'{Naziv}\',{TrajanjeUSatima},{CenaUDinarima}";
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
            return $" naziv = \'{Naziv}\' , trajanjeUSatima = {TrajanjeUSatima} , cenaUDinarima = {CenaUDinarima} ";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac)
        {
            List<IOpstiDomenskiObjekat> lista = new();
            while(citac.Read())
            {
                lista.Add(new DefektoloskaUsluga() {Id=citac.GetInt32(0), Naziv=citac.GetString(1), CenaUDinarima=citac.GetInt32(3), TrajanjeUSatima= citac.GetInt32(2) });
            }
           if(zatvoriCitac) { citac.Close(); }
           return lista;
        }

        public string WhereUslov()
        {
            if (Id > 0) return $" idDefektoloskaUsluga = {Id} ";
            else
            {
                return WhereUslovPretrazivanje();
            }
        }

        private string WhereUslovPretrazivanje()
        {
            string whereString = "";
            int propBr = 0;
            if (Naziv != null && !Naziv.Equals(""))
            {

                whereString += $"{ImeTabele()}.naziv = \'{Naziv}\'"; propBr++;
            }
            if (TrajanjeUSatima > 0 )
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.trajanjeUSatima = \'{TrajanjeUSatima}\'";
                propBr++;
            }

            if (CenaUDinarima > 0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.cenaUDinarima = {CenaUDinarima}";
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
    }
}
