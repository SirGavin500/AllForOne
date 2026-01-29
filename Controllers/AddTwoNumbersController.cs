using Microsoft.AspNetCore.Mvc;
using AllForOne.Services;

namespace AllForOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AddTwoNumbersController : ControllerBase
{
    private readonly AddTwoNumbersService service;

    public AddTwoNumbersController(AddTwoNumbersService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Add(int a, int b)
    {
        return Ok(service.Add(a, b));
    }
}
