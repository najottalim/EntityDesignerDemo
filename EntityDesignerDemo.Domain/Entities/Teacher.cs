using EntityDesignerDemo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Domain.Entities
{
    public class Teacher : Employee
    {
        public Subject Subject { get; set; }
         
        public virtual ICollection<Group> Groups { get; }

        public Teacher()
        {
            Groups = new List<Group>();
        }
    }
}
