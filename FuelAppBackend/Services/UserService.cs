using FuelAppBackend.Models;
using MongoDB.Driver;

namespace FuelAppBackend.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _user;
        public UserService(DatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _user = database.GetCollection<User>(settings.CollectionName[2]);

        }
        public User CreateUser(User user)
        {
            _user.InsertOne(user);
            return user;
        }

        public User GetUserByID(string id)
        {
            return _user.Find(user => user.Id == id).FirstOrDefault();
        }

        public User GetUserByName(string name)
        {
            return _user.Find(user => user.UserName == name).FirstOrDefault();
        }

        public List<User> GetUsers()
        {
            return _user.Find(user => true).ToList();
        }

        public void RemoveUser(string id)
        {
            _user.DeleteOne(user => user.Id == id);
        }

        public void UpdateUser(string id, User user)
        {
            _user.ReplaceOne(user => user.Id == id, user);
        }

    }
}
