namespace MyTodo.API.Service;

using LiteDB;

public interface IDatabaseService
{
    /// <summary>
    /// Gets the collection of Todo items from the database.
    /// </summary>
    /// <returns>ILiteCollection of Todo items.</returns>
    ILiteCollection<T> GetCollection<T>(string? collectionName = null) where T : class;
}

