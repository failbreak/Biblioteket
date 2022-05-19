using System;

namespace Bibliotek
{
     class Program
    {
        static void Main(string[] args)
        {
            Bibliotek biblo = new Bibliotek("Sønderborg bibliotek");

            Console.WriteLine(biblo.HentBibliotek());
        }
    }
}
