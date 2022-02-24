using EntityDesignerDemo.Data.Contexts;
using EntityDesignerDemo.Data.IRepositories;
using EntityDesignerDemo.Data.Repositories;
using EntityDesignerDemo.Domain.Entities;
using EntityDesignerDemo.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Service.Services
{
    public class TeacherService : ITeacherService
    {
        private IGenericRepository<Teacher> _repo;
        private UniversityDbContext _dbContext;

        public TeacherService()
        {
            _dbContext = new UniversityDbContext();
            _repo = new GenericRepository<Teacher>(_dbContext);
        }
        
        public Task<Teacher> AddTeacherAsync(Teacher teacher)
        {
            return _repo.CreateAsync(teacher);
        }

        public Task<bool> DeleteTeacherAsync(Expression<Func<Teacher, bool>> predicate)
        {
            return _repo.DeleteAsync(predicate);
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachersAsync(Expression<Func<Teacher, bool>> predicate = null)
        {
            return await _repo.GetAllAsync(predicate);
        }

        public Task<Teacher> GetTeacherAsync(Expression<Func<Teacher, bool>> predicate)
        {
            return _repo.GetAsync(predicate);
        }

        public Task<Teacher> UpdateTeacherAsync(Teacher teacher)
        {
            return _repo.UpdateAsync(teacher);
        }
    }
}
