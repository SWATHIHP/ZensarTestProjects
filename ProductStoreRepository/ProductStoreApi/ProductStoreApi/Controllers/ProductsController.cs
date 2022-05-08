using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductStoreApi.Models;
using ProductStoreApi.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductRepository productRepository;

        public ProductsController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }

        [Produces("application/json")]
        [HttpGet("api/product/getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(productRepository.FindAll().ToList());
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("api/product/getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var product = await productRepository.FindById(id);
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("applicaton/json")]
        [Produces("application/json")]
        [HttpPost("api/product/insert")]
        public async Task<IActionResult> Insert(Product product)
        {
            try
            {
                await productRepository.InsertModel(product);
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("applicaton/json")]
        [Produces("application/json")]
        [HttpPut("api/product/update")]
        public async Task<IActionResult> Update(Product product)
        {
            try
            {
                await productRepository.UpdateModel(product.ProductId, product);
                return Ok(product);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("api/product/delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await productRepository.DeleteModel(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
