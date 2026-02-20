using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET api/values/{id}
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Dave Morello";
        }

        //POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        //PUT api/values
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
