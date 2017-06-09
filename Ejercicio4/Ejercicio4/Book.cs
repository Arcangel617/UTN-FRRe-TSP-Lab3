using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Book
    {
        private string name;
        private Author[] authors;
        private double price;
        private int qty = 0;

        public Book(string N, Author[] A, double P)
        {
            Name = N;
            Authors = A;
            Price = P;
        }

        public Book(string N, Author A, double P, int Q)
        {
            Name = N;
            Author = A;
            Price = P;
            Qty = Q;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Author[] Authors
        {
            get { return authors; }
            set { authors = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }

        public override string ToString()
        {
            return "Libro[Nombre:" + Name + ", " + Author + ", Precio: $" + Price + ", Cantidad:" + Qty + "]";
        }
    }
}
