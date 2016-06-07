using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MultiService.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Models.Customer> Get()
        {
            Models.Customer[] customers = new Models.Customer[] {
                new Models.Customer("Foo", "Freddy Foo"),
                new Models.Customer("Bar", "Jason Bar")
            };
            return customers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Models.Customer Get(string id)
        {
            return new Models.Customer("Foo", "Freddy Foo");
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
