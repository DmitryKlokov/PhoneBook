using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Address
    {
        public string Name;
        public string Value;

        public Address()
        {
        }

        public Address(string Name, string Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
    }
}
