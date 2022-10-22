using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public interface IStationService
    {
        public List<Station> GetStations();
        public Station GetStationGetByID(string id);
        public Station GetStationGetByName(string stationName);
        public Station Create(Station station);
        public void Update(string id, Station station);
        public void Delete(string id);

    }
}
