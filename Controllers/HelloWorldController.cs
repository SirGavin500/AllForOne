using Microsoft.AspNetCore.Mvc;

using AllForOne.Services;


namespace AllForOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HelloWorldController : ControllerBase
{
    private readonly HelloWorldService service;

    public HelloWorldController(HelloWorldService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.GetMessage());
    }
}
