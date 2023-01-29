using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Courses
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Course Course { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var course = await _context.Courses.FindAsync(request.Course.Id);

                _mapper.Map(request.Course, course);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }
    }
}