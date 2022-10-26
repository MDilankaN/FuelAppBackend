using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FuelAppBackend.Models
{
    public class ReFeuelHistory
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("fuelstationid")]
        public string FuelStationID { get; set; } = String.Empty;

        [BsonElement("userid")]
        public string UserID { get; set; } = String.Empty;
        [BsonElement("queueid")]
        public string QueueID { get; set; } = String.Empty;
        [BsonElement("duration")]
        public string Duration { get; set; } = String.Empty;
        [BsonElement("dataandtime")] public bool DateAndTime { get; set; }
    }
}
