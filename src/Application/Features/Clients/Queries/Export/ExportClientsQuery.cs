using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Application.Interfaces.Services;
using RenterManager.Domain.Entities.Catalog;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using RenterManager.Application.Extensions;
using RenterManager.Application.Specifications.Catalog;
using RenterManager.Shared.Wrapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace RenterManager.Application.Features.Clients.Queries.Export
{
    public class ExportClientsQuery : IRequest<Result<string>>
    {
        public string SearchString { get; set; }

        public ExportClientsQuery(string searchString = "")
        {
            SearchString = searchString;
        }
    }

    internal class ExportClientsQueryHandler : IRequestHandler<ExportClientsQuery, Result<string>>
    {
        private readonly IExcelService _excelService;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IStringLocalizer<ExportClientsQueryHandler> _localizer;

        public ExportClientsQueryHandler(IExcelService excelService
            , IUnitOfWork<int> unitOfWork
            , IStringLocalizer<ExportClientsQueryHandler> localizer)
        {
            _excelService = excelService;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<Result<string>> Handle(ExportClientsQuery request, CancellationToken cancellationToken)
        {
            var clientFilterSpec = new ClientFilterSpecification(request.SearchString);
            var clients = await _unitOfWork.Repository<Client>().Entities
                .Specify(clientFilterSpec)
                .ToListAsync(cancellationToken);
            var data = await _excelService.ExportAsync(clients, mappers: new Dictionary<string, Func<Client, object>>
            {
                { _localizer["Id"], item => item.Id },
                { _localizer["Name"], item => item.Name },
                { _localizer["Document"], item => item.Document },
                { _localizer["ContactInfo"], item => item.ContactInfo },
                { _localizer["Telephone"], item => item.Telephone }
            }, sheetName: _localizer["Clients"]);

            return await Result<string>.SuccessAsync(data: data);
        }
    }
}