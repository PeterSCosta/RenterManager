using RenterManager.Domain.Contracts;

namespace RenterManager.Domain.Entities.Catalog
{
    public class Client : AuditableEntity<int>
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string Telephone { get; set; }
    }
}