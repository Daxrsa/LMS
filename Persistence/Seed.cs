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