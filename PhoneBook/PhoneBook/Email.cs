using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Email
    {
        public string Name;
        public string email;

        public Email()
        {
        }

        public Email(string Name, string email)
        {
            this.Name = Name;
            this.email = email;
        }
    }
}
