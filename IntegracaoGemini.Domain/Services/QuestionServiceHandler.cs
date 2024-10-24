using IntegracaoGemini.Domain.Contracts;

namespace IntegracaoGemini.Domain.Services;

public sealed class QuestionServiceHandler : IQuestionService
{
    private readonly IQuestionService _questionService;

    public QuestionServiceHandler(IQuestionService questionService)
    {
        _questionService = questionService;
    }

    public Task<string> AskQuestionAsync(string question, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}