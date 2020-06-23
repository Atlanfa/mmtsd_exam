using Exam.Core;

using Microsoft.EntityFrameworkCore;

namespace Exam.Data
{
    public class ExamContext : DbContext
    {
        public DbSet<Child> Children { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Group> Groups { get; set; }

        public ExamContext(DbContextOptions<ExamContext> options)
            : base(options) { }
    }
}
