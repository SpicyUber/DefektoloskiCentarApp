using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class EvidencijaTretmana : IOpstiDomenskiObjekat
    {
        public EvidencijaTretmana() {
            ukupnaCenaUDinarima = -1;
            
        }
        public int Id { get; set; }
        public DateTime DatumTretmana { get; set; } //dateonly je problematican

        private int vremePocetkaTretmanaUCasovima;
        public int VremePocetkaTretmanaUCasovima { get { if (vremePocetkaTretmanaUCasovima < 1 && Id>0) return 1; else return vremePocetkaTretmanaUCasovima; } set { vremePocetkaTretmanaUCasovima = value;  } }
        public bool? EvidencijaJeStornirana { get; set; }

        //jedini izuzetak u pretrazivanju int vrednosti je ukupnaCenaUDinarima. obzirom da moze biti nula ako nisu jos dodate stavke, neutralna vrednost za pretrazivanje je -1
        private int ukupnaCenaUDinarima;
        public int UkupnaCenaUDinarima { get { if (ukupnaCenaUDinarima < 0 && Id > 0) return 0; else return ukupnaCenaUDinarima; } set { ukupnaCenaUDinarima=value; } }
        public bool? TretmanJePlacen { get; set; }
        public Defektolog Defektolog { get; set; }
        public Dete Dete { get; set; }

        public List<StavkaEvidencijeTretmana> StavkeEvidencijeTretmana { get; set; }


        public string AliasTabele()
        {
            return "et";
        }

        public string ImeTabele()
        {
            return "evidencijatretmana";
        }

        public string InsertVrednosti()
        {
            return $"\'{DatumTretmana.ToString("yyyy-MM-dd")}\',{VremePocetkaTretmanaUCasovima},{((EvidencijaJeStornirana != null && (bool)EvidencijaJeStornirana) ? 1 : 0)},{0},{((bool)TretmanJePlacen ? 1 : 0)},{Defektolog.Id},{Dete.Id}";
        }

        public string JoinTabela()
        {
            return "dete";
        }

        public string JoinUslov()
        {
            return $"{ImeTabele()}.idDete = dete.idDete";
        }

        public string JoinTabela2()
        {
            return "defektolog";
        }

        public string JoinUslov2()
        {
            return $"{ImeTabele()}.idDefektolog = {JoinTabela2()}.idDefektolog";
        }

        
        public string JoinTabela3()
        {
            return "stavkaevidencijetretmana";
        }

        public string JoinUslov3()
        {
            return $"{ImeTabele()}.idEvidencijaTretmana = {JoinTabela3()}.idEvidencijaTretmana";
        }

        public string SelectVrednosti()
        {
            return "*";
        }

        public string UpdateVrednosti()
        {
            return $"datumTretmana = \'{DatumTretmana.ToString("yyyy-MM-dd")}\', vremePocetkaTretmanaUCasovima = {VremePocetkaTretmanaUCasovima}, evidencijaJeStornirana = {((EvidencijaJeStornirana!=null&&(bool)EvidencijaJeStornirana) ? 1 : 0)}, ukupnaCenaUDinarima = {0}, tretmanJePlacen = {((TretmanJePlacen != null && (bool)TretmanJePlacen) ? 1 : 0)}, idDefektolog = {Defektolog.Id}, idDete = {Dete.Id}";
            ;
        }

        public List<IOpstiDomenskiObjekat> VratiListu(SqlDataReader citac, bool zatvoriCitac)
        {
            List<IOpstiDomenskiObjekat> lista = new();

            while (citac.Read())
            {
                lista.Add(new EvidencijaTretmana() {
               Id= citac.GetInt32(0),
                DatumTretmana = citac.GetDateTime(1),
                VremePocetkaTretmanaUCasovima = citac.GetInt32(2),
                EvidencijaJeStornirana = (bool)citac[3], UkupnaCenaUDinarima = citac.GetInt32(4),
                    TretmanJePlacen = (bool)citac[5],
                    Defektolog = new() {Id= citac.GetInt32(12), Ime = citac.GetString(13), Prezime = citac.GetString(14), BrojTelefona= citac.GetString(15), Sifra = citac.GetString(16).Replace(citac.GetString(16),"*****"), KorisnickoIme = citac.GetString(17) }, Dete = new() { Id= citac.GetInt32(8), Ime = citac.GetString(9), Prezime = citac.GetString(10), Staratelj = new() { Id = citac.GetInt32(11)} }

                });;

            }
         
            if (zatvoriCitac) citac.Close();
            return lista;
        }

        public string WhereUslov()
        {
            if (Id > 0) return $" idEvidencijaTretmana = {Id} ";
            else
            {
                return WhereUslovPretrazivanje();
            }
        }

        private string WhereUslovPretrazivanje()
        {
            string whereString = "";
            int propBr = 0;
            if (DatumTretmana != DateTime.MinValue)
            {

                whereString += $"{ImeTabele()}.datumTretmana = \'{DatumTretmana.ToString("yyyy-MM-dd")}\'"; propBr++;
            }
            if (VremePocetkaTretmanaUCasovima >0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.vremePocetkaTretmanaUCasovima = {VremePocetkaTretmanaUCasovima}";
                propBr++;
            }

            if (EvidencijaJeStornirana != null)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.evidencijaJeStornirana = {((bool)EvidencijaJeStornirana ? 1 : 0)}";
                propBr++;
            }

            if (TretmanJePlacen != null)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.tretmanJePlacen = {((bool)TretmanJePlacen ? 1 : 0)}";
                propBr++;
            }

            if (UkupnaCenaUDinarima>-1)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.ukupnaCenaUDinarima = {UkupnaCenaUDinarima}";
                propBr++;
            }
           
            if ( Dete!=null && Dete.Id > 0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.idDete = {Dete.Id}";
                propBr++;
            }
            if (Defektolog!=null && Defektolog.Id > 0)
            {
                if (propBr > 0) whereString += " AND ";
                whereString += $"{ImeTabele()}.idDefektolog = {Defektolog.Id}";
                propBr++;
            }
            if (propBr == 0)
            {
                whereString = " 1=1 ";
            }
            return whereString;

        }

        public string DefaultInsertVrednosti()
        {
             


            return $"GETDATE(),'24','0','0','0',(SELECT MIN(idDefektolog) FROM defektolog),(SELECT MIN(idDete) FROM dete)";
        }

        public string OrderUslov()
        {
            return $"{ImeTabele()}.datumTretmana DESC";
        }
    }
}
