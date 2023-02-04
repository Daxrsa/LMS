using Application.Photos;
using Microsoft.AspNetCore.Http;

namespace Application.Services.PhotoService
{
    public interface IPhotoService
    {
        Task<PhotoUploadResult> AddPhoto(IFormFile file);
        Task<string> DeletePhoto(string publicId); //maybe Guid?
    }
}