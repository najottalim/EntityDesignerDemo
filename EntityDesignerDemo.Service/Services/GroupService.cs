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
    public class GroupService : IGroupService
    {
        private IGenericRepository<Group> _repo;
        private UniversityDbContext _dbContext;

        public GroupService()
        {
            _dbContext = new UniversityDbContext();
            _repo = new GenericRepository<Group>(_dbContext);

        }

        public Task<Group> AddGroupAsync(Group group)
        {
            return _repo.CreateAsync(group);
        }

        public Task<bool> DeleteGroupAsync(Expression<Func<Group, bool>> predicate)
        {
            return _repo.DeleteAsync(predicate);
        }

        public async Task<IEnumerable<Group>> GetAllGroupsAsync(Expression<Func<Group, bool>> predicate = null)
        {
            return await _repo.GetAllAsync(predicate);
        }

        public Task<Group> GetGroupAsync(Expression<Func<Group, bool>> predicate)
        {
            return _repo.GetAsync(predicate);
        }

        public Task<Group> UpdateGroupAsync(Group group)
        {
            return _repo.UpdateAsync(group);
        }
    }
}
