using WebApplication2.Requests;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapPost("/test", (ILogger<Program> logger, Request request) =>
{
    logger.LogInformation("{Request}", request);

    var user = request.ToDomain();
});


app.Run();