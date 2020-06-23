using Exam.Core;
using Exam.Data.Contracts;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Data.Repositories
{
    public class GroupsRepo : IGroupsRepo
    {
        private readonly ExamContext _context;

        public GroupsRepo(
            ExamContext context)
        {
            _context = context;
        }

        public Task AddGroupAsync(Group group)
        {
            throw new NotImplementedException();
        }

        public Task DeleteGroupAsync(Group group)
        {
            throw new NotImplementedException();
        }

        public Task<Group> GetGroupAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Group>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateGroupAsync(Group group)
        {
            throw new NotImplementedException();
        }
    }
}
