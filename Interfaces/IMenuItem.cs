namespace burgershack_c.Models
{
    public interface IMenuItem
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
    }
}