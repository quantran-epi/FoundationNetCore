using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.Web;
using EPiServer.Web;
using FoundationNetCore.Features.Home;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundationNetCore.Features.Preview
{
    /// <summary>
    /// Used to keep common code for the preview controllers
    /// </summary>
    public class PreviewControllerHelper
    {
        private readonly IContentLoader _contentLoader;
        private readonly TemplateResolver _templateResolver;
        private readonly DisplayOptions _displayOptions;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PreviewControllerHelper(IContentLoader contentLoader, TemplateResolver templateResolver, DisplayOptions displayOptions, IHttpContextAccessor httpContextAccessor)
        {
            _contentLoader = contentLoader;
            _templateResolver = templateResolver;
            _displayOptions = displayOptions;
            _httpContextAccessor = httpContextAccessor;
        }

        public ActionResult RenderResult(IContent currentContent, ViewDataDictionary viewData)
        {
            //As the layout requires a page for title etc we "borrow" the start page
            var startPage = _contentLoader.Get<HomePage>(ContentReference.StartPage);

            var model = new PreviewModel(startPage, currentContent);

            var supportedDisplayOptions = _displayOptions
                .Select(x => new
                {
                    x.Tag,
                    x.Name,
                    Supported = SupportsTag(currentContent, x.Tag)
                }).ToList();

            if (!supportedDisplayOptions.Any(x => x.Supported))
            {
                return new ViewResult
                {
                    ViewName = "~/Features/Preview/Index.cshtml",
                    ViewData = new ViewDataDictionary<PreviewModel>(viewData, model)
                };
            }
            foreach (var displayOption in supportedDisplayOptions)
            {
                var contentArea = new ContentArea();
                contentArea.Items.Add(new ContentAreaItem
                {
                    ContentLink = currentContent.ContentLink
                });
                var areaModel = new PreviewModel.PreviewArea
                {
                    Supported = displayOption.Supported,
                    AreaTag = displayOption.Tag,
                    AreaName = displayOption.Name,
                    ContentArea = contentArea
                };

                model.Areas.Add(areaModel);
            }

            return new ViewResult
            {
                ViewName = "~/Features/Preview/Index.cshtml",
                ViewData = new ViewDataDictionary<PreviewModel>(viewData, model)
            };
        }

        private bool SupportsTag(IContent content, string tag)
        {
            var templateModel = _templateResolver.Resolve(_httpContextAccessor.HttpContext,
                content.GetOriginalType(),
                content,
                TemplateTypeCategories.MvcPartial,
                tag);

            return templateModel != null;
        }

    }
}
