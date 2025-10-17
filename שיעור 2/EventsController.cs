using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase

    {
        public static List<Event> events = new List<Event> { new Event { Id = 1, Title = "Wedding", Start = new DateTime() },
                new Event { Id = 2, Title = "Bar Mitzva", Start = new DateTime() } };

       
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Event> Get()
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
        public void Post([FromBody] Event value)
        {
            events.Add(value);
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Event value)
        {
            int index=events.FindIndex(e => e.Id == id);
            events[index].Title = value.Title;
            events[index].Start = value.Start;
        }

        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var e = events.Find(e => e.Id == id);
            events.Remove(e);
        }
    }
}
