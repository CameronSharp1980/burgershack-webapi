using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class SidesController : Controller
    {
        //AGAIN VERY BAD!!!!!!------------
        public List<IMenuItem> Sides = Program.Sides;

        //--------------------------------

        // GET api/values
        [HttpGet]
        public IEnumerable<IMenuItem> Get()
        {
            return Sides;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IMenuItem Get(int id)
        {
            return Sides.FirstOrDefault(side => side.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<IMenuItem> Post([FromBody]IMenuItem side)
        {
            Sides.Add(side);
            return Sides;
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
