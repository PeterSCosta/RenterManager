using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Infrastructure.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly IRepositoryAsync<Event, int> _repository;

        public EventRepository(IRepositoryAsync<Event, int> repository)
        {
            _repository = repository;
        }
    }
}