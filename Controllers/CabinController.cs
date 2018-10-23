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
        public IEnumerable<Cabin> Get()
        {
            var db = new DataManager();
            var cabins = db.Load();
            return cabins;
        }

        // GET: api/Cabin/5
        [HttpGet("{id}", Name = "Get")]
        public Cabin Get(Guid id)
        {
            var db = new DataManager();
            var cabin = db.Load(id);
            return cabin;
        }

        // POST: api/Cabin
        [HttpPost]
        public void Post([FromBody]Cabin cabin)
        {
            cabin.ID = Guid.NewGuid();
            var db = new DataManager();
            db.Save(cabin);
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