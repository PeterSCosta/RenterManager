using RenterManager.Application.Extensions;
using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Application.Specifications.Catalog;
using RenterManager.Domain.Entities.Catalog;
using RenterManager.Shared.Wrapper;
using MediatR;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;

namespace RenterManager.Application.Features.Clients.Queries.GetAllPaged
{
    public class GetAllClientsQuery : IRequest<PaginatedResult<GetAllPagedClientsResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }
        public string[] OrderBy { get; set; } // of the form fieldname [ascending|descending],fieldname [ascending|descending]...

        public GetAllClientsQuery(int pageNumber, int pageSize, string searchString, string orderBy)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
            SearchString = searchString;
            if (!string.IsNullOrWhiteSpace(orderBy))
            {
                OrderBy = orderBy.Split(',');
            }
        }
    }

    internal class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, PaginatedResult<GetAllPagedClientsResponse>>
    {
        private readonly IUnitOfWork<int> _unitOfWork;

        public GetAllClientsQueryHandler(IUnitOfWork<int> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<PaginatedResult<GetAllPagedClientsResponse>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
        {
            Expression<Func<Client, GetAllPagedClientsResponse>> expression = e => new GetAllPagedClientsResponse
            {
                Id = e.Id,
                Name = e.Name,
                Document = e.Document,
                ContactInfo = e.ContactInfo,
                Telephone = e.Telephone,
            };
            var clientFilterSpec = new ClientFilterSpecification(request.SearchString);
            if (request.OrderBy?.Any() != true)
            {
                var data = await _unitOfWork.Repository<Client>().Entities
                   .Specify(clientFilterSpec)
                   .Select(expression)
                   .ToPaginatedListAsync(request.PageNumber, request.PageSize);
                return data;
            }
            else
            {
                var ordering = string.Join(",", request.OrderBy); // of the form fieldname [ascending|descending], ...
                var data = await _unitOfWork.Repository<Client>().Entities
                   .Specify(clientFilterSpec)
                   .OrderBy(ordering) // require system.linq.dynamic.core
                   .Select(expression)
                   .ToPaginatedListAsync(request.PageNumber, request.PageSize);
                return data;

            }
        }
    }
}