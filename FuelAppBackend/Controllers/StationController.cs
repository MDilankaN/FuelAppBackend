using FuelAppBackend.Models;
using FuelAppBackend.Services;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }


        // GET: api/<StationController>
        [HttpGet]
        public ActionResult<List<Station>> Get()
        {
            return _stationService.GetStations();
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public ActionResult<Station> Get(string id)
        {
            var station = _stationService.GetStationGetByID(id);
            if (station == null)
            {
                return NotFound($"Station with stationID = {id} not found");
            }
            return station;
        }

        // GET api/<QueueController>/5
        [Route("[action]/{stationName}")]
        [HttpGet]
        public ActionResult<List<Station>> GetStationByName(string stationName)
        {
            return _stationService.GetStationGetByName(stationName);
        }

        // POST api/<StationController>
        [HttpPost]
        public ActionResult<Station> Post([FromBody] Station station)
        {
            _stationService.Create(station);
            return CreatedAtAction(nameof(Get), new { id = station.Id }, station);
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Station station)
        {
            var exsistingStation = _stationService.GetStationGetByID(id);
            if (exsistingStation == null)
            {
                return NotFound($"Station with stationID = {id} not found");
            }
            _stationService.Update(id, station);
            return Ok($"Station with Station = {id} Updated");

        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var exsistingStation = _stationService.GetStationGetByID(id);
            if (exsistingStation == null)
            {
                return NotFound($"Station with stationID = {id} not found");
            }
            _stationService.Delete(id);
            return Ok($"Station with StationID = {id} deleted");

        }
    }
}
