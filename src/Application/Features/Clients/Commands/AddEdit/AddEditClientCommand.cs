using System.ComponentModel.DataAnnotations;
using AutoMapper;
using RenterManager.Application.Interfaces.Repositories;
using RenterManager.Application.Interfaces.Services;
using RenterManager.Domain.Entities.Catalog;
using RenterManager.Shared.Wrapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace RenterManager.Application.Features.Clients.Commands.AddEdit
{
    public partial class AddEditClientCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Document { get; set; }
        [Required]
        public string ContactInfo { get; set; }
        [Required]
        public string Telephone { get; set; }
    }

    internal class AddEditClientCommandHandler : IRequestHandler<AddEditClientCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IStringLocalizer<AddEditClientCommandHandler> _localizer;

        public AddEditClientCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IStringLocalizer<AddEditClientCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditClientCommand command, CancellationToken cancellationToken)
        {
            if (command.Id == 0)
            {
                var client = _mapper.Map<Client>(command);
                await _unitOfWork.Repository<Client>().AddAsync(client);
                await _unitOfWork.Commit(cancellationToken);
                return await Result<int>.SuccessAsync(client.Id, _localizer["Client Saved"]);
            }
            else
            {
                var client = await _unitOfWork.Repository<Client>().GetByIdAsync(command.Id);
                if (client != null)
                {
                    client.Name = command.Name ?? client.Name;
                    client.ContactInfo = command.ContactInfo ?? client.ContactInfo;
                    client.Telephone = command.Telephone?? client.Telephone;

                    await _unitOfWork.Repository<Client>().UpdateAsync(client);
                    await _unitOfWork.Commit(cancellationToken);
                    return await Result<int>.SuccessAsync(client.Id, _localizer["Client Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Client Not Found!"]);
                }
            }
        }
    }
}