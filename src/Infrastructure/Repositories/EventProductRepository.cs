using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Infrastructure.Repositories
{
    public class EventProductRepository : IEventProductRepository
    {
        private readonly IRepositoryAsync<EventProduct, int> _repository;

        public EventProductRepository(IRepositoryAsync<EventProduct, int> repository)
        {
            _repository = repository;
        }
    }
}