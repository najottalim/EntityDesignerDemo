using EntityDesignerDemo.Data.Contexts;
using EntityDesignerDemo.Data.IRepositories;
using EntityDesignerDemo.Data.Repositories;
using EntityDesignerDemo.Domain.Entities;
using EntityDesignerDemo.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Service.Services
{
    public class StudentService : IStudentService
    {
        private IGenericRepository<Student> _repo;
        private UniversityDbContext _dbContext;

        public StudentService()
        {
            _dbContext = new UniversityDbContext();
            _repo = new GenericRepository<Student>(_dbContext);
        }

        public Task<Student> AddStudentAsync(Student student)
        {
            return _repo.CreateAsync(student);
        }

        public Task<bool> DeleteStudentAsync(Expression<Func<Student, bool>> predicate)
        {
            return _repo.DeleteAsync(predicate);
        }

        public async Task<IEnumerable<Student>> GetAllStudentsAsync(Expression<Func<Student, bool>> predicate = null)
        {
            return await _repo.GetAllAsync(predicate);
        }

        public Task<Student> GetStudentAsync(Expression<Func<Student, bool>> predicate)
        {
            return _repo.GetAsync(predicate);
        }

        public Task<Student> UpdateStudentAsync(Student student)
        {
            return _repo.UpdateAsync(student);
        }
    }
}
