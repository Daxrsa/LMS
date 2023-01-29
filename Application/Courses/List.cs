using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Courses
{
    public class List
    {        
        public class Query : IRequest<List<Course>> { }

        public class Handler : IRequestHandler<Query, List<Course>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Course>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Courses.ToListAsync();
            }
        }
    }
}
