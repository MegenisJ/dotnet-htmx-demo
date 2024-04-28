using NetHtmxSite.Templates;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string index(HttpContext context){
    context.Response.ContentType = "text/html";
    return IndexTemplate.Render("someone");
}

app.MapGet("/", index);

app.Run();
