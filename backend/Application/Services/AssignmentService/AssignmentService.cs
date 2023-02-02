using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services.AssignmentService
{
    public class AssignmentService : IAssignmentService
    {
        private static List<Assignment> assignments = new List<Assignment>
            {
                new Assignment
                {
                    Id = Guid.Parse("9484bf72-9988-4a66-962d-9176f0f18b4d"),
                    DateCreated = DateTime.Parse("12/07/2023 23:00"),
                    DateDeleted = DateTime.Parse("12/07/2023 23:00"),
                    Deadline = DateTime.Parse("12/07/2023 23:00")
                },
                new Assignment
                {
                    Id = Guid.Parse("1302349e-2b57-47f6-8e4a-18147e49b5ba"),
                    DateCreated = DateTime.Parse("12/07/2023 23:00"),
                    DateDeleted = DateTime.Parse("12/07/2023 23:00"),
                    Deadline = DateTime.Parse("12/07/2023 23:00")
                },
                new Assignment
                {
                    Id = Guid.Parse("57147200-36cc-49e6-9ed4-286e8d2b6ac3"),
                    DateCreated = DateTime.Parse("12/07/2023 23:00"),
                    DateDeleted = DateTime.Parse("12/07/2023 23:00"),
                    Deadline = DateTime.Parse("12/07/2023 23:00")
                }
            };
        private readonly DataContext _context;
        public AssignmentService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Assignment>> AddAssignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();
            return assignments;
        }

        public async Task<List<Assignment>> DeleteAssignment(Guid id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment is null)
            {
                return null;
            }
            _context.Assignments.Remove(assignment);
            await _context.SaveChangesAsync();
            return assignments;
        }

        public async Task<Assignment> GetAssignmentById(Guid id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment is null)
            {
                return null;
            }
            return assignment;
        }

        public async Task<List<Assignment>> GetAssignments()
        {
            var assignments = await _context.Assignments.ToListAsync();
            return assignments;
        }

        public async Task<List<Assignment>> UpdateAssignment(Guid id, Assignment request)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment is null)
            {
                return null;
            }
            assignment.DateCreated = request.DateCreated;
            assignment.DateDeleted = request.DateDeleted;
            assignment.Deadline = request.Deadline;
            await _context.SaveChangesAsync();
            return assignments;
        }
    }
}