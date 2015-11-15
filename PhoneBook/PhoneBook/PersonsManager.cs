using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class PersonsManager
    {
        private List<Person> _persons = new List<Person>();

        public void AddNewPerson(string name, string surname, List<Field> phones, List<Field> emails, List<Field> addresses, string description)
        {
            Person p = new Person();
            p.Name = name;
            p.Surname = surname;
            p.Addresses = addresses;
            p.Emails = emails;
            p.Phones = phones;
            p.Description = description;
            _persons.Add(p);
        }
        public void AddNewPerson(Person p)
        {
            _persons.Add(p);
            _persons.Sort();
        }
        
        public Person GetPerson(string nameAndSurname)
        {
            int index = _persons.FindIndex((p) =>p.Name + " " + p.Surname == nameAndSurname);
            if (index >= 0)
            {
                return _persons[index];
            }
            return new Person();
        }

        public List<Person> GetPersons()
        {
            return _persons;
        }


        public void SetPersons(List<Person> persons)
        {
            this._persons = persons;
        }
    }
}
