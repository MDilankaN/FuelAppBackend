using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FuelAppBackend.Models
{
    public class Queue
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("queuename")]
        public string QueueName { get; set; } = String.Empty;

        [BsonElement("stationname")]
        public string StationName { get; set; } = String.Empty;
        [BsonElement("queuelistid")]
        public string QueueListID { get; set; } = String.Empty;
    }
}
