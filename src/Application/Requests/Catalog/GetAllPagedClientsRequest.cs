namespace RenterManager.Application.Requests.Catalog
{
    public class GetAllPagedClientsRequest : PagedRequest
    {
        public string SearchString { get; set; }
    }
}