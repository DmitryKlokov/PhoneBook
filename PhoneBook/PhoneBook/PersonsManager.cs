using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace PhoneBook
{
    public class PersonsManager
    {
        private List<Person> _persons = new List<Person>();
        
        public void AddNewPerson(Person p)
        {
            _persons.Add(p);
            _persons.Sort();
            Serialize();
        }

        public Person GetPerson(string nameAndSurname)
        {
            var index = _persons.FindIndex(p =>p.Name + " " + p.Surname == nameAndSurname);
            return index >= 0 ? _persons[index] : new Person();
        }

        public void RemovePerson(Person p)
        {
            _persons.Remove(p);
            Serialize();
        }

        public List<Person> GetPersons()
        {
            return _persons;
        }

        public bool Exists(Person person)
        {
            return _persons.Any(p => p.Id == person.Id);
        }

        public void Serialize()
        {
            using (var stream = new FileStream("file1.data", FileMode.Create))
            {
                var ser = new BinaryFormatter();
                ser.Serialize(stream, _persons);
            }

        }

        public void Deserialize()
        {
            using (var stream = new FileStream("file1.data", FileMode.Open))
            {
                var ser = new BinaryFormatter();
                _persons = ser.Deserialize(stream) as List<Person>;
            }

        }

        public PersonsManager()
        {
            Deserialize();
        }
    }
}
