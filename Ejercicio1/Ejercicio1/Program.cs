using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author("Cacho Nakamura", "cacho@nakamura.com", 'M');
            Book b1 = new Book("Aprende a programar en 21 dias", a, 290);

            Book b2 = new Book("Aprende a programar en 21 semanas", a, 220, 10);

            Console.WriteLine(b1);
            Console.WriteLine(b2);

            Console.ReadKey();
        }
    }
}
