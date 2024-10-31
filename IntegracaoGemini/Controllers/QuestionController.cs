using IntegracaoGemini.Domain.Contracts;
using IntegracaoGemini.Domain.Entities;
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

        var response = await _service.AskQuestionAsync(question, cancellationToken);

        if(string.IsNullOrWhiteSpace(response.Texto))
            return NotFound("Não foi possível encontrar perguntas para esse tema.");

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> RequestExplanation([FromBody] List<ExplanationRequest> request)
    {
        CancellationTokenSource cts = new(3000);
        CancellationToken cancellationToken = cts.Token;

        var x = await _service.RequestExplanationAsync(request, cancellationToken);

        if (!x.Any())
            return NotFound("Não foram encontradas explicações para essas perguntas.");

        return Ok(x);
    }
}