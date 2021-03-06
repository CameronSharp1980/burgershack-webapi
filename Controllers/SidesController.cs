using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using burgershack_c.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class SidesController : Controller
    {
        //AGAIN VERY BAD!!!!!!------------
        // public List<IMenuItem> Sides = Program.Sides;
        //--------------------------------

        SideRepository db { get; set; }
        public SidesController()
        {
            db = new SideRepository();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Side> Get()
        {
            return db.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Side Get(int id)
        {
            // return Sides.FirstOrDefault(side => side.Id == id);
            return db.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public Side Post([FromBody]Side side)
        {
            // Sides.Add(side);
            // return Sides;
            return db.Add(side);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public Side Put(int id, [FromBody]Side side)
        {
            if (ModelState.IsValid)
            {
                return db.GetOneByIdAndUpdate(id, side);
            }
            return null;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
