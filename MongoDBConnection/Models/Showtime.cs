using MongoDB.Bson;

namespace MongoDBConnection.Models;

public class Showtime
{
    public ObjectId ShowtimeId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Movie Movie { get; set; }
}