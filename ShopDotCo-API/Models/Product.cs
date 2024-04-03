namespace ShopDotCo_API.Models
{
    public class Product
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required decimal Price { get; set; }
        public int? CategoryId { get; set; }
        public decimal? FormerPrice { get; set; }
        public double? PercentageDiscount { get; set; }
        public double? Rating { get; set; }
         public List<string>? Colors { get; set; }
        public required List<string> Images { get; set; }
        public required List<string> Sizes { get; set; }
        public required int Count { get; set; }
        public int? NoOfSales { get; set; } = 0;
        public Category? Category { get; set; }
        public ICollection<ProductReview>? Reviews { get; set; }
    }
}
