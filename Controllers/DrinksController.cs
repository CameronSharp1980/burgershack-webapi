using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class DrinksController : Controller
    {
        //AGAIN VERY BAD!!!!!!------------
        public List<IMenuItem> Drinks = Program.Drinks;

        //--------------------------------

        // GET api/values
        [HttpGet]
        public IEnumerable<IMenuItem> Get()
        {
            return Drinks;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IMenuItem Get(int id)
        {
            return Drinks.FirstOrDefault(drink => drink.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<IMenuItem> Post([FromBody]IMenuItem drink)
        {
            Drinks.Add(drink);
            return Drinks;
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
