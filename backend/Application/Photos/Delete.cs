using Application.Core;
using Application.Services.PhotoService;
using MediatR;
using Persistence;

namespace Application.Photos
{
    public class Delete
    {
        public class Command : IRequest<ServiceResponse<Unit>>
        {
            public string Id { get; set; }
        }

        public class Handler : IRequestHandler<Command, ServiceResponse<Unit>>
        {
            private readonly DataContext _context;
            private readonly IPhotoService _photoService;

            public Handler(DataContext context, IPhotoService photoService)
            {
                _context = context;
                _photoService = photoService;
            }
            public async Task<ServiceResponse<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var photo = await _context.Photos.FindAsync(request.Id);

                if(photo == null) return null;

                var result = await _photoService.DeletePhoto(photo.Id);

                if(result == null) return ServiceResponse<Unit>.Failure("Cannot delete photo from Cloudinary");

                _context.Photos.Remove(photo);

                var success = await _context.SaveChangesAsync() > 0;

                if(success) return ServiceResponse<Unit>.IsSuccess(Unit.Value);

                return ServiceResponse<Unit>.Failure("Cannot delete photo from API");
            }
        }
    }
}