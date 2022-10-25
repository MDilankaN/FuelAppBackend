using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FuelAppBackend.Models
{
    public class ContactUs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("name")]
        public string Name { get; set; } = String.Empty;
        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;
        [BsonElement("subject")] public string Subject { get; set; } = String.Empty;
        [BsonElement("message")] public string Message { get; set; } = String.Empty;
       
    }
}
