using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public class IUserService
    {
        public List<User> GetUsers();
        public User GetUserByID(String id);
        public User CreateUser(User user);
        public void UpdateUser(String id, User user);
        public void RemoveUser(string id);
    }
}
