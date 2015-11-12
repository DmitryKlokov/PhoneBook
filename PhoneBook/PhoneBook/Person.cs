using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace PhoneBook
{
    public class Person
    {
        public string Name;
        public string Surname;
        public List<PhoneNumber> Numbers;
        public List<Email> Emails;
        public List<Address> Addresses;
        public string Description;

        public Person()
        {
            Numbers = new List<PhoneNumber>();
            Emails = new List<Email>();
            Addresses = new List<Address>();
        }

        public override string ToString()
        {
            string str = Name + " " + Surname + " \n";
            str += "\n";
            foreach (var number in Numbers)
            {
                str += number.Name+" " + number.Number+"\n";
            }
            str += "\n";
            foreach (var email in Emails)
            {
                str += email.Name + " " + email.email+ "\n";
            }
            str += "\n";
            foreach (var addess in Addresses)
            {
                str += addess.Name + " " + addess.Value + "\n";
            }
            return str;
        }
    }
}
