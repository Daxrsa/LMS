using Domain.Entities;

namespace Application.Services.ExamService
{
    public interface IExamService
    {
        Task<List<Exam>> GetExams();
        Task<Exam> GetExamById(Guid id);
        Task<List<Exam>> AddExam(Exam exam);
        Task<List<Exam>> UpdateExam(Guid id, Exam request);
        Task<List<Exam>> DeleteExam(Guid id);
    }
}
    