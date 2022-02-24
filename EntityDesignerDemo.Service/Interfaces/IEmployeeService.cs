using EntityDesignerDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<Employee> AddEmployeeAsync(Employee employee);

        Task<Employee> UpdateEmployeeAsync(Employee employee);

        Task<bool> DeleteEmployeeAsync(Expression<Func<Employee, bool>> predicate);

        Task<Employee> GetEmployeeAsync(Expression<Func<Employee, bool>> predicate);

        Task<IEnumerable<Employee>> GetAllEmployeeAsync(Expression<Func<Employee, bool>> predicate = null);
    }
}
