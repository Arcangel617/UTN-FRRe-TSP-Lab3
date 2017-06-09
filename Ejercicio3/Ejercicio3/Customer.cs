using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Customer
    {
        private string name;
        private Boolean member = false;
        private string memberType;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Boolean Member
        {
            get { return member; }
            set { member = value; }
        }

        public string MemberType
        {
            get { return memberType; }
            set { memberType = value; }
        }

        public Customer(string N)
        {
            Name = Name;
        }

        public Boolean isMember()
        {
            return Member;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
