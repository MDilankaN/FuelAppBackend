using FuelAppBackend.Models;
using FuelAppBackend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService _contactusservice;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactusservice = contactUsService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<List<ContactUs>> Get()
        {
            return _contactusservice.GetContactUs();
        }

        // POST api/<ContactUsController>
        [HttpPost]
        public ActionResult<ContactUs> Post([FromBody] ContactUs contactUs)
        {
            _contactusservice.Create(contactUs);
            return CreatedAtAction(nameof(Get), new { id = contactUs.Id }, contactUs);
        }

     

        
    }
}
