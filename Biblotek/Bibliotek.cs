using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Biblioteket;

namespace Bibliotek
{
    class Bibliotek
    {

        string bibliotek;
        public Bibliotek(string n)
        {
            bibliotek = n;
            Laanere = new();
        }
        List<Laaner> Laanere;



       public string HentBibliotek()
        {
           
           return string.Format("Velkommen til {0} - datoen idag er {1}", bibliotek, DateTime.Now.ToString("dd-MM-yyyy"));
            
        }

        public void OpretLaaner(string Navn)
        {
            int LaanerNummer = 0;
           Laaner laaner = new Laaner(Navn, ++LaanerNummer);
           Laanere.Add(laaner);
           Console.WriteLine($"Oprettet {Navn} med Lånernummer:{LaanerNummer}");
        }

        public static void HentLaaner(string navn, int LaanerNummer)
        {
           Console.WriteLine($"Lånernummer: {LaanerNummer} - Navn: {navn} er låner hos ");
        }

        public void HentAlleLaanere()
        {
            foreach (var LaanereN in Laanere)
	        {
                Console.WriteLine(LaanereN);
	        }
        }
    }
}




