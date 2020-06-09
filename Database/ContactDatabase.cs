using GRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRUD.Database
{
    public interface IContactDatabase
    {
        Contact Insert(Contact contact);
        IEnumerable<Contact> GetContacts();
        Contact GetContacts(int id);
        void Delete(int id);
        void Update(int id, Contact contact);
    }

    public class ContactDatabase : IContactDatabase
    {
        private int _counter;
        private readonly List<Contact> _contact;

        public ContactDatabase()
        {
            if (_contact == null)
            {
                _contact = new List<Contact>();
            }
        }

        public Contact GetContacts(int id)
        {
            return _contact.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _contact;
        }

        public Contact Insert(Contact contact)
        {
            _counter++;
            contact.Id = _counter;
            _contact.Add(contact);
            return contact;
        }

        public void Delete(int id)
        {
            var contact = _contact.SingleOrDefault(x => x.Id == id);
            if (contact != null)
            {
                _contact.Remove(contact);
            }
        }

        public void Update(int id, Contact updatedContact)
        {
            var contact = _contact.SingleOrDefault(x => x.Id == id);
            if (contact != null)
            {
                contact.FirstName = updatedContact.FirstName;
                contact.LastName = updatedContact.LastName;
                contact.Email = updatedContact.Email;
                contact.PhoneNumber = updatedContact.PhoneNumber;
                contact.Adress = updatedContact.Adress;
                contact.Description = updatedContact.Description;
            }
        }
    }
}
