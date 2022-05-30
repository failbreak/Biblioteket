using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    class Laaner
    {
        int _laanerNummer;
        string _navn;

        public int LaanerNummer { get { return _laanerNummer; } }
       public string Navn { get { return _navn; } }

        public Laaner(string Navn, int LaanerNummer)
         {
            this._navn = Navn;

            this._laanerNummer = LaanerNummer;
         }



    }
}
