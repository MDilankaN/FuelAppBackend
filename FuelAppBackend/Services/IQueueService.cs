using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public interface IQueueService
    {
        public List<Queue> GetQueues();
        public Queue Get(String queueName);
        public Queue Create(Queue queue);
        public void Update(String id, Queue queue);
        public void Remove(string id);

    }
}
