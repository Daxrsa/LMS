using Domain.Entities;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Administration.Any()) return;

            var administrations = new List<Administration>
            {
                new Administration
                {
                    Id = Guid.Parse("6e4ee6ce-1a89-42c8-a008-f89be0f62603"),
                    Leader = "John Doe"
                },
                new Administration
                {
                    Id = Guid.Parse("693f7827-d93b-4ef0-8abb-bbeca8d3f2e2"),
                    Leader = "Tina Parker"
                },
                new Administration
                {
                    Id = Guid.Parse("f04645ff-41f6-4401-8660-06232aee920a"),
                    Leader = "Tobby Hendrix"
                }
            };

            /* if (context.Request.Any()) return;

            var requests = new List<Request>
            {
                new Request
                {
                    Id = Guid.Parse("c974530b-54ce-4ef4-b533-1da3df56f737"),
                    Description = "Text goes here"
                },
                new Request
                {
                    Id = Guid.Parse("d4805fbe-05e2-4405-8416-b118f173ba31"),
                    Description = "I have a request"
                },
                new Request
                {
                    Id = Guid.Parse("470f3a5b-071e-4f3b-8f9c-893d64196283"),
                    Description = "I have a complaint"
                }
            };
            await context.Request.AddRangeAsync(requests); */
            
            await context.Administration.AddRangeAsync(administrations);

            await context.SaveChangesAsync();
        }
    }
}
/*private static List<Request> requests = new List<Request>
        {
        new Request
        {
            Id = Guid.Parse("791b9085-fd1f-4453-823d-1b4e46219b4a"),
            Description = "I have a request"
        },
        new Request
        {
            Id = Guid.Parse("ff9e2ec0-3c53-43c6-b074-47b5bff58d83"),
            Description = "Some text goes here"
        },
        new Request
        {
            Id = Guid.Parse("5c3ad29d-e8e6-4196-a9cd-e0db3123cd10"),
            Description = "Test test test"
        }
        };*/

        /*private static List<Assignment> assignments = new List<Assignment>
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
            };*/