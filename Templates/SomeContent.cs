using Scriban;
namespace NetHtmxSite.Templates;
public static class SomeContent{
    public static string Render(string value){
        return indexPage.Render(new {value = value});
    }

    private static Template indexPage = Template.Parse(
        @"
          new endpoint response  {{value}}
        "
    );
}
