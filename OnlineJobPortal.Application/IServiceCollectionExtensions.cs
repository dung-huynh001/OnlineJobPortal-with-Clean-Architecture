using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace OnlineJobPortal.Application
{
    public static class IServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
