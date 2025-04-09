namespace AtirAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        // Foreign key for Category
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } // Navigation property
    }
}
