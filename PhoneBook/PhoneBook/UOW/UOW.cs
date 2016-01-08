using System;
using PhoneBook.Models;
using PhoneBook.UOW.Repository;

namespace PhoneBook.UOW
{
    public class Uow:IUow
    {
        private readonly PBModel _model = new PBModel();


        private PersonRepository _persons;
        private EmailRepository _emails;
        private PhoneRepository _phones;
        private AddressRepository _addresses;

        //get { if (имяRepository == null) имяRepository = new ИмяRepository(db); return имяRepository; } пояснение 
        public PersonRepository Persons => _persons ?? (_persons = new PersonRepository(_model));
        public EmailRepository Emails => _emails ?? (_emails = new EmailRepository(_model));
        public PhoneRepository Phones => _phones ?? (_phones = new PhoneRepository(_model));
        public AddressRepository Addresses => _addresses ?? (_addresses = new AddressRepository(_model));



        public void Save()
        {
            _model.SaveChanges();
        }

        private bool _disposed;

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _model.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
