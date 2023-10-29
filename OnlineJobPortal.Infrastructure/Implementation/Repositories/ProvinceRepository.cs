using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation.Repositories
{
    public class ProvinceRepository : GenericRepository<Province>, IProvinceRepository
    {
        private readonly ApplicationDbContext context;

        public ProvinceRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<string> GetProvinceNameById(int id)
        {
            var province = context.Provinces.Find(id);
            return province.ProvinceName;
        }
    }
}
