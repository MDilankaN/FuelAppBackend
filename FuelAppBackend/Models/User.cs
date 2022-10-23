using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FuelAppBackend.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;
        [BsonElement("username")]
        public string UserName { get; set; } = String.Empty;
        [BsonElement("email")]
        public string Email { get; set; } = String.Empty;
        [BsonElement("password")] public string Password { get; set; } = String.Empty;
        [BsonElement("vehicleno")] public string VehicleNo { get; set; } = String.Empty;
        [BsonElement("vehicletype")] public string VehicleType { get; set; } = String.Empty;
        [BsonElement("fueltype")] public string FuelType { get; set; } = String.Empty;
        [BsonElement("language")] public string Language { get; set; } = String.Empty;
        [BsonElement("type")] public string Type { get; set; } = String.Empty;
    }
}
