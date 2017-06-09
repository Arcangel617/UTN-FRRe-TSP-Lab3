using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Author
    {
        private string name;
        private string email;
        private char gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Author(string N, string E, char G)
        {
            Name = N;
            Email = E;
            Gender = G;
        }

        public override string ToString()
        {
            return "Autor[Nombre: " + Name + ", Email: " + Email + ", Genero:" + Gender + "]";
        }
    }
}
