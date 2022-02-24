using System;
using System.Collections.Generic;


namespace EntityDesignerDemo.Domain.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; }

        public DateTime OpenedDate { get; set; }

        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>(); 
        }
    }
}
