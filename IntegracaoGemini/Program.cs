using IntegracaoGemini.Domain.Clients;
using IntegracaoGemini.Domain.Contracts;
using IntegracaoGemini.Domain.Models;
using IntegracaoGemini.Domain.Services;
using Microsoft.Extensions.Options;

public static class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddCors(option =>
        {
            option.AddPolicy("AllowAll",
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
        });

        builder.Services.AddSingleton<IQuestionService, QuestionServiceHandler>();
        builder.Services.AddGemini(builder.Configuration);

        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors("AllowAll");
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }

    private static void AddGemini(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<GeminiOptions>(configuration.GetSection("Gemini"));

        services.AddTransient<GeminiDelegatingHandler>();

        services.AddHttpClient<GeminiClient>(
            (serviceProvider, httpClient) =>
            {
                var geminiOptions = serviceProvider.GetRequiredService<IOptions<GeminiOptions>>().Value;

                httpClient.BaseAddress = new Uri(geminiOptions.Url);
            })
            .AddHttpMessageHandler<GeminiDelegatingHandler>();
    }
}