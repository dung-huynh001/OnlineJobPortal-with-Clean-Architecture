using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Query.Internal;
using OnlineJobPortal.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation
{
    public class UploadService : IUploadService
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public UploadService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        public async Task<string> UploadImageAsync(IFormFile imageFile, string uploadPath)
        {
            if (imageFile == null || imageFile.Length == 0)
            {
                return null;
            }

            string uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;

            // Combine the upload path and unique file name
            string filePath = Path.Combine(webHostEnvironment.WebRootPath, uploadPath, uniqueFileName);

            // Save the file to the server
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await imageFile.CopyToAsync(fileStream);
            }

            string fullPath = Path.Combine(uploadPath, uniqueFileName);
            string webRootPath = webHostEnvironment.WebRootPath;

            // Tìm vị trí của web root path trong đường dẫn
            int index = fullPath.IndexOf(webRootPath);

            // Cắt đường dẫn để chỉ lấy phần sau và loại bỏ web root path
            string relativePath = "~" + fullPath.Substring(index + webRootPath.Length);

            // Thay thế ký tự '\' bằng '/' để đảm bảo chuỗi là đường dẫn web
            relativePath = relativePath.Replace("\\", "/");

            return relativePath;
        }
    }
}
