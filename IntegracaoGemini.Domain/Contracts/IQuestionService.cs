using IntegracaoGemini.Domain.Entities;

namespace IntegracaoGemini.Domain.Contracts;

public interface IQuestionService
{
    Task<QuestionResponse> AskQuestionAsync(string question, CancellationToken cancellationToken);

    Task<List<ExplanationResponse>> RequestExplanationAsync(List<ExplanationRequest> request, CancellationToken cancellationToken);
}