using EPiServer.Core;
using FoundationNetCore.Features.Home;
using Microsoft.AspNetCore.Html;
using System.Web;

namespace FoundationNetCore.Features.Shared
{
    public interface IContentViewModel<out TContent> where TContent : IContent
    {
        TContent CurrentContent { get; }
        HomePage StartPage { get; }
        HtmlString SchemaMarkup { get; }
    }
}