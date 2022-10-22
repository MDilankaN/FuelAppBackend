using FuelAppBackend.Models;
using MongoDB.Driver;

namespace FuelAppBackend.Services
{
    public class StationService : IStationService
    {
        private readonly IMongoCollection<Station> _station;

        public StationService(DatabaseSettings settings,IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _station = database.GetCollection<Station>(settings.CollectionName);
        }

        public Station Create(Station station)
        {
            _station.InsertOne(station);
            return station;
        }

        public void Delete(string id)
        {
            _station.DeleteOne(student => student.Id == id);
        }

        public Station GetStationGetByID(string id)
        {
            return _station.Find(student => student.Id == id).FirstOrDefault();
        }

        public Station GetStationGetByName(string stationName)
        {
            return _station.Find(student => student.Id == stationName).FirstOrDefault();
        }

        public List<Station> GetStations()
        {
            return _station.Find(student => true).ToList();
        }

        public void Update(string id,Station station)
        {
            _station.ReplaceOne(student => student.Id == id, station);
        }
    }
}
