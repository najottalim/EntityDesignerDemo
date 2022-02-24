using EntityDesignerDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Service.Interfaces
{
    public interface ITeacherService
    {
        Task<Teacher> AddTeacherAsync(Teacher teacher);

        Task<Teacher> UpdateTeacherAsync(Teacher teacher);

        Task<bool> DeleteTeacherAsync(Expression<Func<Teacher, bool>> predicate);

        Task<Teacher> GetTeacherAsync(Expression<Func<Teacher, bool>> predicate);

        Task<IEnumerable<Teacher>> GetAllTeachersAsync(Expression<Func<Teacher, bool>> predicate = null);
    }
}
