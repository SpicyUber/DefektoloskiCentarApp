using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Komunikacija
{
    public class ObradaZahteva
    {
        private Socket klijent;
        StreamReader citac;
        StreamWriter pisac;
        NetworkStream s;
        public ObradaZahteva(Socket klijent)
        {
            this.klijent = klijent;
            s = new NetworkStream(this.klijent);
            citac = new(s);
            pisac = new(s) { AutoFlush = true };
           
        }



        public Zahtev? PrimiZahtevOdKlijenta()
        {
           // Debug.WriteLine("PrimiZahtevOdKlijenta");
          return JsonSerializer.Deserialize<Zahtev>(citac.ReadLine());

        }

        public void PosaljiZahtevServeru(Zahtev z)
        {
            // Debug.WriteLine("PosaljiZahtevServeru");
            try
            {
                pisac.WriteLine(JsonSerializer.Serialize<Zahtev>(z));
            }
            catch (Exception ex)
            {
                
            }

        }

        public Odgovor PrimiOdgovorOdServera()
        {
            // Debug.WriteLine("PrimiOdgovorOdServera");
            try { 
            return JsonSerializer.Deserialize<Odgovor>(citac.ReadLine());
            }catch (Exception ex)
            {
                return new() { Uspeh = false, Objekat = null, Poruka = "Veza sa serverom je prekinuta." };
            }
        }

        public void PosaljiOdgovorKlijentu(Odgovor o)
        {
           // Debug.WriteLine("PosaljiOdgovorKlijentu");
            pisac.WriteLine(JsonSerializer.Serialize<Odgovor>(o));
        }

        public T VratiObjekatTipa<T>(object obj)
        {
            return JsonSerializer.Deserialize<T>((JsonElement)obj);
        }
    }
}
