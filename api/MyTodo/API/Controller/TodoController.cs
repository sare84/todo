namespace MyTodo.API.Controller;

using Microsoft.AspNetCore.Mvc;
using MyTodo.API.Service;
using MyTodo.Domain.Todo;

[ApiController]
[Route("api/[controller]")] 
public class TodoController : ControllerBase
{
    private readonly TodoService _todoService;

    public TodoController(TodoService todoService)
    {
        _todoService = todoService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<TodoDTO>> GetAllTodos()
    {
        var todos = _todoService.GetAllTodos();
        return Ok(todos);
    }

    [HttpGet("{id}")]
    public ActionResult<TodoDTO> GetTodoById(int id)
    {
        var todo = _todoService.GetTodoById(id);
        if (todo == null)
        {
            return NotFound();
        }
        return Ok(todo);
    }

    [HttpPost]
    public ActionResult AddTodo([FromBody] Todo todo)
    {
        _todoService.AddTodo(todo);
        return CreatedAtAction(nameof(GetTodoById), new { id = todo.Id }, todo);
    }

    [HttpPut("{id}")]
    public ActionResult UpdateTodo(int id, [FromBody] Todo todo)
    {
        if (id != todo.Id)
        {
            return BadRequest("Todo ID mismatch.");
        }
        
        _todoService.UpdateTodo(todo);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteTodo(int id)
    {
        _todoService.DeleteTodo(id);
        return NoContent();
    }
}