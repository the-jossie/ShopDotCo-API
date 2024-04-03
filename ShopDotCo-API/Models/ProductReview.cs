namespace ShopDotCo_API.Models
{
    public class ProductReview
    {
        public required string Id { get; set; }
        public required string Name { get; set; }
        public required string? ProductId { get; set; }
        public required double Rating { get; set; }
        public required string Comment { get; set; }
    }
}
