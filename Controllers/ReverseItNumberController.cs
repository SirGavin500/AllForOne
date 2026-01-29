using Microsoft.AspNetCore.Mvc;
using AllForOne.Services;

namespace AllForOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverseItNumberController : ControllerBase
{
    private readonly ReverseItNumberService service;

    public ReverseItNumberController(ReverseItNumberService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Reverse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return BadRequest("Input required.");
        }

        var result = service.Reverse(input);

        if (result == null)
        {
            return BadRequest("Numbers only.");
        }

        return Ok(result);
    }
}
