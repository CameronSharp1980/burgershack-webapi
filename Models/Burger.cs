namespace burgershack_c.Models
{
    public class Burger : IMenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}