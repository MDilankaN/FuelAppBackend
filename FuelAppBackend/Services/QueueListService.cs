using FuelAppBackend.Models;
using MongoDB.Driver;

namespace FuelAppBackend.Services
{
    public class QueueListService : IQueueListService
    {
        private readonly IMongoCollection<QueueList> _queuelist;
        public QueueListService(DatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _queuelist = database.GetCollection<QueueList>(settings.CollectionName[3]);


        }
        public QueueList Create(QueueList queuelist)
        {
            _queuelist.InsertOne(queuelist);
            return queuelist;
        }

        public QueueList Get(string id)
        {
            return _queuelist.Find(queuelist => queuelist.Id == id).FirstOrDefault();
        }

        public List<QueueList> GetQueueList()
        {
            return _queuelist.Find(queuelist => true).ToList();
        }

        public void Remove(string id)
        {
            _queuelist.DeleteOne(queuelist => queuelist.Id == id);
        }

        public void Update(string id, QueueList queuelist)
        {
            _queuelist.ReplaceOne(queuelist => queuelist.Id == id, queuelist);
        }

    }
}
