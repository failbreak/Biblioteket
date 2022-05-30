using System;

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

            bool a = int.TryParse(Console.ReadLine(), out int sUserIn);
            if (!a)
            {
                Console.WriteLine("Indtast et nummer som er i menuen");

            }

            switch (sUserIn)
            {
                case 1:
                    Console.WriteLine(biblo.HentBibliotek());

                    break;

                case 2:

                        Console.Write("Opret låner: Navn: ");
                        string n = Console.ReadLine();
                       
                        biblo.OpretLaaner(n);
                    break;

                case 3:

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
