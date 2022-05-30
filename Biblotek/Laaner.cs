using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Laaner
    {
        int LaanerNummer { get; }
        string Navn { get; }

        public Laaner(string Navn, int LaanerNummer)
         {
            this.Navn = Navn;

            this.LaanerNummer = LaanerNummer;
         }



    }
}
