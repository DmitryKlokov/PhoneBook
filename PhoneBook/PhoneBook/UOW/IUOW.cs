using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBook.UOW.Repository;

namespace PhoneBook.UOW
{
    internal interface IUow
    {
        PersonRepository Persons { get; }
        EmailRepository Emails { get; }
        PhoneRepository Phones { get; }
        AddressRepository Addresses { get; }

        void Save();

        void Dispose(bool disposing);

        void Dispose();
    }
}
