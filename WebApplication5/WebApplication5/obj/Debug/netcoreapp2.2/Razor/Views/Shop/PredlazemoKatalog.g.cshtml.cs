#pragma checksum "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "290703165ab041e3689479ff3ff67818820ddc05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_PredlazemoKatalog), @"mvc.1.0.view", @"/Views/Shop/PredlazemoKatalog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/PredlazemoKatalog.cshtml", typeof(AspNetCore.Views_Shop_PredlazemoKatalog))]
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
#line 1 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5;

#line default
#line hidden
#line 2 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\_ViewImports.cshtml"
using WebApplication5.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"290703165ab041e3689479ff3ff67818820ddc05", @"/Views/Shop/PredlazemoKatalog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_PredlazemoKatalog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("div-align fa fa-shopping-basket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DodajItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(47, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
  
    ViewData["Title"] = "Predlazemo katalog";

#line default
#line hidden
            BeginContext(105, 92, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"meni-main-bg\">\r\n    <h1 class=\"mnogo-jak-naslov\">Predlažemo Katalog</h1>\r\n");
            EndContext();
            BeginContext(322, 59, true);
            WriteLiteral("    <div class=\"w-75\">\r\n        <div class=\"card-deck\">\r\n\r\n");
            EndContext();
#line 17 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
             foreach (KatalogSaProizvodima meni in Model)
            {


#line default
#line hidden
            BeginContext(457, 102, true);
            WriteLiteral("                <div class=\"list-group-item katalog-bg\">\r\n\r\n\r\n                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("accept", " accept=\"", 559, "\"", 591, 1);
#line 23 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
WriteAttributeValue("", 568, meni.Katalog.Idkatalog, 568, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(592, 77, true);
            WriteLiteral(" />\r\n                    <div class=\"card-title\">\r\n\r\n                        ");
            EndContext();
            BeginContext(670, 18, false);
#line 26 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
                   Write(meni.Katalog.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(688, 66, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"\">\r\n");
            EndContext();
#line 29 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
                         foreach (Proizvod pr in meni.Proizvod)
                        {

#line default
#line hidden
            BeginContext(846, 48, true);
            WriteLiteral("                            <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("accept", " accept=\"", 894, "\"", 918, 1);
#line 31 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
WriteAttributeValue("", 903, pr.Idproizvoda, 903, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(919, 75, true);
            WriteLiteral(" />\r\n                            <div>\r\n                                <p>");
            EndContext();
            BeginContext(995, 8, false);
#line 33 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
                              Write(pr.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(1003, 42, true);
            WriteLiteral("</p>\r\n                            </div>\r\n");
            EndContext();
#line 35 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
                        }

#line default
#line hidden
            BeginContext(1072, 64, true);
            WriteLiteral("                    </div>\r\n                    <div class=\"\">\r\n");
            EndContext();
            BeginContext(1245, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1269, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "290703165ab041e3689479ff3ff67818820ddc058145", async() => {
                BeginContext(1408, 14, true);
                WriteLiteral(" Dodaj u korpu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"
                                                                                                                              WriteLiteral(meni.Katalog.Idkatalog);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1426, 54, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 42 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shop\PredlazemoKatalog.cshtml"

            }

#line default
#line hidden
            BeginContext(1497, 38, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
