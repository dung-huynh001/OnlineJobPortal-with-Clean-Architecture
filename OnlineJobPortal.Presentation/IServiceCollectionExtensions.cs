using System.Reflection;

namespace OnlineJobPortal.Presentation
{
    public static class IServiceCollectionExtensions
    {
        public static void AddPresentation(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
