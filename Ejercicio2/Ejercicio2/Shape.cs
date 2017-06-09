using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Shape
    {
        private string color = "red";
        private Boolean filled = true;

        public Shape() { }

        public Shape(string C, Boolean F)
        {
            Color = C;
            Filled = F;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Boolean Filled
        {
            set { filled = value; }
        }

        public Boolean isFilled()
        {
            return filled;
        }


        public override string ToString()
        {
            if (this.isFilled())
            {
                return "Una figura de color de " + Color + " y llena";
            }
            else {
                return "Una figura de color de " + Color + " y vacía";
            }
            
        }
    }
}
