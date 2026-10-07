var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Name - Hello Sharad Singh Solanki! Add - Indore,M.P ");

app.Run();
