using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Services.ExamService
{
    public class ExamService : IExamService
    {
        private readonly DataContext _context;
        public ExamService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Exam>> AddExam(Exam exam)
        {
            _context.Exam.Add(exam);
            await _context.SaveChangesAsync();
            return await _context.Exam.ToListAsync();
        }

        public async Task<List<Exam>> DeleteExam(Guid id)
        {
            var exam = await _context.Exam.FindAsync(id);
            if (exam is null)
            {
                return null; //make a custom API response class for this
            }
            _context.Exam.Remove(exam);
            await _context.SaveChangesAsync();
            return await _context.Exam.ToListAsync();
        }

        public async Task<Exam> GetExamById(Guid id)
        {
            var exam = await _context.Exam.FindAsync(id);
            if (exam is null)
            {
                return null;
            }
            return exam;
        }

        public async Task<List<Exam>> GetExams()
        {
            var exams = await _context.Exam.ToListAsync();
            return exams;
        }

        public async Task<List<Exam>> UpdateExam(Guid id, Exam request)
        {
            var exam = await _context.Exam.FindAsync(id);
            if (exam is null)
            {
                return null;
            }
            
            await _context.SaveChangesAsync();
            return await _context.Exam.ToListAsync();
        }
    }
}
    
