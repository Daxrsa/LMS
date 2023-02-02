using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services.AssignmentService
{
    public class AssignmentService : IAssignmentService
    {
        private readonly DataContext _context;
        public AssignmentService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Assignment>> AddAssignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();
            return await _context.Assignments.ToListAsync();
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
            return await _context.Assignments.ToListAsync();
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
            return await _context.Assignments.ToListAsync();
        }
    }
}