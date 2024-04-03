namespace ShopDotCo_API.Models
{
    public class Category
    {
        public required int Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Product>? Products { get; set; }

    }
}
