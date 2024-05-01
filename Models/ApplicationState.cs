using TodoApp.Models.Entities;

namespace TodoApp.Models
{
    public class ApplicationState
    {
        public List<Todo> TodoItems { get; set; } = new List<Todo>{
                    new Todo{ Description = "Complete all Coded Assignments", IsCompleted = false, Id = 1, DueDate = new DateTime(2024,04,30)},
                    new Todo{ Description = "Appartment Rent Paid", IsCompleted = true, Id = 2 },
                    new Todo { Description = "Clean My Room", IsCompleted = false, Id = 3 }
        };
    }
}
