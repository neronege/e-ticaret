using e_ticaret.DomainService;
using e_ticaret.model;
using e_ticaret.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace e_ticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductCRUD  productCRUD;

        public ProductsController(IProductCRUD productCRUD)
        {
            this.productCRUD = productCRUD;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(productCRUD.GetAll());
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(productCRUD.GetById(id));
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] ProductModel model)
        {
            var product = productCRUD.Add(model);
            return Ok(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProductModel model)
        {
            var put = productCRUD.GetById(id);
            if(put != null)
            {
              productCRUD.Update(model);
            }
            else
            {
                BadRequest("id bulunamadı");
            }
            return Ok(put);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var del = productCRUD.GetById(id);
            return Ok(del);
        }

        [HttpGet("searchproduct/{name}")]
        public IActionResult Get(string name)
        {
            var getName = productCRUD.GetByName(name);
            if (getName.Name != name || getName == null)
            {
                return BadRequest("bulunamadı");
            }
            return Ok(getName);
        }

    }
}
