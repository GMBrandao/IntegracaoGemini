using IntegracaoGemini.Domain.Models;
using Microsoft.Extensions.Options;

namespace IntegracaoGemini.Domain.Services;

public sealed class GeminiDelegatingHandler : DelegatingHandler
{
    private readonly GeminiOptions _geminiOptions;

    public GeminiDelegatingHandler(IOptions<GeminiOptions> geminiOptions)
    {
        _geminiOptions = geminiOptions.Value;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        request.Headers.Add("x-goog-api-key", $"{_geminiOptions.ApiKey}");

        return base.SendAsync(request, cancellationToken);
    }
}
