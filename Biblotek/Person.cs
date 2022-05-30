using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Person
    {
        string _navn;
        string _email;

        public string Navn { get { return _navn; } }
        public string Email { get { return _email; } }
        public Person(string navn, string email)
        {
            this._navn = navn;
            this._email = email;

        }
    }
}

