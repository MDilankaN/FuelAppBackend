using FuelAppBackend.Models;
using MongoDB.Driver;

namespace FuelAppBackend.Services
{
    public class ContactUsService : IContactUsService

    {
        private readonly IMongoCollection<ContactUs> _contactus;
        public ContactUsService(DatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _contactus = database.GetCollection<ContactUs>(settings.CollectionName[4]);


        }

        public ContactUs Create(ContactUs contactUs)
        {
            _contactus.InsertOne(contactUs);
            return contactUs;
        }
    }
}
