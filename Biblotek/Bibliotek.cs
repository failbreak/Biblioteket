﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Biblioteket;

namespace Bibliotek
{
    public class Bibliotek
    {
        int LaanerNummer;
        string bibliotek;
        public Bibliotek(string n)
        {
            bibliotek = n;
            LaanerNummer = 0;
            Laanere = new();
        }
        public List<Laaner> Laanere;
       
       public string HentBibliotek()
        {
           return string.Format("Velkommen til {0} - datoen idag er {1}", bibliotek, DateTime.Now.ToString("dd-MM-yyyy"));
        }

        public string OpretLaaner(string Navn, string Email)
        {
           Laaner laaner = new Laaner(Navn, ++LaanerNummer, Email);
           Laanere.Add(laaner);
          return ($"Oprettet {Navn} med Lånernummer:{LaanerNummer} Email:{Email}");
        }
        public static void HentLaaner(string navn, int LaanerNummer, string Email)
        {
           
           Console.WriteLine($"Lånernummer: {LaanerNummer} - Navn: {navn} - Email:{Email} er låner hos Sønderborg Bibliotek");
        }
        public void HentAlleLaanere()
        {
            foreach (var LaanereN in Laanere)
	        {
                HentLaaner(LaanereN.Navn, LaanereN.LaanerNummer, LaanereN.Email);
                

	        }
        }
    }
}




