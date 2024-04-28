using Scriban;
namespace NetHtmxSite.Templates;

public static class IndexTemplate{
    
    public static string Render(string name){
        return indexPage.Render(new {name = name});
    }

    private static Template indexPage = Template.Parse(
        @"
        <html>
            <body>
                <h1>Hello {{name}}</h1>
                <h2>Some text here</h2>
            </body>
        </html>
        "
    );
}
