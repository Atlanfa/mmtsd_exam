using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Exam.Root
{
    public static class IocContainer
    {
        public static void InjectDataRepos(this IServiceCollection service, IConfiguration configuration)
        {

        }

        public static void InjectBusinessServices(this IServiceCollection service)
        {

        }
    }
}
