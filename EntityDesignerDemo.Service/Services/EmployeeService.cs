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
    public class EmployeeService : IEmployeeService
    {
        private IGenericRepository<Employee> _repo;
        private UniversityDbContext _dbContext;

        public EmployeeService()
        {
            _dbContext = new UniversityDbContext();
            _repo = new GenericRepository<Employee>(_dbContext);
        }
        public Task<Employee> AddEmployeeAsync(Employee employee)
        {
            return _repo.CreateAsync(employee);
        }

        public Task<bool> DeleteEmployeeAsync(Expression<Func<Employee, bool>> predicate)
        {
            return _repo.DeleteAsync(predicate);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeeAsync(Expression<Func<Employee, bool>> predicate = null)
        {
            return await _repo.GetAllAsync(predicate);
        }

        public Task<Employee> GetEmployeeAsync(Expression<Func<Employee, bool>> predicate)
        {
            return _repo.GetAsync(predicate);
        }

        public Task<Employee> UpdateEmployeeAsync(Employee employee)
        {
            return _repo.UpdateAsync(employee);
        }
    }
}
