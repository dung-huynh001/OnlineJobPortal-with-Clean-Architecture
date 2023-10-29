﻿using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface IProvinceRepository : IGenericRepository<Province>
    {
        Task<string> GetProvinceNameById(int id);
    }
}
