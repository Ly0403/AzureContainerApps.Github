var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () => "Deployed to Azure Container Apps");
app.MapGet("/v2", () => "Deployed to Azure Container Apps v2");

app.Run();