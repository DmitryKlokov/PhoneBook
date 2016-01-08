using System.Collections.Generic;
using System.Data.Entity;
using PhoneBook.Models;

namespace PhoneBook.UOW.Repository
{
    public class PhoneRepository : IRepository<Phone>
    {
        private readonly PBModel _model;

        public PhoneRepository(PBModel db)
        {
            _model = db;
        }

        public IEnumerable<Phone> GetAll()
        {
            return _model.Phones;
        }

        public Phone Get(int id)
        {
            return _model.Phones.Find(id);
        }

        public void Create(Phone item)
        {
            _model.Phones.Add(item);
        }

        public void Update(Phone item)
        {
            _model.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var p = _model.Phones.Find(id);
            if (p != null)
            {
                _model.Phones.Remove(p);
            }
        }
    }
}
