using IntegracaoGemini.Domain.Clients;
using IntegracaoGemini.Domain.Contracts;
using IntegracaoGemini.Domain.Models;
using System.Text;

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
        var sb = new StringBuilder();

        sb.AppendLine(Text.Base);
        sb.AppendLine(Text.Programming);
        
        var response = await _gemini.GenerateContentAsync(sb.ToString(), cancellationToken);

        return response;
    }
}