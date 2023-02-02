using Domain.Entities;

namespace Application.Services.AssignmentService
{
    public interface IAssignmentService
    {
        Task<List<Assignment>> GetAssignments();
        Task<Assignment> GetAssignmentById(Guid id);
        Task<List<Assignment>> AddAssignment(Assignment assignment);
        Task<List<Assignment>> UpdateAssignment(Guid id, Assignment request);
        Task<List<Assignment>> DeleteAssignment(Guid id);
    }
}