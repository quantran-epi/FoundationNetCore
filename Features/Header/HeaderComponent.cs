using EPiServer;
using EPiServer.Web.Routing;
using FoundationNetCore.Features.Home;
using FoundationNetCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundationNetCore.Features.Header
{
    public class HeaderViewComponent : FoundationViewComponent
    {
        private readonly IHeaderViewModelFactory _headerViewModelFactory;
        private readonly IContentRouteHelper _contentRouteHelper;

        public HeaderViewComponent(IHeaderViewModelFactory headerViewModelFactory,
            IContentRouteHelper contentRouteHelper)
        {
            _headerViewModelFactory = headerViewModelFactory;
            _contentRouteHelper = contentRouteHelper;
        }

        public async Task<IViewComponentResult> InvokeAsync(HomePage homePage)
        {
            var content = _contentRouteHelper.Content;
            return View("_Header", _headerViewModelFactory.CreateHeaderViewModel(content, homePage));
        }
    }
}
