using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Rectangle : Shape
    {
        private double width = 1.0;
        private double length = 1.0;

        public Rectangle() { }

        public Rectangle(double W, double H)
        {
            Width = W;
            Length = Length;
        }

        public Rectangle(double W, double H, string C, Boolean F)
            : base(C,F)
        {
            Width = W;
            Length = Length;
        }
        
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }

        public override string ToString()
        {
            if (this.isFilled())
            {
                return "Una Rectángulo de color de " + Color + " y llena";
            }
            else
            {
                return "Una Rectángulo de color de " + Color + " y vacía";
            }

        }
    }
}
