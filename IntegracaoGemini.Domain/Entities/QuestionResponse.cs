namespace IntegracaoGemini.Domain.Entities;

public class QuestionResponse
{
    public List<Question> Perguntas { get; set; } = new();

    public string? Texto { get; set; }
}