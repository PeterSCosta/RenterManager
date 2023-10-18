using RenterManager.Application.Specifications.Base;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Application.Specifications.Catalog
{
    public class EventFilterSpecification : HeroSpecification<Event>
    {
        public EventFilterSpecification()
        {
            Includes.Add(a => a.Address);
            //if (!string.IsNullOrEmpty(searchString))
            //{
            //    Criteria = p => p.Barcode != null && (p.Name.Contains(searchString) || p.Description.Contains(searchString) || p.Barcode.Contains(searchString) || p.Brand.Name.Contains(searchString));
            //}
            //else
            //{
            //    Criteria = p => p.Barcode != null;
            //}
        }
    }
}