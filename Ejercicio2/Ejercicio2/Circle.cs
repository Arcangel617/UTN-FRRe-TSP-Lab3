using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Circle : Shape
    {
        private double radius = 1.0;

        public Circle() { }

        public Circle(double R) 
        {
            Radius = R;
        }

        public Circle(double R, string C, Boolean F)
            : base(C,F)
        {
            Radius = R;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            if (this.isFilled())
            {
                return "Una Círculo de color de " + Color + " y llena";
            }
            else
            {
                return "Una Círculo de color de " + Color + " y vacía";
            }

        }
    }
}
