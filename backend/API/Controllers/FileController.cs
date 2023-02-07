using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Services;
using Application.Services.FileService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFileService fileService;
        public FileController(IFileService fileService)
         {
            this.fileService = fileService;
        }

        [HttpPost]
        public IActionResult SaveFile(List<IFormFile> files)
        {
           this.fileService.SaveFile(files);
           return Ok();
        }

         [HttpDelete("id")]
        public IActionResult DeleteFile(Guid id)
        {
           this.fileService.DeleteFile();
           return Ok();
        }
        
    }
}