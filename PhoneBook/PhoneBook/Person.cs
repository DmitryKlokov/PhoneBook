using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person
    {
        public string Name;
        public string Surname;
        public List<PhoneNumber> Numbers;
        public List<Email> Emails;
        public List<Address> Addresses;
        public string Description;

        Person()
        {
            Numbers = new List<PhoneNumber>();
            Emails = new List<Email>();
            Addresses = new List<Address>();
        }
    }
}
