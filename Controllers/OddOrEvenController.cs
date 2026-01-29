using Microsoft.AspNetCore.Mvc;
using AllForOne.Services;

namespace AllForOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OddOrEvenController : ControllerBase
{
    private readonly OddOrEvenService service;

    public OddOrEvenController(OddOrEvenService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Check(int number)
    {
        return Ok(service.Check(number));
    }
}
