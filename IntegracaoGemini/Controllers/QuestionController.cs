using Microsoft.AspNetCore.Mvc;

namespace IntegracaoGemini.Controllers;

[Route("api/question")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly ILogger<QuestionController> _logger;

    public QuestionController(ILogger<QuestionController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> AskQuestion(string question)
    {
        return Ok();
    }
}