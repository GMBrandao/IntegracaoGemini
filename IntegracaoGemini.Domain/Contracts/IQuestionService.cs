using IntegracaoGemini.Domain.Entities;

namespace IntegracaoGemini.Domain.Contracts;

public interface IQuestionService
{
    Task<List<Question>> AskQuestionAsync(string question, CancellationToken cancellationToken);
}