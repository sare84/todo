using LiteDB;
using MyTodo.API.Service;
using MyTodo.Domain.Todo;

public class TodoService
{
    private readonly ILiteCollection<Todo> _todoCollection;
    private readonly IDatabaseService _databaseService;

    public TodoService(IDatabaseService databaseService)
    {
        _databaseService = databaseService ?? throw new ArgumentNullException(nameof(databaseService));
        _todoCollection =  _databaseService.GetCollection<Todo>("todos");
    }

    public IEnumerable<TodoDTO> GetAllTodos()
    {
        return _todoCollection.FindAll().Select(todo => new TodoDTO(
            todo.Id,
            todo.Title,
            todo.Description,
            todo.DueDate,
            todo.IsCompleted
        ));
    }

    public TodoDTO? GetTodoById(int id)
    {
        var todo = _todoCollection.FindById(id);
        return todo == null ? null : new TodoDTO(
            todo.Id,
            todo.Title,
            todo.Description,
            todo.DueDate,
            todo.IsCompleted
        );
    }

    public void AddTodo(Todo todo)
    {
        _todoCollection.Insert(todo);
    }

    public void UpdateTodo(Todo todo)
    {
        _todoCollection.Update(todo);
    }

    public void DeleteTodo(int id)
    {
        _todoCollection.Delete(id);
    }
}