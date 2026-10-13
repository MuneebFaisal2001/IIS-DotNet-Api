using Microsoft.AspNetCore.Mvc;

namespace MyCustomApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        // 1. Simple Welcome Endpoint
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok(new
            {
                message = "Hello from Muneeb's Custom IIS API!",
                status = "Success",
                server = "IIS Local Web Server"
            });
        }

        // 2. Simple Addition Endpoint (num1 + num2)
        [HttpGet("add")]
        public IActionResult AddNumbers(int num1, int num2)
        {
            int sum = num1 + num2;
            return Ok(new
            {
                firstNumber = num1,
                secondNumber = num2,
                result = sum
            });
        }
    }
}