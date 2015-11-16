using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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


        public void Serialize()
        {
            var fs = new FileStream("PhoneBook.xml", FileMode.Create);
            var serializer = new XmlSerializer(typeof(List<Person>));
            serializer.Serialize(fs, _persons);
            fs.Close();
        }
        private void Deserialize()
        {
            var fs = new FileStream("PhoneBook.xml", FileMode.Open);
            var serializer = new XmlSerializer(typeof(List<Person>));
            _persons=(List<Person>)serializer.Deserialize(fs);
            fs.Close();
        }

        public PersonsManager()
        {
            Deserialize();
        }
    }
}
