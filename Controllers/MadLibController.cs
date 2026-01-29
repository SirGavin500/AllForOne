using Microsoft.AspNetCore.Mvc;
using AllForOne.Services;

namespace AllForOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MadLibController : ControllerBase
{
    private readonly MadLibService service;

    public MadLibController(MadLibService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Create(string noun, string adjective, string verb)
    {
        if (string.IsNullOrWhiteSpace(noun) ||
            string.IsNullOrWhiteSpace(adjective) ||
            string.IsNullOrWhiteSpace(verb))
        {
            return BadRequest("All inputs are required.");
        }

        return Ok(service.Create(noun, adjective, verb));
    }
}
