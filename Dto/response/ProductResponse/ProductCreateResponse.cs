namespace Ecommerce_site.Dto.response.ProductResponse;

public class ProductCreateResponse
{
    public required long ProductId { get; set; }
    public required long CreateBy { get; set; }
    public required string ProductName { get; set; }
    public required string Description { get; set; }
    public required int Discount { get; set; }
    public required int Quantity { get; set; }
    public required decimal Price { get; set; }
    public required bool IsAvailable { get; set; }
}