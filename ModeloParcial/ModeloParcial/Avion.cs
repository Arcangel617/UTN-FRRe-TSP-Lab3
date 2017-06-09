using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    class Avion : Vehiculo, IACTIVO
    {
        public int NumAsientos { get; set; }
        public string Categoría { get; set; }

        public Avion (string N, string M, double P, int NA, string C)
            : base (N, M, P){
                NumAsientos = NA;
                Categoría = C;
        }

        public double precio()
        {
            return base.Precio;
        }

        /*public override string ToString()
        {
            return "[Nombre: ; Marca: ; Precio: ; Nro Asientos: ; Categoría: ]";
        }*/

    }
}
