using FuelAppBackend.Models;
using FuelAppBackend.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReFuelHistoryController : ControllerBase
    {

        private readonly IReFuelHistory _reFuelHistory;

        public ReFuelHistoryController(IReFuelHistory reFuelHistoryService)
        {
            _reFuelHistory = reFuelHistoryService;
        }

        // GET: api/<ReFuelHistoryController>
        [HttpGet]
        public ActionResult<List<ReFeuelHistory>> Get()
        {
            return _reFuelHistory.GetHistory();
        }

        // GET api/<ReFuelHistoryController>/5
        [HttpGet("{id}")]
        public ActionResult<ReFeuelHistory> Get(string id)
        {
            var refuelhistory = _reFuelHistory.GetHistoryByID(id);
            if (refuelhistory == null)
            {
                return NotFound($"ReFuel with ReFuelID = {id} not found");
            }
            return refuelhistory;

        }


        // POST api/<ReFuelHistoryController>
        [HttpPost]
        public ActionResult<ReFeuelHistory> Post([FromBody] ReFeuelHistory reFeuelHistory)
        {
            _reFuelHistory.Create(reFeuelHistory);
            return CreatedAtAction(nameof(Get), new { id = reFeuelHistory.Id }, reFeuelHistory);

        }
    }
}
