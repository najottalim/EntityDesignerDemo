using EntityDesignerDemo.Data.IRepositories;
using EntityDesignerDemo.Data.Repositories;
using EntityDesignerDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Interfaces.IServices
{
    public interface IStudentService
    {
        Task<Student> AddStudentAsync(Student student);

        Task<Student> UpdateStudentAsync(Student student); 

        Task<bool> DeleteStudentAsync(Expression<Func<Student, bool>> predicate);

        Task<Student> GetStudentAsync(Expression<Func<Student, bool>> predicate);

        Task<IEnumerable<Student>> GetAllStudentsAsync(Expression<Func<Student, bool>> predicate = null);
    }
}
