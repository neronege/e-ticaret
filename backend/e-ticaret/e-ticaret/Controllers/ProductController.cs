using e_ticaret.DomainService;
using e_ticaret.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.OpenApi.Any;
using System.Collections.Generic;
using System.Linq;

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
        [HttpGet("GetDresses")]
        public IActionResult GetDresses()
        {
            return Ok(service.GetDresses());
        }
        [HttpGet("GetToys")]
        public IActionResult GetToys()
        {
            return Ok(service.GetToys());
        }
        [HttpGet("GetOutdoor")]
        public IActionResult GetOutdoors()
        {
            return Ok(service.GetOutdoors());
        }

        [HttpPost("PostProduct")]

        public IActionResult PostProduct([FromBody] Product model)
        {
            var product = service.Add(model);
            return Ok(product);
        }

        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return Ok();
        }

        [HttpGet("GetBydId/{id}")]
        public IActionResult GetById(int id)
        {
            service.GetById(id);
            return Ok();
        }

        [HttpGet("GetByName/{name}")]

        public IActionResult GetByName(string name)
        {
            service.GetByName(name);
            return Ok();
        }

        [HttpPut("PutProduct/{id}")]

        public IActionResult Update([FromBody] Product product, int id)
        {
            var model = GetById(id);
            if (model != null)
            {
                service.Update(product);
            }
            else
            {
                return BadRequest();
            }
            return Ok(model);
        }

        [HttpGet("GetProdutcsByproductType/{productType}")]

        public IActionResult GetProductsByproductType(ProductType productType)
        {
            var products = service.GetProductsByProductType(productType);
            return Ok(products);
        }


        [HttpGet("GetProductsBySubCategory/{productType}/{subCategory}")]
        public IActionResult GetProductsBySubCategory( ProductType productType, int subCategory)
        {
            return Ok(GetProductsBySubCategory(productType, subCategory));
            //var products = GetProductsByproductType(productType);
            //if (products == GetDresses())
            //{
            //  service.GetSubCategory(subCategory);
            //}
            //if (products == GetToys())
            //{
            //    service.GetSubCategory(subCategory);
            //}
            //if (products == GetOutdoors())
            //{
            //    service.GetSubCategory(subCategory);
            //}
            //if (products == GetElectronics())
            //{
            //   GetSubCategory(subCategory);
            //}
            //else
            //{
            //    return BadRequest();
            //}
            //return Ok(products);
        }

        [HttpGet("GetSubCategory/{subCategory}")]
        public IActionResult GetSubCategory(int subCategory)
        {
            return Ok(GetSubCategory(subCategory));
        }

        [HttpGet("IncreaseCostList/{productType}/{subCategory}")]
        public IActionResult GetIncreaseCostList(ProductType productType, int subCategory)
        {
            var products = GetProductsByproductType(productType);
            if (products == GetElectronics())
            {

                service.toCostIncrease(subCategory);
            }

            if (products == GetDresses())
            {
              
                service.toCostIncrease(subCategory);
            }
            if (products == GetToys())
            {
              
                service.toCostIncrease(subCategory);
            }
            if (products == GetOutdoors())
            {
             
                service.toCostIncrease(subCategory);
            }
        
            return Ok(products);
        }
      
        
        [HttpGet("GetSubCategoriesbyProductType/{productType}")]

        public IActionResult GetSubCategoriesByProductType(ProductType productType)
        {
            var products = service.GetSubCategoriesByProductType(productType);
            return Ok(products);
        }
    }
}

