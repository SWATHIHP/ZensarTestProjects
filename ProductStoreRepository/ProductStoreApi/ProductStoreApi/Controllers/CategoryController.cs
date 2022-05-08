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
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }

        [Produces("application/json")]
        [HttpGet("api/category/getall")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(categoryRepository.FindAll().ToList());
            }
            catch
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpGet("api/category/getforid/{id}")]
        public async Task<IActionResult> GetForId(int id)
        {
            try
            {
                var category = await categoryRepository.FindById(id);
                return Ok(category);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("applicaton/json")]
        [Produces("application/json")]
        [HttpPost("api/category/insert")]
        public async Task<IActionResult> Insert(Category category)
        {
            try
            {
                await categoryRepository.InsertModel(category);
                return Ok(category);
            }
            catch
            {
                return BadRequest();
            }
        }

        [Consumes("applicaton/json")]
        [Produces("application/json")]
        [HttpPut("api/category/update")]
        public async Task<IActionResult> Update(Category category)
        {
            try
            {
                await categoryRepository.UpdateModel(category.CategoryId, category);
                return Ok(category);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
