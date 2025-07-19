// generate database service for mytodo with LiteDB
using System;
using LiteDB;
using Microsoft.Extensions.Options;
using MyTodo.API.Service;

public class LiteDbOptions
{
    public string DatabaseFilePath { get; set; } = "Filename=MyDatabase.db; Connection=shared";
}


public class DatabaseService: IDatabaseService, IDisposable
{
    private readonly ILiteDatabase _database;

    public DatabaseService(IOptions<LiteDbOptions> options)
    {
        var dbPath = options?.Value?.DatabaseFilePath ?? "Filename=MyDatabase.db; Connection=shared";
        _database = new LiteDatabase(dbPath);
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

