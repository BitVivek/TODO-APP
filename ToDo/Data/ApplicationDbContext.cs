using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo.Models.ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed data
            modelBuilder.Entity<ToDo.Models.ToDo>().HasData(
                new ToDo.Models.ToDo
                {
                    Id = 1,
                    Title = "Task 1",
                    Details = "Details for Task 1",
                    Date = DateTime.Now,
                    IsDone = false
                },
                new ToDo.Models.ToDo
                {
                    Id = 2,
                    Title = "Task 2",
                    Details = "Details for Task 2",
                    Date = DateTime.Now,
                    IsDone = true
                },
                new ToDo.Models.ToDo
                {
                    Id = 3,
                    Title = "Task 3",
                    Details = "Details for Task 3",
                    Date = DateTime.Now,
                    IsDone = false
                }
                );
        }
    }
}
