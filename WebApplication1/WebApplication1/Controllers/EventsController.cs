using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public static List<Events> events = new List<Events>{new Events { id = 1, title = "Wedding", start = new DateTime() },
                new Events { id = 2, title = "Bar Mitzva", start = new DateTime() } };
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Events> Get()
        {
            return events;
        }

        // GET api/<EventsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Events value)
        {
            events.Add(value);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Events value)
        {
            int index=events.FindIndex(e => e.id==id);
            events[index].title = value.title;
            events[index].start = value.start;

        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var e=events.Find(e=>e.id==id);
            events.Remove(e);
        }
    }
}
