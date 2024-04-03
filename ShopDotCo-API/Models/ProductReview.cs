namespace ShopDotCo_API.Models
{
    public class ProductReview
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required int? ProductId { get; set; }
        public required double Rating { get; set; }
        public required string Comment { get; set; }

        public Product? Product { get; set; }
    }
}
