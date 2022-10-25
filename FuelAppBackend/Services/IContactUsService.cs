using FuelAppBackend.Models;

namespace FuelAppBackend.Services
{
    public interface IContactUsService
    {
        public List<ContactUs> GetContactUs();
        public ContactUs Create(ContactUs contactUs);
      
    }
}
