using Exam.Core;
using Exam.Data.Contracts;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Data.Repositories
{
    public class ParentsRepo : IParentsRepo
    {
        private readonly ExamContext _context;

        public ParentsRepo(
            ExamContext context)
        {
            _context = context;
        }

        public Task AddParentAsync(Parent parent)
        {
            throw new NotImplementedException();
        }

        public Task DeleteParentAsync(Parent parent)
        {
            throw new NotImplementedException();
        }

        public Task<Parent> GetParentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Parent>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateParentAsync(Parent parent)
        {
            throw new NotImplementedException();
        }
    }
}
