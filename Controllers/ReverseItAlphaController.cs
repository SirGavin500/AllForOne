using Microsoft.AspNetCore.Mvc;
using AllForOne.Services;

namespace AllForOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverseItAlphaController : ControllerBase
{
    private readonly ReverseItAlphaService service;

    public ReverseItAlphaController(ReverseItAlphaService service)
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

        return Ok(service.Reverse(input));
    }
}
