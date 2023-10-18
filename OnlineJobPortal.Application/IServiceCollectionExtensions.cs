using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Application.Interfaces;

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
