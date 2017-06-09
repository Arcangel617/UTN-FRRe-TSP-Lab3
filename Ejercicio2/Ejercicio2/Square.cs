using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Square : Rectangle
    {
        public Square() { }
        public Square(double S) { }
        public Square(double S, string C, Boolean F)
            : base(S, S, C, F) { }

        public double Side {
            get { return base.Length; }
            set { 
                base.Length = value;
                base.Width = value;
            }
        }

        public override string ToString()
        {
            if (this.isFilled())
            {
                return "Una Cuadrado de color de " + Color + " y llena";
            }
            else
            {
                return "Una Cuadrado de color de " + Color + " y vacía";
            }

        }
    }
}
