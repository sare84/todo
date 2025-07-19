using System.ComponentModel.DataAnnotations; 

namespace MyTodo.Domain.Todo;

public class Todo 
{
    public Todo() { } 

    // Constructor to use for creating new instances programmatically if needed
    public Todo(string title, string description, DateTime dueDate, bool isCompleted = false)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = isCompleted;
    }

    public int Id { get; set; }
    [Required] 
    public string Title { get; set; } = default!; // Initialize or make nullable
    [Required]
    public string Description { get; set; } = default!; // Initialize or make nullable
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
}