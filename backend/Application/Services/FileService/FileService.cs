using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Factory;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services.FileService
{
    public class FileService : IFileService
    {
        public async Task<bool> SaveFile(List<IFormFile> files)
        {
            foreach (IFormFile file in files)
            {
                Media myMedia = FileFactory.CorrectFile(file.ContentType);

                // if(file.ContentType.Equals("application/pdf") || file.ContentType.Equals("application/msword")) {

                //      myMedia = new Media();
                // }

                var filePath = Path.GetTempFileName();

                using (var stream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(stream);
                }
            }
            return false;
        }

        public async Task<bool> DeleteFile()
        {
            return false;
        }
    }
}