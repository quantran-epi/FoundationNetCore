#pragma checksum "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b55722888eb2126ca9969273046d87b1a16367fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_Shared_Views_Header__Header), @"mvc.1.0.view", @"/Features/Shared/Views/Header/_Header.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Framework.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Web.Mvc.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Shell.Web.Mvc.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Web.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using FoundationNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using FoundationNetCore.Features;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using FoundationNetCore.Features.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
using FoundationNetCore.Features.Header;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b55722888eb2126ca9969273046d87b1a16367fb", @"/Features/Shared/Views/Header/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe396dc78fadf919ffbd0c34322cb315f74961", @"/Features/_ViewImports.cshtml")]
    public class Features_Shared_Views_Header__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HeaderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
 if (Model.IsReadonlyMode)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
                                     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"top-header\"");
            BeginWriteAttribute("style", " style=\"", 179, "\"", 242, 2);
            WriteAttributeValue("", 187, "background:", 187, 11, true);
#nullable restore
#line 11 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
WriteAttributeValue(" ", 198, Model.LayoutSettings.HeaderBackgroundColor, 199, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12\">\r\n                    <div class=\"top-header__banner-text\">\r\n");
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 18 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
                     if (!User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"login-button\">\r\n                            <a class=\"login-url\" href=\"/episerver\">\r\n                                Login\r\n                            </a>\r\n                        </div>\r\n");
#nullable restore
#line 25 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header");
            BeginWriteAttribute("class", " class=\"", 930, "\"", 1004, 2);
            WriteAttributeValue("", 938, "header", 938, 6, true);
#nullable restore
#line 32 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
WriteAttributeValue(" ", 944, Model.LayoutSettings.StickyTopHeader ? "sticky-top" : "", 945, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"header__wrapper\">\r\n");
            WriteLiteral("        ");
#nullable restore
#line 36 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Header.cshtml"
    Write(await Component.InvokeAsync("Navigation", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</header>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HeaderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
