namespace MyTodo.Domain.Health;

public class ServerTime
{
    public string Time { get; set; } = string.Empty;

    public ServerTime(string serverTime)
    {
        Time = serverTime;
    }
}

