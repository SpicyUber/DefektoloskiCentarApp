using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class StavkaEvidencijeTretmana : IOpstiDomenskiObjekat
    {
        public int IdEvidencije { get; set; }
        public int Rb { get; set; }
        public int CenaUDinarima { get { return (Usluga==null)? 0 : Usluga.CenaUDinarima ; }   }
        public DefektoloskaUsluga Usluga { get;  set; }

        public string AliasTabele()
        {
            return "set";
        }

        public string ImeTabele()
        {
            return "stavkaevidencijetretmana";
        }

        public string InsertVrednosti()
        {
            return $" {IdEvidencije} , {Rb} , {CenaUDinarima} , {Usluga.Id} ";
        }

        public string JoinTabela()
        {
            return "defektoloskausluga";
        }

        public string JoinUslov()
        {
            return $"{ImeTabele()}.idDefektoloskaUsluga = {JoinTabela()}.idDefektoloskaUsluga";
        }

        public string SelectVrednosti()
        {
            return "*";
        }

        public string UpdateVrednosti()
        {
            return $" {Rb} , {CenaUDinarima} , {Usluga.Id} "; 
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac)
        {
            try {
                List<IOpstiDomenskiObjekat> lista = new();
                while (citac.Read())
                {
                    lista.Add(new StavkaEvidencijeTretmana()
                    {
                        IdEvidencije = citac.GetInt32(0),
                        Rb = citac.GetInt32(1),

                        Usluga = new() { Id = citac.GetInt32(3), Naziv = citac.GetString(5), TrajanjeUSatima= citac.GetInt32(6), CenaUDinarima = citac.GetInt32(7) },

                    });
                }
                if (zatvoriCitac) citac.Close();
                return lista;
            } catch (Exception ex) { if (citac != null) citac.Close(); throw ex; }
        }

        public string WhereUslov()
        {


            string whereString = "";
            int propBr = 0;
            if (IdEvidencije != null && IdEvidencije>0)
            {

                whereString += $"{ImeTabele()}.idEvidencijaTretmana = {IdEvidencije}"; propBr++;
            }
            if (Rb != null && Rb>0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.rb = {Rb}";
                propBr++;
            }

            if (CenaUDinarima != null && CenaUDinarima > 0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.CenaUDinarima = {CenaUDinarima}";
                propBr++;
            }

            if(Usluga!=null && Usluga.Id > 0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.idDefektoloskaUsluga = {Usluga.Id}";
                
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
