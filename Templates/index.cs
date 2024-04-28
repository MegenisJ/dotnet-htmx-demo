using Scriban;
namespace NetHtmxSite.Templates;

public static class IndexTemplate{

    public static string Render(HttpContext context){
        context.Response.ContentType = "text/html";
        return indexPage.Render(new {name = "World"});
    }

    private static Template indexPage = Template.Parse(
        @"
        <html>
            <head>
                <script src=""https://unpkg.com/htmx.org@1.9.12""></script>
            </head>
            <body>
                <h1>Hello {{name}}</h1>
                <h2>Some text here</h2>
                <div class = ""replace-me"">
                    <button hx-post=""/clicked"" hx-swap=""outerHTML"">
                        Click Me!
                    </button>
                </div>
            </body>
        </html>
        "
    );
}
