using Microsoft.OpenApi.Models;
using Emerald.Tiger.Api.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
var builder = WebApplication.CreateBuilder(args);

string authority = builder.Configuration["Auth0:Authority"] ??
    throw new ArgumentNullException("Auth0:Authority");

    string audience = builder.Configuration["Auth0:Audience"] ??
    throw new ArgumentNullException("Auth0:Audience");


// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddAuthentication(options =>
{
    options.AddPolicy("delete:catalog" , policy =>
    policy.RequireAuthenticatedUser().RequireClaim("scope", "delete:catalog"));
    
        
};


{
    options.DefaultAuthenticateScheme = JustBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.addJwtBearer(options => 
{

    options.Authority = authority;
    options.Audience = audience;
});




// Register the Swagger generator, defining one or more Swagger documents
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API",
        Version = "v1"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    });
}

app.MapControllers();
app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
