using Exam.Core;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Data.Contracts
{
    public interface IParentsRepo
    {
        public Task AddParentAsync(Parent parent);
        public Task UpdateParentAsync(Parent parent);
        public Task DeleteParentAsync(Parent parent);
        public Task<IEnumerable<Parent>> ToListAsync();
        public Task<Parent> GetParentAsync(int id);
    }
}
