var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! Name - Hello Sharad Singh Solanki! Address - Indore,M.P Number 000000000000000");

app.Run();
