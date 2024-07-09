using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDBConnection;

using MongoDBConnection.Models;

public class App
{
    public static void CreateTheater(IMongoCollection<Theater> collection)
    {
        Console.Write("Enter theater name: ");
        var name = Console.ReadLine();
        Console.Write("Enter theater address: ");
        var address = Console.ReadLine();
        Console.Write("Enter theater phone: ");
        var phone = Console.ReadLine();

        var theater = new Theater
        {
            Name = name,
            Address = address,
            Phone = phone,
            Screens = new List<Screen>()
        };

        collection.InsertOne(theater);
        Console.WriteLine("Theater created.");
    }

    public static void ReadTheaters(IMongoCollection<Theater> collection)
    {
        var theaters = collection.Find(new BsonDocument()).ToList();
        foreach (var theater in theaters)
        {
            Console.WriteLine($"Theater ID: {theater.Id}, Name: {theater.Name}, Address: {theater.Address}, Phone: {theater.Phone}");
        }
    }

    public static void UpdateTheater(IMongoCollection<Theater> collection)
    {
        Console.Write("Enter the ID of the theater to update: ");
        var id = Console.ReadLine();

        var filter = Builders<Theater>.Filter.Eq(t => t.Id, id);

        Console.Write("Enter new name (leave empty to keep current): ");
        var name = Console.ReadLine();
        Console.Write("Enter new address (leave empty to keep current): ");
        var address = Console.ReadLine();
        Console.Write("Enter new phone (leave empty to keep current): ");
        var phone = Console.ReadLine();

        var update = Builders<Theater>.Update
            .Set(t => t.Name, name)
            .Set(t => t.Address, address)
            .Set(t => t.Phone, phone);

        collection.UpdateOne(filter, update);
        Console.WriteLine("Theater updated.");
    }

    public static void DeleteTheater(IMongoCollection<Theater> collection)
    {
        Console.Write("Enter the ID of the theater to delete: ");
        var id = Console.ReadLine();

        var filter = Builders<Theater>.Filter.Eq(t => t.Id, id);

        collection.DeleteOne(filter);
        Console.WriteLine("Theater deleted.");
    }

}