using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BabiesController : ControllerBase
    {
        public static List<Events> events = new List<Events>{new Events { id = 1, title = "Wedding", start = new DateTime() },
                new Events { id = 2, title = "Bar Mitzva", start = new DateTime() } };
        // GET: api/<BabyCareController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BabyCareController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BabyCareController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BabyCareController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BabyCareController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
