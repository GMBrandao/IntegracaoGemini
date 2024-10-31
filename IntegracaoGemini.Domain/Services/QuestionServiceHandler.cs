using IntegracaoGemini.Domain.Clients;
using IntegracaoGemini.Domain.Contracts;
using IntegracaoGemini.Domain.Entities;
using IntegracaoGemini.Domain.Models;
using Newtonsoft.Json;
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

    public async Task<QuestionResponse> AskQuestionAsync(string question, CancellationToken cancellationToken)
    {
        string text = Text.Programming;
        
        var sb = new StringBuilder();

        sb.AppendLine(Text.Base);
        sb.AppendLine(text);

        var geminiResponse = await _gemini.GenerateContentAsync(sb.ToString(), cancellationToken);

        var(isValid, questions) = JsonDeserialize(geminiResponse);

        var response = new QuestionResponse();

        if (isValid)
        {
            response.Perguntas = questions!;
            response.Texto = text;
        }

        return response;
    }

    public Task<List<ExplanationResponse>> RequestExplanationAsync(List<ExplanationRequest> request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    private ValueTuple<bool, List<Question>?> JsonDeserialize(string json)
    {
        try
        {
            var response = JsonConvert.DeserializeObject<List<Question>>(json);
            return (true, response);

        }
        catch (Exception ex)
        {
            return (false, new List<Question>());
        }
    }
}