using Domain.Entities;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Courses
{
    public class Create
    {
        public class Command : IRequest
        {
            public Course Course { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Courses.Add(request.Course);

                await _context.SaveChangesAsync();

                return Unit.Value;
            }
        }

    }
}
