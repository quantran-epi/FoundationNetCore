#pragma checksum "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3478b5d4ab93c138a4eea11f8cb66f41ef061c39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_Shared_Views_Header__Navigation), @"mvc.1.0.view", @"/Features/Shared/Views/Header/_Navigation.cshtml")]
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
#line 6 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\_ViewImports.cshtml"
using EPiServer.Web.Mvc;

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
#line 1 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
using EPiServer.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
using EPiServer.Web.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
using FoundationNetCore.Features.Header;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3478b5d4ab93c138a4eea11f8cb66f41ef061c39", @"/Features/Shared/Views/Header/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ebe396dc78fadf919ffbd0c34322cb315f74961", @"/Features/_ViewImports.cshtml")]
    public class Features_Shared_Views_Header__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HeaderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
Write(Html.FullRefreshPropertiesMetaData(new[] { "MainMenu", "SiteLogo" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
  
    var navigationHeight = Model.LayoutSettings.LogoHeight + 20;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Navigation bar for Desktop -->\r\n<div class=\"d-none d-lg-block\">\r\n    <nav class=\"container\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"navigation\"");
            BeginWriteAttribute("style", " style=\"", 491, "\"", 528, 3);
            WriteAttributeValue("", 499, "height:", 499, 7, true);
#nullable restore
#line 16 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
WriteAttributeValue(" ", 506, navigationHeight, 507, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 526, "px", 526, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"                <ul class=""navigation__right"">
                    <li>
                        <div class=""icon-menu"" id=""js-searchbutton"">
                            <i data-feather=""search""></i>
                        </div>
                        <div class=""searchbox"" id=""js-searchbox"">
                            <i class=""icon-left"" data-feather=""search""></i>
                            <input type=""hidden"" id=""searchOption""");
            BeginWriteAttribute("value", " value=\"", 2495, "\"", 2537, 1);
#nullable restore
#line 46 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
WriteAttributeValue("", 2503, Model.SearchSettings.SearchOption, 2503, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input placeholder=\"Search\" id=\"js-searchbox-input\" class=\"jsSearchText\"\r\n                                   data-search=\"");
#nullable restore
#line 48 "C:\Users\qutr2\source\netcore\FoundationNetCore\Features\Shared\Views\Header\_Navigation.cshtml"
                                           Write(Url.ContentUrl(Model.ReferencePageSettings.SearchPage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                                   data-result-container=""#jsResultSearch"" />
                            <input type=""hidden"" id=""searchConfidence"" value=""1"" />
                            <input class=""hidden"" type=""file"" id=""fileSearchInput"" />
                            <div class=""icon-right"">
                                <i data-feather=""camera"" class=""jsSearchImage"" data-input=""#fileSearchInput""></i>
                                <i data-feather=""x"" id=""js-searchbox-close""></i>
                            </div>
                        </div>
                        <div class=""searchbox-popover"" id=""jsResultSearch"" style=""display: none"">
                            <div style=""position: relative; min-height: 80px;"">
                                <div class=""loading-cart"" style=""display: none"">
                                    <div class=""loader""></div>
                                </div>
                                <div class=""js-searchbox-content"">
                 ");
            WriteLiteral("               </div>\r\n                            </div>\r\n                        </div>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n</div>\r\n<!-- END - Navigation bar for Desktop -->");
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