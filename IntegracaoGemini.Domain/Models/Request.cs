namespace IntegracaoGemini.Domain.Models;

public sealed class GeminiRequest
{
    public GeminiContent[] Contents { get; set; }
    public GenerationConfig GenerationConfig { get; set; }
    public SafetySettings[] SafetySettings { get; set; }
}

public sealed class GeminiContent
{
    public string Role { get; set; }
    public GeminiPart[] Parts { get; set; }
}

public sealed class GeminiPart
{
    public string Text { get; set; }
}

public sealed class GenerationConfig
{
    public int Temperature { get; set; }
    public int TopK { get; set; }
    public int TopP { get; set; }
    public int MaxOutputTokens { get; set; }
    public List<object> StopSequences { get; set; }
}

public sealed class SafetySettings
{
    public string Category { get; set; }
    public string Threshold { get; set; }
}
