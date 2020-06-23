using Exam.Core;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Exam.Data.Contracts
{
    public interface IChildrensRepo
    {
        public Task AddChildAsync(Child child);
        public Task UpdateChildAsync(Child child);
        public Task DeleteChildAsync(Child child);
        public Task<IEnumerable<Child>> ToListAsync();
        public Task<Child> GetChildAsync(int id);
    }
}
