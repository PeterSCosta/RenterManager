using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IRepositoryAsync<Client, int> _repository;

        public ClientRepository(IRepositoryAsync<Client, int> repository)
        {
            _repository = repository;
        }
    }
}