using Microsoft.AspNetCore.Mvc;
using WEB_API.Models;

namespace WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character Knight = new Character();

        [HttpGet]
        public ActionResult<Character> Get()
        {
        return Ok(Knight);
        }
    }

    
}