using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PhoneNumber
    {
        public string Name;
        public long Number;

        public PhoneNumber()
        {
        }

        public PhoneNumber(string Name, long Number)
        {
            this.Name = Name;
            this.Number = Number;
        }
    }
}
