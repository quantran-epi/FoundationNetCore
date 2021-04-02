using EPiServer.Web.Mvc;
using FoundationNetCore.Features.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FoundationNetCore.Features.Home
{
    public class HomeController : PageController<HomePage>
    {
        public ActionResult Index(HomePage currentContent)
        {
            return View(ContentViewModel.Create<HomePage>(currentContent));
        }
    }
}
