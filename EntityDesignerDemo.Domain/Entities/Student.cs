using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Domain.Entities
{
    public class Student: Person
    {
        public virtual Group Group { get; }
    }
}
