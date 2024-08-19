using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeAPI.Repositories;
using PracticeAPI.Entities;

namespace PracticeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpPost, Route("AddProduct")]
        public IActionResult Add(Product product)
        {
            try
            {
                productRepository.Add(product);
                return Ok(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetAll")]
        public IActionResult GetAll() {
            try
            {
                var products = productRepository.GetAll();
                return Ok(products);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete, Route("DeleteById/{id}")]
        public IActionResult Delete(int id) {
            try
            {
                productRepository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("GetByName/{name}")]
        public IActionResult GetByName(string name) {
            try
            {
               var product = productRepository.GetByTitle(name);
                return Ok(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPut, Route("Update")]
        public IActionResult Update(Product product) {
            try
            {
                productRepository.Update(product);
                return Ok(product);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
                return BadRequest(ex.Message);
            }
        }
    }
}
