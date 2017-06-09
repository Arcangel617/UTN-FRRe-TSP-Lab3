using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Visit
    {
        private Customer customer;
        private DateTime date;
        private double serviceExpense;
        private double productExpense;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double ServiceExpense
        {
            get { return serviceExpense; }
            set { serviceExpense = value; }
        }

        public double ProductExpense
        {
            get { return productExpense; }
            set { serviceExpense = value; }
        }

        public Visit(string N, DateTime D)
        {
            Customer = new Customer(N);
            Date = DateTime.Now;
        }

        public double getTotalExpense()
        {
            return 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
