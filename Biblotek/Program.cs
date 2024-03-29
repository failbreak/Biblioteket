﻿using System;
using System.Threading;
namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Bibliotek biblo = new Bibliotek("Sønderborg bibliotek");
            bool exit = true;
            while (exit)
            {
                Console.Clear();
                string[] mulig = {"Vis Bibliotektekst navn og dato", "Opret Låner", "Udskrivlånere" ,"Afslut"};
                int tal = 0;
                foreach (var item in mulig)
                {
                   
                    Console.WriteLine($"{++tal} {item}");
                }
            bool a = int.TryParse(Console.ReadLine(), out int sUserIn);
            if (!a)
            {
                Console.WriteLine("Indtast et nummer som er i menuen");

            }

            switch (sUserIn)
            {
                case 1:
                    Console.WriteLine(biblo.HentBibliotek());
                        Console.ReadKey();
                        break;

                case 2:
                        Console.Write("Opret låner: Navn: ");
                        string n = Console.ReadLine();
                        Console.Write("\n Email:");
                        string e = Console.ReadLine();
                        biblo.OpretLaaner(n, e);
                        Console.ReadKey();
                    break;

                case 3:
                        biblo.HentBibliotek();
                        biblo.HentAlleLaanere();
                        Console.ReadKey();
                        break;

                case 4:
                        exit = false;
                    break;

                default:
                    break;
            }
            }
        }
    }
}
