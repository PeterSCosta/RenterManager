using RenterManager.Application.Enums;
using RenterManager.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace RenterManager.Domain.Entities.Catalog
{
    public class Product : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "text")]
        public string ImageDataURL { get; set; }
        public decimal DefaultUnitPrice { get; set; } = 0;
        public ProductType ProductType { get; set; }
    }
}