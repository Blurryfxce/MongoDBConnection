using MongoDB.Bson;

namespace MongoDBConnection.Models;

public class Movie
{
    public ObjectId Id { get; set; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
}