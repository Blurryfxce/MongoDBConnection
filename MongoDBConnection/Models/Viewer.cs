using MongoDB.Bson;

namespace MongoDBConnection.Models;

public class Viewer
{
    public ObjectId Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Ticket> Tickets { get; set; }
}