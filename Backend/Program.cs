using backend.Classes;
using backend.Interfaces;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    options.JsonSerializerOptions.WriteIndented = true;
});

var connectionString = builder.Configuration.GetConnectionString("DatabaseString") ??
                       throw new Exception("Database connection string not found");

builder.Services.AddDbContext<DigitalLouvreContext>(option =>
{
    option.UseNpgsql(connectionString);
});

builder.Services.AddHttpClient("ArtworkClient",
    client =>
    {
        client.BaseAddress =
            new Uri(builder.Configuration.GetValue<string>("BaseURL") ?? string.Empty);
        client.DefaultRequestHeaders.Add("user-Agent",
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:134.0) Gecko/20100101 Firefox/134.0");
    });

builder.Services.AddScoped<IArtworkServices, ArtworkServices>();
builder.Services.AddTransient<IUserServices, UserServices>();
builder.Services.AddTransient<ITokenServices, TokenServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.MapGet("/debug/routes", (IEnumerable<EndpointDataSource> endpointSources) =>
        string.Join("\n", endpointSources.SelectMany(source => source.Endpoints)));
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(options =>
    options.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllers();

app.Run();