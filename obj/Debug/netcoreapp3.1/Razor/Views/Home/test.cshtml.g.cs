#pragma checksum "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cdc27146a4c272ea60f72bdd39de960d94724bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_test), @"mvc.1.0.view", @"/Views/Home/test.cshtml")]
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
#line 1 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\_ViewImports.cshtml"
using XO_WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\_ViewImports.cshtml"
using XO_WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cdc27146a4c272ea60f72bdd39de960d94724bb", @"/Views/Home/test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1852395f52f8846df74371979fd4b911549cb878", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\test.cshtml"
  
    ViewData["Title"] = "test Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center\">\n    <p>XO</p>\n    ");
#nullable restore
#line 9 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\test.cshtml"
Write(Html.TextAreaFor(m => m.xo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <p>xplayer</p>\n    ");
#nullable restore
#line 11 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\test.cshtml"
Write(Html.TextAreaFor(m => m.Xplayer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <p>cell name</p>\n    ");
#nullable restore
#line 13 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\test.cshtml"
Write(Html.TextAreaFor(m => m.cellname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainModel> Html { get; private set; }
    }
}
#pragma warning restore 1591