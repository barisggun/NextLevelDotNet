using _09_CustomModelBinder.CustomBinder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _09_CustomModelBinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // api/order/?ay=10&gun=12&yil=2015
        public IActionResult GetReport([ModelBinder(typeof(HeisenbergDateTimeBinder))]DateTime date)
        {
            //date.GetType().GetProperty("Year").GetType(); //Object sınıfının içerisinde yazılan bir metottur.

            //typeof(DateTime).GetProperties();
        
            if (date == default(DateTime))
            {
                return BadRequest();
            }

            return Ok(date);
        }
    }
}
