using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using burgershack_c.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgershack_c.Controllers
{
    [Route("api/[controller]")]
    public class MenusController : Controller
    {
        //AGAIN VERY BAD!!!!!!------------
        public List<IMenuItem> Burgers = Program.Burgers;
        public List<IMenuItem> Drinks = Program.Drinks;
        public List<IMenuItem> Sides = Program.Sides;

        public Menu Menu = new Menu();

        public MenusController()
        {
            Menu.Items.Add("burgers", Burgers);
            Menu.Items.Add("drinks", Drinks);
            Menu.Items.Add("sides", Sides);
        }
        //--------------------------------

        // GET api/values
        [HttpGet]
        public Menu Get()
        {
            return Menu;
        }

        // GET api/values/5
        [HttpGet("{menu}")]
        public List<IMenuItem> Get(string menu)
        {
            return Menu.Items[menu];
        }

        // GET api/values/5
        [HttpGet("{menu}/{id}")]
        public IMenuItem Get(string menu, int id)
        {
            return Menu.Items[menu].FirstOrDefault(item => item.Id == id);
        }

        // POST api/values
        // [HttpPost]
        // public IEnumerable<Burger> Post([FromBody]Burger burger)
        // {
        //     Burgers.Add(burger);
        //     return Burgers;
        // }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
