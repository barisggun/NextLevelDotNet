using _10_CustomModelBinder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _10_CustomModelBinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost("{ProductID}")]
        public IActionResult AddProduct(Product product)
        {
            return Ok();
        }
    }
}
