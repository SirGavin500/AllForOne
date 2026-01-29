using Microsoft.AspNetCore.Mvc;
using AllForOne.Services;

namespace AllForOne.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AskQuestionController : ControllerBase
{
    private readonly AskQuestionService service;

    public AskQuestionController(AskQuestionService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult Ask(string question)
    {
        if (string.IsNullOrWhiteSpace(question))
        {
            return BadRequest("Question is required.");
        }

        return Ok(service.Ask(question));
    }
}
