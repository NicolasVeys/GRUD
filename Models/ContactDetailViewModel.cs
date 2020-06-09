using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRUD.Models
{
    public class ContactDetailViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
    }
}
