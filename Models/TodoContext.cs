using Microsoft.EntityFrameworkCore;
using TodoApp.Components;
using TodoApp.Models.Entities;

namespace TodoApp.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlite("Data Source=Todo.db");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(new List<Todo>{
             new Todo{ Description = "Complete all Coded Assignments", IsCompleted = false, Id = 1, DueDate = new DateTime(2024,04,30)},
             new Todo{ Description = "Appartment Rent", IsCompleted = true, Id = 2},
             new Todo{ Description = "Clean My Room", IsCompleted = false, Id = 3}
            });

        }
    }
}
