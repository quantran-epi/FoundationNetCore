using FoundationNetCore.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoundationNetCore.Features.Header
{
    public class NavigationViewComponent : FoundationViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(HeaderViewModel headerViewModel)
        {
            return View("_Navigation", headerViewModel);
        }
    }
}
