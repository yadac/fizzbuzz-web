using Microsoft.AspNetCore.Mvc;
using FizzBuzz;

[ApiController]
[Route("api/[controller]")]
public class FizzBuzzController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] int start = 1, [FromQuery] int end = 100)
    {
        var results = new List<string>();
        var logic = new FizzBuzzLogic();
        for (var i = start; i <= end; i++)
        {
            results.Add(logic.GetResult(i));
        }
        return Ok(results);
    }
}