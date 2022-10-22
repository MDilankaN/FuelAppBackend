using FuelAppBackend.Models;
using MongoDB.Driver;

namespace FuelAppBackend.Services
{
    public class QueueService : IQueueService
    {

        private readonly IMongoCollection<Queue> _queue;
        public QueueService(DatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _queue = database.GetCollection<Queue>(settings.CollectionName);


        }
        public Queue Create(Queue queue)
        {
            _queue.InsertOne(queue);
            return queue;
        }

        public Queue Get(string id)
        {
            return _queue.Find(queue => queue.Id == id).FirstOrDefault();
        }

        public List<Queue> GetQueues()
        {
            return _queue.Find(queue => true).ToList();
        }

        public void Remove(string id)
        {
            _queue.DeleteOne(queue => queue.Id == id);
        }

        public void Update(string id, Queue queue)
        {
            _queue.ReplaceOne(queue => queue.Id == id, queue);
        }
    }
}
