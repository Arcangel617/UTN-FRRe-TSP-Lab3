using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    class Automovil : Vehiculo, IACTIVO
    {
        public int NroPuertas { get; set; }
        public string Modelo { get; set; }

        public Automovil(string N, string M, double P, int NP, string MOD)
            : base(N, M, P) {
                NroPuertas = NP;
                Modelo = MOD;
        }

        public double precio()
        {
            return base.Precio;
        }

        /*public override string ToString()
        {
            return "[Nombre: ; Marca: ; Precio: ; Nro Puertas: ; Modelo: ]";
        }*/
    }
}
