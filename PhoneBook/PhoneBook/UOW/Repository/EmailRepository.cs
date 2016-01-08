using System.Collections.Generic;
using System.Data.Entity;
using PhoneBook.Models;

namespace PhoneBook.UOW.Repository
{
    public class EmailRepository : IRepository<Email>
    {
        private readonly PBModel _model;

        public EmailRepository(PBModel db)
        {
            _model = db;
        }

        public IEnumerable<Email> GetAll()
        {
            return _model.Emails;
        }

        public Email Get(int id)
        {
            return _model.Emails.Find(id);
        }

        public void Create(Email item)
        {
            _model.Emails.Add(item);
        }

        public void Update(Email item)
        {
            _model.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var p = _model.Emails.Find(id);
            if (p != null)
            {
                _model.Emails.Remove(p);
            }
        }
    }
}
