using System.Collections.Generic;
using System.Data.Entity;
using PhoneBook.Models;

namespace PhoneBook.UOW.Repository
{
    public class AddressRepository : IRepository<Address>
    {
        private readonly PBModel _model;

        public AddressRepository(PBModel db)
        {
            _model = db;
        }

        public IEnumerable<Address> GetAll()
        {
            return _model.Addresses;
        }

        public Address Get(int id)
        {
            return _model.Addresses.Find(id);
        }

        public void Create(Address item)
        {
            _model.Addresses.Add(item);
        }

        public void Update(Address item)
        {
            _model.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var p = _model.Addresses.Find(id);
            if (p != null)
            {
                _model.Addresses.Remove(p);
            }
        }
    }
}
