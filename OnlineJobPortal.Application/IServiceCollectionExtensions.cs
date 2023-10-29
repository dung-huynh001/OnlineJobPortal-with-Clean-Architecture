using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using OnlineJobPortal.Application.Contracts.Identity;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Linq;

namespace OnlineJobPortal.Application
{
    public static class IServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        public static async Task<PaginatedResult<T>> ToPaginatedListAsync<T>(
            this IEnumerable<T> source, 
            int pageNumber, int pageSize, 
            CancellationToken cancellationToken) where T : class
        {
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            pageSize = pageSize == 0 ? 10 : pageSize;

            int TotalCount = source.Count();


            int TotalPages = TotalCount % pageSize == 0 ?
                TotalCount / pageSize :
                TotalCount / pageSize + 1;

            pageNumber = pageNumber <= 0 ? 1 : pageNumber;

            List<T> items = source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            return PaginatedResult<T>.Create(items, pageNumber, pageSize, TotalCount, TotalPages);
        }
    }
}
