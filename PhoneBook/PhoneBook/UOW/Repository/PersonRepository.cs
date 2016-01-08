using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using PhoneBook.Models;

namespace PhoneBook.UOW.Repository
{
    public class PersonRepository:IRepository<Person>
    {
        private readonly PBModel _model;

        public PersonRepository(PBModel db)
        {
            _model = db;
        }

        public IEnumerable<Person> GetAll()
        {
            return _model.People;
        }

        public Person Get(int id)
        {
            return _model.People.Find(id);
        }

        public void Create(Person item)
        {
            _model.People.Add(item);
        }

        public void Update(Person item)
        {
            _model.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var p = _model.People.Find(id);
            _model.People.Remove(p);
        }
    }
}
