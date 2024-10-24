namespace IntegracaoGemini.Domain.Contracts;

public interface IQuestionService
{
    Task<string> AskQuestionAsync(string question, CancellationToken cancellationToken);
}