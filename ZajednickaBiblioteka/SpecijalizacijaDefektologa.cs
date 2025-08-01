using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class SpecijalizacijaDefektologa : IOpstiDomenskiObjekat
    {
        public int IdDefektolog { get;set; }
       public  int IdSpecijalizacija { get;set; }

        public DateTime DatumSpecijalizacije { get;set; }   
        
        public string AliasTabele()
        {
            return "sd";
        }

        public string ImeTabele()
        {
            return "specijalizacijadefektologa";
        }

        public string InsertVrednosti()
        {
            return $"{IdDefektolog},{IdSpecijalizacija},\'{DatumSpecijalizacije.ToString("yyyy-MM-dd")}\'";
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
            return $"datumSpecijalizacije=\'{DatumSpecijalizacije.ToString("yyyy-MM-dd")}\'"; 
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac)
        {
            List<IOpstiDomenskiObjekat> lista = new();
            while(citac.Read())
            {

                lista.Add(new SpecijalizacijaDefektologa()
                {
                    IdDefektolog = citac.GetInt32(0),
                    IdSpecijalizacija = citac.GetInt32(1),
                    DatumSpecijalizacije = citac.GetDateTime(2)
                });
        }

            if(zatvoriCitac)citac.Close();

            return lista;
        }

        public string WhereUslov()
        {
            if (IdDefektolog > 0 && IdSpecijalizacija > 0)
            {
                return $" idDefektolog = {IdDefektolog} AND idSpecijalizacija = {IdSpecijalizacija}";
            }
            else if (DatumSpecijalizacije != DateTime.MinValue)
            {
                return $" datumSpecijalizacije = \'{DatumSpecijalizacije.ToString("yyyy-MM-dd")}\' ";
            }
            else return " 1 = 1 ";
        }

        public string DefaultInsertVrednosti()
        {
            throw new NotImplementedException();
        }
    }
}
