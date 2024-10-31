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

        var (isValid, questions) = DeserializeQuestion(geminiResponse);

        var response = new QuestionResponse();

        if (isValid)
        {
            response.Perguntas = questions!;
            response.Texto = text;
        }

        return response;
    }

    public async Task<List<ExplanationResponse>> RequestExplanationAsync(List<ExplanationRequest> request, CancellationToken cancellationToken)
    {
        var response = new List<ExplanationResponse>();

        foreach (var x in request)
        {
            var prompt = CreateExplanationMessage(x);

            var geminiResponse = await _gemini.GenerateContentAsync(prompt, cancellationToken);

            response.Add(new ExplanationResponse { Pergunta = x.Pergunta, Explicacao = geminiResponse });
        }

        return response;
    }

    private static ValueTuple<bool, List<Question>?> DeserializeQuestion(string json)
    {
        try
        {
            var response = JsonConvert.DeserializeObject<List<Question>>(json);
            return (true, response);

        }
        catch (Exception)
        {
            return (false, new List<Question>());
        }
    }

    private static string CreateExplanationMessage(ExplanationRequest request)
    {
        return string.Format(Text.Explanation, request.Pergunta, request.Resposta, request.Assinalada);
    }
}