using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet]
        [Route("obter-texto/{numA}/{numB}")]
        public IActionResult GetData(int numA, int numB)
        {
            return Ok(numA * numB);
        }
    }
}
