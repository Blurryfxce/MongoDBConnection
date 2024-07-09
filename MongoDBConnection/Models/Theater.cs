using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBConnection.Models;

public class Theater
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public List<Screen> Screens { get; set; }
}