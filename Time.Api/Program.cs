var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/time", () => 
{
    return new 
    {
        CurrentTime = DateTime.UtcNow,
        TimeZone = "UTC"
    };
});

app.Run();
