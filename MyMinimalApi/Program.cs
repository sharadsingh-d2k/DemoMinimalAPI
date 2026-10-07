var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Name - Hello Sharad Singh Solanki! Address - Indore,M.P Number 123456789");

app.Run();
