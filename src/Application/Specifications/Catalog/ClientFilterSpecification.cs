using RenterManager.Application.Specifications.Base;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Application.Specifications.Catalog
{
    public class ClientFilterSpecification : HeroSpecification<Client>
    {
        public ClientFilterSpecification(string searchString)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => p.Name.Contains(searchString) || p.Document.Contains(searchString);
            }
            else
            {
                Criteria = p => true;
            }
        }
    }
}