using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Console.WriteLine(s);

            Shape c = new Circle();
            Console.WriteLine(c);

            Shape r = new Rectangle();
            Console.WriteLine(r);

            Shape cdo = new Square();
            Console.WriteLine(cdo);

            Console.WriteLine("==========================================");

            Shape s1 = new Shape("Green",false);
            Console.WriteLine(s1);
            s1.Color = "Blue";
            s1.Filled = true;
            Console.WriteLine(s1);

            Console.WriteLine("==========================================");
            
            Shape c1 = new Circle(2.5);
            Console.WriteLine(c1);
            c1.Color = "Black";
            c1.Filled = true;
            Console.WriteLine(c1);

            Console.WriteLine("==========================================");

            Shape r1 = new Rectangle(3,4);
            Console.WriteLine(r1);
            r1.Color = "Black";
            r1.Filled = true;
            Console.WriteLine(r1);

            Shape cdo1 = new Square();
            Console.WriteLine(cdo1);
            c1.Color = "Black";
            c1.Filled = true;

            Console.ReadKey();
        }
    }
}
