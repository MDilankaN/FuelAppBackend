using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public interface IQueueListService
    {
        public List<QueueList> GetQueueList();
        public QueueList Get(String id);
        public QueueList Create(QueueList queuelist);
        public void Update(String id, QueueList queuelist);
        public void Remove(string id);
    }
}
