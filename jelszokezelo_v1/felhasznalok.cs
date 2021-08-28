using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jelszokezelo_v1
{
    public class felhasznalok
    {
        private string nev;
        private string jelszo;
        private string email;
        private string beosztas;

        public felhasznalok(string nev, string jelszo, string email, string beosztas)
        {
            this.nev = nev;
            this.jelszo = jelszo;
            this.email = email;
            this.beosztas = beosztas;
        }

        public string Nev { get => nev;}
        public string Jelszo { get => jelszo; set => jelszo = value;}
        public string Email { get => email; set => email = value; }
        public string Beosztas { get => beosztas; set => beosztas = value; }
    }
}
