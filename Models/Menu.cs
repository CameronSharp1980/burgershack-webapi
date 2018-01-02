using System.Collections.Generic;

namespace burgershack_c.Models
{
    public class Menu
    {
        public Dictionary<string, List<IMenuItem>> Items;

        public Menu()
        {
            Items = new Dictionary<string, List<IMenuItem>>();
        }
    }
}
