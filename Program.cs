using NetHtmxSite.Templates;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string index(HttpContext context){
    context.Response.ContentType = "text/html";
    return IndexTemplate.Render("someone");
}
string someContent(HttpContext context){
    
    context.Response.ContentType = "text/html";
    return SomeContent.Render("hi from another endpoint");

}
app.MapGet("/", index);
app.MapPost("/clicked", someContent); 
app.Run();
