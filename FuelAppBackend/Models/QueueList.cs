using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FuelAppBackend.Models
{
    public class QueueList
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("userid")]
        public string UserID { get; set; } = String.Empty;

        [BsonElement("queueid")]
        public string QueueID { get; set; } = String.Empty;

        [BsonElement("jointime")]
        public string JoinTime { get; set; } = String.Empty;

        [BsonElement("lefttime")]
        public string LeftTime { get; set; } = String.Empty;
        [BsonElement("position")]
        public int Position { get; set; }
    }
}
