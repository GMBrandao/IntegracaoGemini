using IntegracaoGemini.Domain.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoGemini.Controllers;

[Route("api/question")]
[ApiController]
public class QuestionController : ControllerBase
{
    private readonly ILogger<QuestionController> _logger;
    private readonly IQuestionService _service;

    public QuestionController(
        ILogger<QuestionController> logger,
        IQuestionService service
        )
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> AskQuestion(string question)
    {
        CancellationTokenSource cts = new(3000);
        CancellationToken cancellationToken = cts.Token;

        var x = await _service.AskQuestionAsync(question, cancellationToken);
        return Ok(x);
    }
}