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
           
           return string.Format("velkommen til {0}. klokken er: {1}", bibliotek, DateTime.Now.ToString("HH:mm:ss"));
            
        }
    }
}




