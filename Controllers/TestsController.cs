using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp_net_core_webapi_restful.Controllers
{
    [Route("api/[controller]")]
    public class TestsController : Controller
    {
        // GET api/tests
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "test1", "test2", "test3" };
        }

        // GET api/tests/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/tests
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tests/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tests/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
