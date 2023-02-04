using Application.Core;
using Application.Services.PhotoService;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Persistence;

namespace Application.Photos
{
    public class Add
    {
        public class Command : IRequest<ServiceResponse<Photo>>
        {
            public IFormFile File { get; set; }
        }

        public class Handler : IRequestHandler<Command, ServiceResponse<Photo>>
        {
            private readonly DataContext _context;
            private readonly IPhotoService _photoService;

            public Handler(DataContext context, IPhotoService photoService)
            {
                _context = context;
                _photoService = photoService;
            }
            public async Task<ServiceResponse<Photo>> Handle(Command request, CancellationToken cancellationToken)
            {
                var photoUploadResult = await _photoService.AddPhoto(request.File);

                var photo = new Photo
                {
                    Url = photoUploadResult.Url,
                    Id = photoUploadResult.PublicId
                };

                var result = await _context.SaveChangesAsync() > 0;
                if(result) return ServiceResponse<Photo>.IsSuccess(photo);
                return ServiceResponse<Photo>.Failure("Problem adding photo");
            }
        }
    }
}