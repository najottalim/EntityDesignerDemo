using EntityDesignerDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Service.Interfaces
{
    public interface IGroupService
    {
        Task<Group> AddGroupAsync(Group group);

        Task<Group> UpdateGroupAsync(Group group);

        Task<bool> DeleteGroupAsync(Expression<Func<Group, bool>> predicate);

        Task<Group> GetGroupAsync(Expression<Func<Group, bool>> predicate);

        Task<IEnumerable<Group>> GetAllGroupsAsync(Expression<Func<Group, bool>> predicate = null);
    }
}
