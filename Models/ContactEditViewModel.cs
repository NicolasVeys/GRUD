using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRUD.Models
{
    public class ContactEditViewModel
    {
        public int Id { get; set; }


        [DisplayName("Voornaam*")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "VERLICHT")]
        [MaxLength(25, ErrorMessage = "Maximum 25 karakters")]
        public string FirstName { get; set; }


        [DisplayName("Famillienaam*")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "VERLICHT")]
        [MaxLength(25, ErrorMessage = "Maximum 25 karakters")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }


        [EmailAddress(ErrorMessage = "EMAILADRES NET JUIST")]
        public string Email { get; set; }

        public int PhoneNumber { get; set; }


        public string Adress { get; set; }


        [MaxLength(250, ErrorMessage = "Maximum 250 karakters")]
        public string Description { get; set; }

        public IFormFile ImageName { get; set; }

    }

}

