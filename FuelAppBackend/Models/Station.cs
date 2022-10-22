using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FuelAppBackend.Models
{
    [BsonIgnoreExtraElements]
    public class Station
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("stationname")]
        public string StationName { get; set; } = String.Empty;
        [BsonElement("address")]
        public string Address { get; set; } = String.Empty;
        [BsonElement("telephone")] public string Telephone { get; set; } = String.Empty;
        [BsonElement("opentime")] public string OpenTime { get; set; } = String.Empty;
        [BsonElement("closetime")] public string CloseTime { get; set; } = String.Empty;
        [BsonElement("imageurl")] public string ImageURL { get; set; } = String.Empty;
        [BsonElement("fuelstatus")] public bool FuelStatus { get; set; }
        [BsonElement("noofpumps")] public int NoOfPumps { get; set; }
    }
}
