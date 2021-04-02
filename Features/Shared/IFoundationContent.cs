using EPiServer.SpecializedProperties;

namespace FoundationNetCore.Features.Shared
{
    public interface IFoundationContent
    {
        bool HideSiteHeader { get; set; }
        bool HideSiteFooter { get; set; }
        LinkItemCollection CssFiles { get; set; }
        string Css { get; set; }
        LinkItemCollection ScriptFiles { get; set; }
        string Scripts { get; set; }
    }
}
