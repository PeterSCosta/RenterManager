using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RenterManager.Application.Features.Clients.Queries.GetAllPaged;
using RenterManager.Application.Features.Clients.Commands.AddEdit;
using RenterManager.Application.Features.Clients.Commands.Delete;
using RenterManager.Application.Features.Clients.Queries.Export;

namespace RenterManager.Server.Controllers.v1.Catalog
{
    public class ClientsController : BaseApiController<ClientsController>
    {
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="pageSize"></param>
        /// <param name="searchString"></param>
        /// <param name="orderBy"></param>
        /// <returns>Status 200 OK</returns>
        //[Authorize(Policy = Permissions.Clients.View)]
        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize, string searchString, string orderBy = null)
        {
            var clients = await _mediator.Send(new GetAllClientsQuery(pageNumber, pageSize, searchString, orderBy));
            return Ok(clients);
        }

        /// <summary>
        /// Add/Edit a Product
        /// </summary>
        /// <param name="command"></param>
        /// <returns>Status 200 OK</returns>
        //[Authorize(Policy = Permissions.Products.Create)]
        [HttpPost]
        public async Task<IActionResult> Post(AddEditClientCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Status 200 OK response</returns>
        //[Authorize(Policy = Permissions.Products.Delete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _mediator.Send(new DeleteClientCommand { Id = id }));
        }

        /// <summary>
        /// Search Products and Export to Excel
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>Status 200 OK</returns>
        //[Authorize(Policy = Permissions.Products.Export)]
        [HttpGet("export")]
        public async Task<IActionResult> Export(string searchString = "")
        {
            return Ok(await _mediator.Send(new ExportClientsQuery(searchString)));
        }
    }
}