using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public interface IQueueService
    {
        public List<Queue> GetQueues();
        public Queue GetByName(String queueName);
        public Queue Get(String id);
        public List<Queue> GetQueueByStation(String stationName);
        public Queue Create(Queue queue);
        public void Update(String id, Queue queue);
        public void Remove(string id);

    }
}
