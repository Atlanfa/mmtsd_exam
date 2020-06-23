using Exam.Core;
using Exam.Data.Contracts;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Data.Repositories
{
    public class ChildrensRepo : IChildrensRepo
    {
        private readonly ExamContext _context;

        public ChildrensRepo(
            ExamContext context)
        {
            _context = context;
        }

        public Task AddChildAsync(Child child)
        {
            throw new NotImplementedException();
        }

        public Task DeleteChildAsync(Child child)
        {
            throw new NotImplementedException();
        }

        public Task<Child> GetChildAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Child>> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateChildAsync(Child child)
        {
            throw new NotImplementedException();
        }
    }
}
