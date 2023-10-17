using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Domain.Entities.Catalog;

namespace RenterManager.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly IRepositoryAsync<Brand, int> _repository;

        public BrandRepository(IRepositoryAsync<Brand, int> repository)
        {
            _repository = repository;
        }
    }
}