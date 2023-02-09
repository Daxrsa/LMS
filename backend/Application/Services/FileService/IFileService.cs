using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;

namespace Application.Services.FileService
{
    public interface IFileService
    {
         Task<bool> SaveFile(List<IFormFile>files);

         Task<bool> DeleteFile();

    }
}