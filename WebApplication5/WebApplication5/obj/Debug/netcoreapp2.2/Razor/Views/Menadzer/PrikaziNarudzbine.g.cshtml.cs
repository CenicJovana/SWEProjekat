#pragma checksum "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99187930ded5bdc5e3ecaa7afbca7e3179f4e885"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menadzer_PrikaziNarudzbine), @"mvc.1.0.view", @"/Views/Menadzer/PrikaziNarudzbine.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menadzer/PrikaziNarudzbine.cshtml", typeof(AspNetCore.Views_Menadzer_PrikaziNarudzbine))]
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
#line 1 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99187930ded5bdc5e3ecaa7afbca7e3179f4e885", @"/Views/Menadzer/PrikaziNarudzbine.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Menadzer_PrikaziNarudzbine : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<WebApplication5.Models.KorisnikNarudzbine>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menadzer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PotvrdiNarudzbinu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OdbaciNarudzbinu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
  
    ViewData["Title"] = "Prikazi narudzbine";

#line default
#line hidden
            BeginContext(158, 397, true);
            WriteLiteral(@"
<h1>Prikazi narudzbine</h1>


<div class=""korpa-main-bg"">

    <table class=""table"">
        <thead>
            <tr>
                <th>Datum narucivanja</th>
                <th>DatumIsporuke</th>
                <th>AdresaIsporuke</th>
                <th>ID Kataloga</th>
                <th>Naziv kataloga/menija</th>


            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 25 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#line 27 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                 foreach (KorisnikNarudzbine nar in Model)
                {

#line default
#line hidden
            BeginContext(682, 56, true);
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
            EndContext();
            BeginContext(739, 31, false);
#line 31 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                       Write(nar.Narudzbina.DatumNarucivanja);

#line default
#line hidden
            EndContext();
            BeginContext(770, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(806, 28, false);
#line 32 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                       Write(nar.Narudzbina.DatumIsporuke);

#line default
#line hidden
            EndContext();
            BeginContext(834, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(870, 29, false);
#line 33 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                       Write(nar.Narudzbina.AdresaIsporuke);

#line default
#line hidden
            EndContext();
            BeginContext(899, 104, true);
            WriteLiteral("</td>\r\n                        <td></td>\r\n                        <td></td>\r\n                    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                     foreach (Katalog k in nar.Items)
                    {

#line default
#line hidden
            BeginContext(1081, 179, true);
            WriteLiteral("                        <tr>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td>");
            EndContext();
            BeginContext(1261, 11, false);
#line 43 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                           Write(k.Idkatalog);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 40, true);
            WriteLiteral("</td>\r\n                            <td> ");
            EndContext();
            BeginContext(1313, 7, false);
#line 44 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                            Write(k.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(1320, 39, true);
            WriteLiteral(" </td>\r\n                        </tr>\r\n");
            EndContext();
#line 46 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                    }

#line default
#line hidden
            BeginContext(1382, 68, true);
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">  ");
            EndContext();
            BeginContext(1450, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99187930ded5bdc5e3ecaa7afbca7e3179f4e8859526", async() => {
                BeginContext(1590, 18, true);
                WriteLiteral("Potvrdi narudzbinu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                                                                                                                                            WriteLiteral(nar.Narudzbina.Idnarudzbine);

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
            BeginContext(1612, 49, true);
            WriteLiteral(" </td>\r\n                        <td colspan=\"3\"> ");
            EndContext();
            BeginContext(1661, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99187930ded5bdc5e3ecaa7afbca7e3179f4e88512541", async() => {
                BeginContext(1799, 17, true);
                WriteLiteral("Odbaci narudzbinu");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                                                                                                                                         WriteLiteral(nar.Narudzbina.Idnarudzbine);

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
            BeginContext(1820, 36, true);
            WriteLiteral("  </td>\r\n                    </tr>\r\n");
            EndContext();
#line 51 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                }

#line default
#line hidden
#line 51 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(1923, 281, true);
            WriteLiteral(@"                <tr>
                    <td colspan=""5"">
                        <p class=""alert-danger mojText1"">
                            Korpa je prazna. Nemate dodati meni/katalog u korpu.
                        </p>
                    </td>
                </tr>
");
            EndContext();
#line 62 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
            }

#line default
#line hidden
            BeginContext(2219, 106, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n</div>\r\n<div class=\"footer\">\r\n    <div class=\"pagination\">\r\n\r\n        ");
            EndContext();
            BeginContext(2326, 388, false);
#line 71 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\Menadzer\PrikaziNarudzbine.cshtml"
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
            BeginContext(2714, 24, true);
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<WebApplication5.Models.KorisnikNarudzbine>> Html { get; private set; }
    }
}
#pragma warning restore 1591
