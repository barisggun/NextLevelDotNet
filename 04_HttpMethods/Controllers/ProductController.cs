using _04_HttpMethods.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _04_HttpMethods.Controllers
{
    [Route("api/[controller]")]

    //[Route("api/[controller]/[action]")] //IActionresult altına yazacağımıza burada belirttik.
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        //[Route("[action]")] Controller'daki route ile birleşip çalışırlar.
        public IActionResult GetProducts()
        {
            List<string> products = new List<string>() { "Laptop", "Klavye", "Mouse" };

            return Ok(products);
        }

        [HttpGet("{id}")] //urlde id yollarsak bu metot çalışır yollamazsak yukarıdaki metot çalışır.
        //[Route("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok("Laptop");
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            //return Ok();
            return Created("api/product/5",product); //201 kodudur. evet oluşturuldu. Response için bir link oluşturmamız gerekir.
            //200 dönülmemeli created olduğu için post olduğu için 201 olmalıdır. önemlidir.
        }
    }
}
