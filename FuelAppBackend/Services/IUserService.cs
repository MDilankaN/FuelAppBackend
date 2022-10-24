using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public class IUserService
    {
        public List<User> GetUsers();
        public User Get(String id);
        public User Create(User user);
        public void Update(String id, User user);
        public void Remove(string id);
    }
}
