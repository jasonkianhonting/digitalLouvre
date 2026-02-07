using backend.Interfaces;
using backend.Services;
using backend.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    options.JsonSerializerOptions.WriteIndented = true;
});


builder.Services.AddScoped<IArtworkService, ArtworkService>();

builder.Services.AddWebServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapGet("/debug/routes", (IEnumerable<EndpointDataSource> endpointSources) =>
        string.Join("\n", endpointSources.SelectMany(source => source.Endpoints)));
    app.UseExceptionHandler("/Home/Error");
    app.UseCors("DevPolicy");
}
else
{
    app.UseCors("ProductionPolicy");
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseRateLimiter();

app.UseHttpsRedirection();

app.MapStaticAssets();

app.MapControllers();

app.Run();