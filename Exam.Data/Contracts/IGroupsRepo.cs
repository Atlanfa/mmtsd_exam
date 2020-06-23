using Exam.Core;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Data.Contracts
{
    public interface IGroupsRepo
    {
        public Task AddGroupAsync(Group group);
        public Task UpdateGroupAsync(Group group);
        public Task DeleteGroupAsync(Group group);
        public Task<IEnumerable<Group>> ToListAsync();
        public Task<Group> GetGroupAsync(int id);
    }
}
