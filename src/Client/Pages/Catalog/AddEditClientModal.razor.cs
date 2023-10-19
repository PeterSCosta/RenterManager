using RenterManager.Application.Features.Brands.Queries.GetAll;
using RenterManager.Client.Extensions;
using RenterManager.Shared.Constants.Application;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using RenterManager.Client.Infrastructure.Managers.Catalog.Client;
using RenterManager.Application.Features.Clients.Commands.AddEdit;

namespace RenterManager.Client.Pages.Catalog
{
    public partial class AddEditClientModal
    {
        [Inject] private IClientManager _clientManager { get; set; }

        [Parameter] public AddEditClientCommand AddEditClientModel { get; set; } = new();
        [CascadingParameter] private HubConnection HubConnection { get; set; }
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }

        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });
        private List<GetAllBrandsResponse> _brands = new();

        public void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SaveAsync()
        {
            var response = await _clientManager.SaveAsync(AddEditClientModel);
            if (response.Succeeded)
            {
                _snackBar.Add(response.Messages[0], Severity.Success);
                await HubConnection.SendAsync(ApplicationConstants.SignalR.SendUpdateDashboard);
                MudDialog.Close();
            }
            else
            {
                foreach (var message in response.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            HubConnection = HubConnection.TryInitialize(_navigationManager);
            if (HubConnection.State == HubConnectionState.Disconnected)
            {
                await HubConnection.StartAsync();
            }
        }
    }
}