using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace vuets.Controllers
{
    [Produces("application/json")]
    [Route("api/Cabin")]
    public class CabinController : Controller
    {
        // GET: api/Cabin
        [HttpGet]
        public string Get()
        {
            var db = new DataManager();
            var cabins = db.Load();
            return JsonConvert.SerializeObject(cabins);
        }

        // GET: api/Cabin/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cabin
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cabin/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}