using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AWebsite.API.V3
{
    [Route("api/v{version:apiVersion}/products")]
    [ApiVersion("3.0")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(1, 100);
        }
    }
}
