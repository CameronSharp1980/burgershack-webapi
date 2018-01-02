using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class BurgersController : Controller
    {
        //AGAIN VERY BAD!!!!!!------------
        public List<IMenuItem> Burgers = Program.Burgers;

        //--------------------------------

        // GET api/values
        [HttpGet]
        public IEnumerable<IMenuItem> Get()
        {
            return Burgers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IMenuItem Get(int id)
        {
            return Burgers.FirstOrDefault(burger => burger.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<IMenuItem> Post([FromBody]IMenuItem burger)
        {
            Burgers.Add(burger);
            return Burgers;
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
