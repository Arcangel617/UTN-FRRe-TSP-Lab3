using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v = new Vehiculo("Automovil", "Ford", 299000);
            Avion av = new Avion("Avion", "Jet", 299000, 80, "Charter");
            Automovil au = new Automovil("Automovil", "Volkswagen", 299000, 4, "Trend");

            Console.WriteLine(v);
            Console.WriteLine(av);
            Console.WriteLine(au);
            Console.ReadKey();
        }
    }
}
