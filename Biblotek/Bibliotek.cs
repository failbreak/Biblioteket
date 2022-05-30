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

        }
       public string HentBibliotek()
        {
           
           return string.Format("Velkommen til {0} - datoen idag er {1}", bibliotek, DateTime.Now.ToString("dd-MM-yyyy"));
            
        }

        public void OpretLaaner(string Navn, int LaanerNummer)
        {
           Laaner laaner = new Laaner(Navn, LaanerNummer);
           laaner.add();
           return laaner;
        }

        public void HentLaaner(string navn, int LaanerNummer)
        {
           return string.Format($"Lånernummer: {LaanerNummer} - Navn: {navn} er låner hos ");
        }
    }
}




