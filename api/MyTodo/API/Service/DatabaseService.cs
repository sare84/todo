// generate database service for mytodo with LiteDB
using System;
using LiteDB;
using Microsoft.Extensions.Options;
using MyTodo.API.Service;

public class LiteDbOptions
{
    public string DatabaseFilePath { get; set; } = "";
}


public class DatabaseService: IDatabaseService, IDisposable
{
    private readonly ILiteDatabase _database;
    

    public DatabaseService(ILiteDatabase database)
    {
        _database = database ?? throw new ArgumentNullException(nameof(database));
    }

    public ILiteCollection<T> GetCollection<T>(string? collectionName = null) where T : class
    {
        return _database.GetCollection<T>(collectionName ?? typeof(T).Name);
    }

    public void Dispose()
    {
        _database?.Dispose();
    }


}

