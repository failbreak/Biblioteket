using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner : Person
    {
        int _laanerNummer;
       
        public int LaanerNummer { get { return _laanerNummer; } }

        public Laaner(string Navn, int LaanerNummer, string email) : base(Navn , email)
         {
            
            this._laanerNummer = LaanerNummer;
         }

       


    }
   
}
