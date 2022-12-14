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
    public class FridgeController : ControllerBase
    {
        private readonly IRepositoryFridge _repositoryService;

        public FridgeController(IRepositoryFridge repositoryService)
        {
            _repositoryService = repositoryService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repositoryService.GetAll());
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_repositoryService.GetById(id));
        }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult Post([FromBody] Fridge model)
        {
            var product = _repositoryService.Add(model);
            return Ok(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Fridge model)
        {
            var put = _repositoryService.GetById(id);
            if (put != null)
            {
                _repositoryService.Update(model);
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
            var del = _repositoryService.GetById(id);
            return Ok(del);
        }

        [HttpGet("searchproduct/{name}")]
        public IActionResult Get(string name)
        {
            var getName = _repositoryService.GetByName(name);
            if (getName.Name != name || getName == null)
            {
                return BadRequest("bulunamadı");
            }
            return Ok(getName);
        }
        [HttpGet("IncreaseCostList")]
        public IActionResult GetCostList()
        {
            return Ok(_repositoryService.toCostIncrease());
        }
        [HttpGet("DecreaseCostList")]
        public IActionResult DecreaseCostList()
        {
            return Ok(_repositoryService.toCostDecreasing());
        }

        //[HttpGet("costlist/{cost}")]
        //public IActionResult GetResult(int cost)
        //{
        //    return Ok(_repositoryService.CostRange(cost));
        //}
    }
}
