using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IUploadService
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string uploadPath);
    }
}
