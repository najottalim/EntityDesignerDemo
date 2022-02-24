using EntityDesignerDemo.Domain.Enums;
using System;


namespace EntityDesignerDemo.Domain.Entities
{
    public class Employee: Person
    {
        public int Experence { get; set; }

        public DateTime StartedDate { get; set; }

        public string CardNumber { get; set; }

        public Department Dapartment { get; set; }
    }
}
