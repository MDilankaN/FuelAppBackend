using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public interface IReFuelHistory
    {
        public List<ReFeuelHistory> GetHistory();
        public ReFeuelHistory GetHistoryByID(string id);
        public ReFeuelHistory Create(ReFeuelHistory reFeuelHistory);

    }
}
