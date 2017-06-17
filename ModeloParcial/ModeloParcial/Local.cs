using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    class Local : IACTIVO
    {
        private string direccion;
        private string categoria;
        private double price;

        public Local(string D, string C, double P)
        {
            Direccion = D;
            Categoria = C;
            Precio = P;
        }

        public string Direccion 
        {
            set { direccion = value; }
        }

        public string Categoria
        {
            set { categoria = value; }
        }

        public double Precio
        {
            set { price = value; }
        }

        public double precio()
        {
            return price;
        }

        public void arrancar() { }
    }
}
