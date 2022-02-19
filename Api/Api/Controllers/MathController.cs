using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : Controller
    {
        [HttpGet("CalcSquarePerimeter")]
        [SwaggerOperation(Tags = new[] {"Checking Account"})]
        // GET: MathController
        public int CountPerimeterOfSquare(int side)
        {
            return side * 4; 
        }

    }
}
