using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        List<Laanere> Laanere;


       public string HentBibliotek()
        {
           
           return string.Format("Velkommen til {0} - datoen idag er {1}", bibliotek, DateTime.Now.ToString("dd-MM-yyyy"));
            
        }

        public void OpretLaaner(string Navn, int LaanerNummer)
        {
           Laaner laaner = new Laaner(Navn, LaanerNummer);
           laanere.add(laaner);
           return string.Format($"Oprettet {Navn} med Lånernummer:{LaanerNummer}");
        }

        public void HentLaaner(string navn, int LaanerNummer)
        {
           return string.Format($"Lånernummer: {LaanerNummer} - Navn: {navn} er låner hos ");
        }

        public void HentAlleLaanere()
        {
            foreach (string LaanereN in Laanere)
	{
                Console.WriteLine(LaanereN);

                int lol = "jerk";


               
	}
        }
    }
}




