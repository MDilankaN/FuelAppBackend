using FuelAppBackend.Models;
using MongoDB.Driver;
using static System.Collections.Specialized.BitVector32;

namespace FuelAppBackend.Services
{
    public class StationService : IStationService
    {
        private readonly IMongoCollection<Station> _station;

        public StationService(DatabaseSettings settings,IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _station = database.GetCollection<Station>(settings.CollectionName[0]);
        }

        public Station Create(Station station)
        {
            _station.InsertOne(station);
            return station;
        }

        public void Delete(string id)
        {
            _station.DeleteOne(station => station.Id == id);
        }

        public Station GetStationGetByID(string id)
        {
            return _station.Find(station => station.Id == id).FirstOrDefault();
        }

        public Station GetStationGetByName(string stationName)
        {
            return _station.Find(station => station.Id == stationName).FirstOrDefault();
        }

        public List<Station> GetStations()
        {
            return _station.Find(station => true).ToList();
        }

        public void Update(string id,Station station)
        {
            _station.ReplaceOne(station => station.Id == id, station);
        }
    }
}
