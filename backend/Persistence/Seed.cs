using Domain.Entities;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Exams.Any()) return;

            var exams = new List<Exam>
            {
                new Exam
                {
                    Id = Guid.Parse("9484bf72-9988-4a66-962d-9176f0f18b4d"),
                    ExamDate = DateTime.Parse("12/07/2021 23:00"),
                    Afati = "NENTOR 2021"
                },
                new Exam
                {
                    Id = Guid.Parse("1302349e-2b57-47f6-8e4a-18147e49b5ba"),
                    ExamDate = DateTime.Parse("12/07/2022 23:00"),
                    Afati = "SHKURT 2022"
                },
                new Exam
                {
                    Id = Guid.Parse("57147200-36cc-49e6-9ed4-286e8d2b6ac3"),
                    ExamDate = DateTime.Parse("12/07/2023 23:00"),
                    Afati = "SHTATOR 2023"
                },
                new Exam
                {
                    Id = Guid.Parse("b9190e29-5a88-433b-84c6-774871dcb1bc"),
                    ExamDate = DateTime.Parse("12/07/2024 23:00"),
                    Afati = "JANAR 2021"
                },
                new Exam
                {
                    Id = Guid.Parse("fe782c6b-e625-4415-ad37-e5e4635f6c31"),
                    ExamDate = DateTime.Parse("12/07/1990 21:00"),
                    Afati = "JANAR 2026"
                }
                
            };      
            await context.Exams.AddRangeAsync(exams);
            await context.SaveChangesAsync(); 
        }
    }
}