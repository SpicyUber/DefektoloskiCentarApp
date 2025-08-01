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
            List<IOpstiDomenskiObjekat> lista = new();
            while (citac.Read())
            {
                lista.Add(new StavkaEvidencijeTretmana()
                {
                    IdEvidencije = citac.GetInt32(0),
                    Rb = citac.GetInt32(1),
                    
                    Usluga = new(){Id= citac.GetInt32(3) , Naziv = citac.GetString(5), CenaUDinarima = citac.GetInt32(6) },
                     
                });
            }
            if(zatvoriCitac)citac.Close();
            return lista;
        }

        public string WhereUslov()
        {
            return $"idEvidencijaTretmana = {IdEvidencije}";
        }

        public string DefaultInsertVrednosti()
        {
            throw new NotImplementedException();
        }
    }
}
