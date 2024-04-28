using NetHtmxSite.Templates;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", IndexTemplate.Render);
app.MapPost("/clicked", SomeContent.Render); 

app.Run();
