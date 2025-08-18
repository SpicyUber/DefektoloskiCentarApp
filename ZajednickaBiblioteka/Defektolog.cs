using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Defektolog : IOpstiDomenskiObjekat
    {
        
        //ako je Id manji od 1, obzirom da objekat sigurno nije iz baze mozemo ga tretirati drugacije.
        //obzirom da tada ne menjamo niti prikazujemo postojeci red u bazi, objekat najverovatnije koristi za pretrazivanje
        public int Id { get; set; }
        public string Ime { get; set; }

        public string Prezime { get; set; } 

        public string BrojTelefona { get; set; }

        public string Sifra { get; set; }

        public string KorisnickoIme { get; set; }

        public string CmbValue { get { return Ime + " " + Prezime; } }


        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public string AliasTabele()
        {
            return "def";
        }

        public string ImeTabele()
        {
            return "defektolog";
        }

        public string InsertVrednosti()
        {
            return $"\'{Ime}\',\'{Prezime}\',\'{BrojTelefona}\',\'{Sifra}\',\'{KorisnickoIme}\'";
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
           return $" {ImeTabele()}.ime = \'{Ime}\', {ImeTabele()}.prezime=\'{Prezime}\', {ImeTabele()}.brojTelefona=\'{BrojTelefona}\'";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac,bool zatvoriCitac)
        {
          List<IOpstiDomenskiObjekat> l = new List<IOpstiDomenskiObjekat>();
            while(citac.Read())
            {
                Defektolog d = new Defektolog()
                {
                    Id = citac.GetInt32(0),
                    Ime = citac.GetString(1),
                    Prezime = citac.GetString(2),
                    BrojTelefona = citac.GetString(3),
                    Sifra = citac.GetString(4),
                    KorisnickoIme = citac.GetString(5),
                };
l.Add(d);
            }
            if (zatvoriCitac) citac.Close();
return l;
        }

        public string WhereUslov()
        {
            string whereString = "";
            if (Id > 0)
                whereString = WhereUslovNadjiPostojeci();
            else if ((KorisnickoIme == null) && (Sifra == null))
            {

                whereString = WhereUslovPretrazivanje();
            }
            else
            {


                whereString = WhereUslovPrijava();  }
                return whereString;
            }

        private string WhereUslovPretrazivanje() {

            //$"ime = \'{Ime}\' AND prezime=\'{Prezime}\' AND brojTelefona=\'{BrojTelefona}\' AND sifra=\'{Sifra}\' AND korisnickoIme=\'{KorisnickoIme}\'";
           string whereString="";
            int propBr = 0;
            if (Ime != null && !Ime.Equals(""))
            {

                whereString += $"ime = \'{Ime}\'"; propBr++;
            }
            if (Prezime != null && !Prezime.Equals(""))
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"prezime = \'{Prezime}\'";
                propBr++;
            }

            if (BrojTelefona != null && !BrojTelefona.Equals(""))
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"brojTelefona = \'{BrojTelefona}\'";
                propBr++;
            }
            if (propBr == 0)
            {
                whereString = "1=1";
            }
            return whereString;
        }

        private string WhereUslovPrijava()
        {
            return $"korisnickoIme = \'{((KorisnickoIme == null) ? "" : KorisnickoIme)}\' AND sifra = \'{((Sifra == null) ? "" : Sifra)}\' ";


        }
        private string WhereUslovNadjiPostojeci()
        {

           return $"idDefektolog= {Id}";
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
