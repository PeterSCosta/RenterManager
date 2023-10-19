using RenterManager.Application.Enums;

namespace RenterManager.Application.Features.Products.Queries.GetAllPaged
{
    public class GetAllPagedProductsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DefaultUnitPrice { get; set; }
        public ProductType ProductType { get; set; }
    }
}