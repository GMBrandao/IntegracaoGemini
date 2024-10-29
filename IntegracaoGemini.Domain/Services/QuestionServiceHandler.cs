using IntegracaoGemini.Domain.Clients;
using IntegracaoGemini.Domain.Contracts;
using IntegracaoGemini.Domain.Models;

namespace IntegracaoGemini.Domain.Services;

public sealed class QuestionServiceHandler : IQuestionService
{
    private readonly GeminiClient _gemini;

    public QuestionServiceHandler(
        GeminiClient gemini)
    {
        _gemini = gemini;
    }

    public async Task<string> AskQuestionAsync(string question, CancellationToken cancellationToken)
    {
        question = Teste.a;

        var x = await _gemini.GenerateContentAsync(question, cancellationToken);

        return x;
    }
}