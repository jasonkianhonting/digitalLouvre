using System.Net.Http.Headers;
using System.Threading.RateLimiting;
using Microsoft.AspNetCore.RateLimiting;

namespace backend.Extensions;

public static class WebExtensions
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient("ArtworkClient",
            client =>
            {
                client.BaseAddress =
                    new Uri(configuration.GetValue<string>("BaseURL") ?? string.Empty);
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("DigitalLouvre", "0.0.1"));
            });

        services.AddRateLimiter(rateLimitOptions =>
        {
            rateLimitOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
            rateLimitOptions.AddConcurrencyLimiter("ConcurrencyLimiter", options =>
            {
                options.PermitLimit = 10;
                options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
                options.QueueLimit = 5;
            });
        });
        services.AddCors(options =>
        {
            options.AddPolicy("ProductionPolicy", policy =>
            {
                policy.WithOrigins(configuration.GetValue<string>("ProdHostURL") ?? throw new Exception("Invalid URL"))
                    .WithMethods("GET")
                    .WithHeaders("Content-Type", "Authorization");
            });

            options.AddPolicy("DevPolicy", policy =>
            {
                policy.WithOrigins(configuration.GetValue<string>("HostURL") ?? throw new Exception("Invalid URL"))
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowAnyOrigin();
            });
        });

        services.AddHttpsRedirection(options =>
        {
            options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
            options.HttpsPort = configuration.GetValue<int>("RedirectHttpsPort");
        });

        services.AddHsts(options =>
        {
            options.Preload = true;
            options.IncludeSubDomains = true;
            options.MaxAge = TimeSpan.FromDays(60);
        });
        
        return services;
    }
}