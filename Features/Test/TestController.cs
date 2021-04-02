using EPiServer.Web.Mvc;
using FoundationNetCore.Features.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FoundationNetCore.Features.Test
{
    public class TestController : PageController<TestPage>
    {
        public ActionResult Index(TestPage currentContent)
        {
            return View(ContentViewModel.Create<TestPage>(currentContent));
        }
    }
}
