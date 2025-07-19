namespace MyTodo.Domain.Todo;

public class TodoDTO
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public TodoDTO(int id, string title, string description, DateTime dueDate, bool isCompleted)
    {
        Id = id;
        Title = title;
        Description = description;
        DueDate = dueDate;
        IsCompleted = isCompleted;
    }
}

// This class is used to transfer Todo data between layers, such as from the domain to the API layer.	

