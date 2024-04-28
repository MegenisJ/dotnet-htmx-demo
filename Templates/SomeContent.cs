using Scriban;
namespace NetHtmxSite.Templates;
public static class SomeContent{

    public static string Render(HttpContext context){
        context.Response.ContentType = "text/html";
        return someContent.Render(new {name = "World"});
    }

    private static Template someContent = Template.Parse(
        @"
          new endpoint response  {{value}}
        "
    );
}
