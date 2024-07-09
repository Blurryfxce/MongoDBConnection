using MongoDB.Bson;

namespace MongoDBConnection.Models;

public class Ticket
{
    public ObjectId TicketId { get; set; }
    public ObjectId ShowtimeId { get; set; }
    public ObjectId TheaterId { get; set; }
    public ObjectId ScreenId { get; set; }
}