namespace MyTodo.Domain.Health;

public class Info
{
    public string Version { get; set; } = string.Empty;
    public bool Running { get; set; } = true;

    public Info(string version, bool running)
    {
        Version = version;
        Running = running;
    }   
}