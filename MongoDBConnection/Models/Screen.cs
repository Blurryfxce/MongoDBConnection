using MongoDB.Bson;

namespace MongoDBConnection.Models;

public class Screen
{
    public ObjectId ScreenId { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public List<Showtime> Showtimes { get; set; }
}