using IntegracaoGemini.Domain.Clients;
using IntegracaoGemini.Domain.Contracts;
using IntegracaoGemini.Domain.Entities;
using IntegracaoGemini.Domain.Models;
using Newtonsoft.Json;
using System.Text;
using static Google.Apis.Requests.BatchRequest;

namespace IntegracaoGemini.Domain.Services;

public sealed class QuestionServiceHandler : IQuestionService
{
    private readonly GeminiClient _gemini;

    public QuestionServiceHandler(
        GeminiClient gemini)
    {
        _gemini = gemini;
    }

    public async Task<List<Question>> AskQuestionAsync(string question, CancellationToken cancellationToken)
    {
        var sb = new StringBuilder();

        sb.AppendLine(Text.Base);
        sb.AppendLine(Text.Programming);

        var response = await _gemini.GenerateContentAsync(sb.ToString(), cancellationToken);

        var(isValid, questions) = JsonDeserialize(response);

        return isValid ? questions ?? new List<Question>() : new List<Question>();
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