using _06_ModelBinding02.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _06_ModelBinding02.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //// Primitive Types
        // >> int, short, byte, long, uint, ushort, ulong, sbyte (tam sayı)
        // >> double, float, decimal (ondalıklı)
        // >> string, char 
        // >> bool
        // >> object

        // c# tip güvenli dildir. bir değişkeni tanımlarken hangi değişkende değer alacağını atıyorsak bu bir tip güvenli dildir. hangi türden veri taşıyacaksak onu tanımlanır.


       //// Complex Types [Request BODY]
       // >> default olarak requestin bodySinde gelecek şekilde vardır endpointin içerisinde.
       

       //public IActionResult Get([FromQuery]int number)
       // {
       //     return Ok();
       // }

       // [HttpGet("{sehir}")]
       // public IActionResult GetData([FromRoute]string sehir)
       // {
       //     return Ok();
       // }

        //[HttpGet]
        //public IActionResult AddProduct([FromQuery]Product product)
        //{
        //    return Ok();
        //}
        //[HttpPost]
        //public IActionResult Post([FromBody]string sehir)
        //{
        //    return Ok();
        //}

        //public IActionResult Get([FromForm]Product product)
        //{
        //    return Ok();
        //}

        public IActionResult Get([FromHeader] string sehir)
        {
            //Request.RouteValues
            //Request.Query
            //Request.Headers.TryGetValue   
            return Ok();
        }
    }
}
