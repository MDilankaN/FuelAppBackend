using FuelAppBackend.Models;
using MongoDB.Driver;

namespace FuelAppBackend.Services
{
    public class ReFuelHistoryService : IReFuelHistory
    {
        private readonly IMongoCollection<ReFeuelHistory> _refuelhistory;
        public ReFuelHistoryService(DatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _refuelhistory = database.GetCollection<ReFeuelHistory>(settings.CollectionName[5]);
        }

        public ReFeuelHistory Create(ReFeuelHistory reFeuelHistory)
        {
            _refuelhistory.InsertOne(reFeuelHistory);
            return reFeuelHistory;
        }

        public List<ReFeuelHistory> GetHistory()
        {
            return _refuelhistory.Find(reFeuelHistory => true).ToList();
        }

        public ReFeuelHistory GetHistoryByID(string id)
        {
            return _refuelhistory.Find(reFeuelHistory => reFeuelHistory.Id == id).FirstOrDefault();
        }


    }
}
