#pragma checksum "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805be125eec981e3a51ae7f7d638131086caef7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__KreirajMeniPoIzboru), @"mvc.1.0.view", @"/Views/Shared/_KreirajMeniPoIzboru.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_KreirajMeniPoIzboru.cshtml", typeof(AspNetCore.Views_Shared__KreirajMeniPoIzboru))]
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
#line 3 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 5 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 6 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805be125eec981e3a51ae7f7d638131086caef7d", @"/Views/Shared/_KreirajMeniPoIzboru.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__KreirajMeniPoIzboru : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<WebApplication5.Models.Proizvod>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-link card-link fa fa-shopping-bag"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(232, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 9 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
  
    //podaci
    var meni1 = Context.Session.GetString("MENI") ?? null;
    KatalogSaProizvodima meni;
    if (meni1 != null)
    {
        meni = JsonConvert.DeserializeObject<KatalogSaProizvodima>(meni1);
    }

#line default
#line hidden
            BeginContext(463, 33, true);
            WriteLiteral("\r\n    <div class=\"card-deck\">\r\n\r\n");
            EndContext();
#line 21 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
            BeginContext(547, 180, true);
            WriteLiteral("            <div class=\"flex-sm-row\">\r\n                <div class=\"flex-fill\">\r\n                    <div class=\"card bg-white flex\">\r\n\r\n                        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("accept", " accept=\"", 727, "\"", 784, 1);
#line 28 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
WriteAttributeValue(" ", 736, Html.DisplayFor(modelItem => item.Idproizvoda), 737, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(785, 106, true);
            WriteLiteral(" />\r\n                        <div class=\"card-header\">\r\n                            <p class=\"card-title\">");
            EndContext();
            BeginContext(892, 40, false);
#line 30 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Naziv));

#line default
#line hidden
            EndContext();
            BeginContext(932, 125, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <figure>\r\n                            <img alt=\"Slika\" class=\"\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1057, "\"", 1083, 1);
#line 33 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
WriteAttributeValue("", 1063, item.PutanjaDoSlike, 1063, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1084, 130, true);
            WriteLiteral(" />\r\n                        </figure>\r\n                        <div class=\"card-subtitle\">\r\n                            <p>Opis: ");
            EndContext();
            BeginContext(1215, 39, false);
#line 36 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
                                Write(Html.DisplayFor(modelItem => item.Opis));

#line default
#line hidden
            EndContext();
            BeginContext(1254, 188, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"card-columns\">\r\n                            <div class=\"card-footer\">\r\n\r\n                                <p>Cena: ");
            EndContext();
            BeginContext(1443, 46, false);
#line 41 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.CenaPorcije));

#line default
#line hidden
            EndContext();
            BeginContext(1489, 148, true);
            WriteLiteral(" </p>\r\n\r\n\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n\r\n                                <p>Gramaža: ");
            EndContext();
            BeginContext(1638, 42, false);
#line 47 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Gramaza));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 101, true);
            WriteLiteral("</p>\r\n\r\n\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n");
            EndContext();
            BeginContext(1898, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1930, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "805be125eec981e3a51ae7f7d638131086caef7d9663", async() => {
                BeginContext(2069, 14, true);
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
#line 53 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
                                                                                                                                            WriteLiteral(item.Idproizvoda);

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
            BeginContext(2087, 144, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 60 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
        }

#line default
#line hidden
            BeginContext(2242, 102, true);
            WriteLiteral("        <br />\r\n    </div>\r\n    <div class=\"footer\">\r\n        <div class=\"pagination\">\r\n\r\n            ");
            EndContext();
            BeginContext(2345, 416, false);
#line 66 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Shared\_KreirajMeniPoIzboru.cshtml"
       Write(Html.PagedListPager(Model, page => Url.Action("KreirajMeniPoIzboru", "Shop", new { page = page }), new X.PagedList.Mvc.Common.PagedListRenderOptions
                {
              DisplayItemSliceAndTotal = false,
              ContainerDivClasses = new[] {"navigation" },
              LiElementClasses = new[] { "page-item"},
              PageClasses = new[] { "page-link"}
                }
            ));

#line default
#line hidden
            EndContext();
            BeginContext(2761, 32, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<WebApplication5.Models.Proizvod>> Html { get; private set; }
    }
}
#pragma warning restore 1591