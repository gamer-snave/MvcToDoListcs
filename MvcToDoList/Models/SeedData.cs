using Microsoft.EntityFrameworkCore;
using MvcToDoList.Data;

namespace MvcToDoList.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcToDoListContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<MvcToDoListContext>>()))
            {
                // Look for an To-Do tasks
                if (context.ToDoList.Any())
                {
                    return; // DB has been seeded
                }

                context.ToDoList.AddRange(
                    new ToDoList
                    {
                        Task = "Write report",
                        Description = "Write a report on the company's financial performance",
                        Status = "To do",
                        Priority = "High",
                        Assignee = "Sarah Smith",
                        Comments = "Make sure to include data from the past quarter.",
                        Created = DateTime.Parse("2022-01-05"),
                        CompleteBy = DateTime.Parse("2022-01-10")
                    },

                    new ToDoList
                    {
                        Task = "Attend meeting",
                        Description = "Attend a meeting with the marketing team",
                        Status = "To do",
                        Priority = "Medium",
                        Assignee = "John Doe",
                        Comments = "Bring the presentation materials with you.",
                        Created = DateTime.Parse("2022-01-05"),
                        CompleteBy = DateTime.Parse("2022-01-06")
                    },


                    new ToDoList
                    {
                        Task = "Submit expense report",
                        Description = "Submit the expense report for the business trip to HR",
                        Status = "To do",
                        Priority = "Low",
                        Assignee = "Jessica Williams",
                        Comments = "Remember to include receipts for all expenses.",
                        Created = DateTime.Parse("2022-01-05"),
                        CompleteBy = DateTime.Parse("2022-01-15")
                    },


                    new ToDoList
                    {
                        Task = "Write blog post",
                        Description = "Write a blog post about the benefits of using our product",
                        Status = "To do",
                        Priority = "Medium",
                        Assignee = "Emily Davis",
                        Comments = "Include customer testimonials in the post.",
                        Created = DateTime.Parse("2022-01-05"),
                        CompleteBy = DateTime.Parse("2022-01-09")
                    },


                    new ToDoList
                    {
                        Task = "Update project plan",
                        Description = "Update the project plan with the latest progress and tasks",
                        Status = "To do",
                        Priority = "High",
                        Assignee = "Andrew Kim",
                        Comments = "Make sure to involve the team in the update process.",
                        Created = DateTime.Parse("2022-01-05"),
                        CompleteBy = DateTime.Parse("2022-01-07")
                    }

                    ); ;
                context.SaveChanges();
            }
        }
    }
}
