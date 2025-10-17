using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnsController : ControllerBase
    {
        // GET: api/<TurnsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TurnsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TurnsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TurnsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TurnsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
