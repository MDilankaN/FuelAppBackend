using FuelAppBackend.Models;
using FuelAppBackend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueListController : ControllerBase
    {
        private readonly IQueueListService _queuelistService;

        public QueueListController(IQueueListService queuelistService)
        {
            this._queuelistService = queuelistService;
        }

        // GET: api/<QueueListController>
        [HttpGet]
        public ActionResult<List<QueueList>> Get()
        {
            return _queuelistService.GetQueueList();
        }

        // GET api/<QueueListController>/5
        [Route("[action]/{queueID}")]
        [HttpGet]
        public ActionResult<List<QueueList>> GetQueueListByQueue(string queueID)
        {
            return _queuelistService.GetQueueListByQueue(queueID);

        }


        // GET api/<QueueListController>/5
        [HttpGet("{id}")]
        public ActionResult<QueueList> Get(string id)
        {
            var queuelist = _queuelistService.Get(id);
            if (queuelist == null)
            {
                return NotFound($"QueueList with QueueListID = {id} not found");
            }
            return queuelist;
        }

        // POST api/<QueueListController>
        [HttpPost]
        public ActionResult<QueueList> Post([FromBody] QueueList queuelist)
        {
            _queuelistService.Create(queuelist);
            return CreatedAtAction(nameof(Get), new { id = queuelist.Id }, queuelist);
        }

        // PUT api/<QueueListController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] QueueList queuelist)
        {
            var exsistingQueueList = _queuelistService.Get(id);
            if (exsistingQueueList == null)
            {
                return NotFound($"QueueList with QueueListID = {id} not found");
            }
            _queuelistService.Update(id, queuelist);
            return Ok($"QueueList with QueueListID = {id} Updated");

        }

        // DELETE api/<QueueListController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var exsistingQueueList = _queuelistService.Get(id);
            if (exsistingQueueList == null)
            {
                return NotFound($"QueueList with QueueListID = {id} not found");
            }
            _queuelistService.Remove(id);
            return Ok($"QueueList with QueuelistID = {id} deleted");
        }
    }
}
