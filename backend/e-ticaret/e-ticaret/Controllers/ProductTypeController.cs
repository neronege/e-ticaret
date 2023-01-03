using e_ticaret.DomainService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_ticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeService service;

        public ProductTypeController(IProductTypeService service)
        {
            this.service = service;
        }

        [HttpGet("GetCategories")]
        public IActionResult GetCategories()
        {
            return Ok(service.GetCategories());
        }

        [HttpGet("GetSubCategories/{id}")]
        public IActionResult GetSubCategories(int id)
        {
            return Ok(service.GetSubCategories(id));
        }

     
    }
}
