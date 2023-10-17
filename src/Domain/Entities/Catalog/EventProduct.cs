using RenterManager.Application.Enums;
using RenterManager.Domain.Contracts;
using System;

namespace RenterManager.Domain.Entities.Catalog
{
    public class EventProduct : AuditableEntity<int>
    {
        public int EventIdentifier { get; set; }
        public virtual Event Event { get; set; }
        public int ProductIdentifier { get; set; }
        public virtual Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; } = 0;
        public decimal TotalPrice { get; set; }
    }
}