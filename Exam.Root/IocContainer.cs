using Exam.Data;
using Exam.Data.Contracts;
using Exam.Data.Repositories;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.Root
{
    public static class IocContainer
    {
        public static void InjectDataRepos(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ExamContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlConnectionString"));
            });
            service.AddTransient<IChildrensRepo, ChildrensRepo>();
            service.AddTransient<IParentsRepo, ParentsRepo>();
            service.AddTransient<IGroupsRepo, GroupsRepo>();
        }

        public static void InjectBusinessServices(this IServiceCollection service)
        {

        }
    }
}
