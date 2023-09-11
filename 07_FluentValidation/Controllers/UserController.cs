using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _07_FluentValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (!user.Mail.EndsWith("gmail.com"))
            {
                ModelState.AddModelError("Mail","Mail gmail olmak zorundadır.");
                return BadRequest(ModelState);
            }
            return Ok();
        }
    }
}
