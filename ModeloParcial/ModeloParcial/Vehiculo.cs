using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    class Vehiculo
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }

        public Vehiculo(string N, string M, double P)
        {
            Nombre = N;
            Marca = M;
            Precio = P;
        }

        public override string ToString()
        {
            return "[Nombre: "+Nombre+"; Marca: "+Marca+"; Precio: $"+Precio+"]";
        }

        public void arrancar() { }
    }
}
