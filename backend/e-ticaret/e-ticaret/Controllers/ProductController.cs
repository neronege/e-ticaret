using e_ticaret.DomainService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_ticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        [HttpGet("GetElectronics")]
        public IActionResult GetElectronics()
        {
            return Ok(service.GetElectronics());
        }
        
    }
}
