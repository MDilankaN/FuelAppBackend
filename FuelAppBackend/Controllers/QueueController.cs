using FuelAppBackend.Models;
using FuelAppBackend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FuelAppBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueueController : ControllerBase
    {

        private readonly IQueueService _queueService;

        public QueueController(IQueueService queueService)
        {
            this._queueService = queueService;
        }
        // GET: api/<QueueController>
        [HttpGet]
        public ActionResult<List<Queue>> Get()
        {
            return _queueService.GetQueues();
        }

        // GET api/<QueueController>/5
        [Route("[action]/{queuename}")]
        [HttpGet]
        public ActionResult<Queue> GetByQueueName(string queueName)
        {
            var queue = _queueService.GetByName(queueName);    
            if (queue == null)
            {
                return NotFound($"Queue with Queue Name = {queueName} not found");
            }
            return queue;
        }

        // GET api/<QueueController>/5
        [HttpGet("{id}")]
        public ActionResult<Queue> Get(string id)
        {
            var queue = _queueService.Get(id);
            if (queue == null)
            {
                return NotFound($"Queue with Queue Name = {id} not found");
            }
            return queue;
        }

        // POST api/<QueueController>
        [HttpPost]
        public ActionResult<Queue> Post([FromBody] Queue queue)
        {
            _queueService.Create(queue);
            return CreatedAtAction(nameof(Get), new { id = queue.Id }, queue);
        }

        // PUT api/<QueueController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Queue queue)
        {
            var exsistingQueue = _queueService.Get(id);
            if (exsistingQueue == null)
            {
                return NotFound($"Queue with QueueID = {id} not found");
            }
            _queueService.Update(id, queue);
            return Ok($"Queue with QueueID = {id} Updated");
        }

        // DELETE api/<QueueController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var exsistingQueue = _queueService.Get(id);
            if (exsistingQueue == null)
            {
                return NotFound($"Queue with QueueID = {id} not found");
            }
            _queueService.Remove(id);
            return Ok($"Queue with QueueID = {id} deleted");

        }
    }
}
