using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Infrastructure.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IRepositoryAsync<Address, int> _repository;

        public AddressRepository(IRepositoryAsync<Address, int> repository)
        {
            _repository = repository;
        }
    }
}