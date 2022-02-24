using System.ComponentModel.DataAnnotations;
using EntityDesignerDemo.Domain.Enums;
using System;


namespace EntityDesignerDemo.Domain.Entities
{
    public abstract class Person : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }
    }
}
