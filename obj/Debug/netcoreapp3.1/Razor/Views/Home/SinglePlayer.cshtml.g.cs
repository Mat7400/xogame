#pragma checksum "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb7eddc3f8f3ebad278cbc89c0f7fc83117215d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SinglePlayer), @"mvc.1.0.view", @"/Views/Home/SinglePlayer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb7eddc3f8f3ebad278cbc89c0f7fc83117215d", @"/Views/Home/SinglePlayer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1852395f52f8846df74371979fd4b911549cb878", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SinglePlayer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "reload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome to XO by mat7400 - sinleplayer mode 7x7 </h1>\n    <!-- поле 7х7 -->\n    <p>\n        >Click  to generate X or O</p>\n        <p> \n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dfb7eddc3f8f3ebad278cbc89c0f7fc83117215d3905", async() => {
                WriteLiteral("reload game");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </p>\n    <p>player ");
#nullable restore
#line 15 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
         Write(Model.CurrentPlayer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" move</p>\n");
#nullable restore
#line 16 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
     for (int i = 0; i < 7; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
   Write(Html.Raw(Model.beginhtml[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
                                     ; 
        for (int j = 0; j < 7; j++)
        {
            string curr = Model.strarr[j,i];

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
       Write(Html.Raw(curr));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
                           ; 
            
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
       Write(Model.Field2[j,i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
                              ;

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
       Write(Html.Raw("  </a></div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
                                     ;
        }
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
   Write(Html.Raw(Model.endhtml[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\matve\Downloads\XOWebAppMVC-main\XOWebAppMVC-main\Views\Home\SinglePlayer.cshtml"
                                   ;  
            
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
