using Microsoft.AspNetCore.Mvc;
using GRUD.Database;
using GRUD.Domain;
using GRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace GRUD.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactDatabase _contactDatabase;
        public ContactController(IContactDatabase contactDatabase)
        {
            _contactDatabase = contactDatabase;
        }
        public IActionResult Index()
        {
            IEnumerable<Contact> contactsFromDb = _contactDatabase.GetContacts();
            List<ContactListViewModel> contacts = new List<ContactListViewModel>();
            foreach (Contact contact in contactsFromDb)
            {
                contacts.Add(new ContactListViewModel()
                {
                    Id = contact.Id,
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    DateOfBirth = contact.DateOfBirth,
                    Email = contact.Email,
                    PhoneNumber = contact.PhoneNumber,
                    Adress = contact.Adress,
                });
            }
            return View(contacts);
        }

        public IActionResult Create()
        {
            ContactCreateViewModel contact = new ContactCreateViewModel()
            {
                FirstName = "Nicolas",
                LastName = "Veys",
                //dateofbirth
                Email = "nicolas@voorbeeld.be",
                PhoneNumber = 123465789,
                Adress = "Brugge",
                Description = "Beschrijving"
            };

            return View(contact);
        }

        [HttpPost]
        public IActionResult Create(ContactCreateViewModel newContact)
        {
            if (!TryValidateModel(newContact))
            {
                return View(newContact);
            }

            byte[] file;

            if (newContact.ImageName != null)
            {
                file = GetBytesFromFile(newContact.ImageName);
            }
            else
            {
                file = new byte[] { };
            }
            _contactDatabase.Insert(new Contact
            {
                FirstName = newContact.FirstName,
                LastName = newContact.LastName,
                DateOfBirth = newContact.DateOfBirth,
                Email = newContact.Email,
                PhoneNumber = newContact.PhoneNumber,
                Adress = newContact.Adress,
                Description = newContact.Description,
                Category = newContact.Category,
                ImageName = file
            });



            return RedirectToAction("index");
        }


        public IActionResult Details(int id)
        {
            Contact contactFromDb = _contactDatabase.GetContacts(id);
            ContactDetailViewModel contact = new ContactDetailViewModel()
            {
                FirstName = contactFromDb.FirstName,
                LastName = contactFromDb.LastName,
                DateOfBirth = contactFromDb.DateOfBirth,
                Email = contactFromDb.Email,
                PhoneNumber = contactFromDb.PhoneNumber,
                Adress = contactFromDb.Adress,
                Description = contactFromDb.Description,
                ImageName = contactFromDb.ImageName,
                Category = contactFromDb.Category
            };
            return View(contact);
        }

        public IActionResult Edit(int id)
        {
            Contact contactFromDb = _contactDatabase.GetContacts(id);
            ContactEditViewModel vm = new ContactEditViewModel
            {
                FirstName = contactFromDb.FirstName,
                LastName = contactFromDb.LastName,
                DateOfBirth = contactFromDb.DateOfBirth,
                Email = contactFromDb.Email,
                PhoneNumber = contactFromDb.PhoneNumber,
                Adress = contactFromDb.Adress,
                Description = contactFromDb.Description,
                Category = contactFromDb.Category
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(int id,ContactEditViewModel vm)
        {
            if (!TryValidateModel(vm))
            {
                return View(vm);
            }

            Contact domainContact = new Contact()
            {
                Id = id,
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                DateOfBirth = vm.DateOfBirth,
                Email = vm.Email,
                PhoneNumber = vm.PhoneNumber,
                Adress = vm.Adress,
                Description = vm.Description,
                Category = vm.Category
            };
            _contactDatabase.Update(id, domainContact);

            return RedirectToAction("details", new { Id = id });
        }
        public IActionResult Delete(int id)
        {
            Contact contactFromDb = _contactDatabase.GetContacts(id);
            ContactDeleteViewModel contact = new ContactDeleteViewModel()
            {
                Id = id,
                FirstName = contactFromDb.FirstName,
                LastName = contactFromDb.LastName
            };
            return View(contact);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            _contactDatabase.Delete(id);
            return RedirectToAction("");
        }

        public Byte[] GetBytesFromFile(IFormFile file)
        {
            var extension = new FileInfo(file.FileName).Extension;
            if (extension == ".jpg" || extension == ".png" || extension == ".PNG")
            {
                using var memoryStream = new MemoryStream();
                file.CopyTo(memoryStream);

                return memoryStream.ToArray();
            }
            else
            {
                return new byte[] { };
            }
        }
    }
}

