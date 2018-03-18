using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistrationPortal.Models
{
    public class Person:EntityBase
    {
        [Key]
        [Required]
        public int PersonId { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string FatherName { get; set; }

        public string GrandFatherName { get; set; }

        [Required]
        public string CitizenshipNumber { get; set; }

    }
}