#pragma checksum "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3c3426677de607f78276ff589dd4cb0a88ee6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MojProfil), @"mvc.1.0.view", @"/Views/User/MojProfil.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/MojProfil.cshtml", typeof(AspNetCore.Views_User_MojProfil))]
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
#line 1 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3c3426677de607f78276ff589dd4cb0a88ee6c", @"/Views/User/MojProfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac7a6a20369a094c1643b76f0e92e19ec3cef6a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MojProfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication5.Models.MojProfil>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn promeni-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menadzer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrikaziNarudzbine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DodajMenadzera", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IzmeniInf", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VratiPrihvacene", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MojProfil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VratiPorucene", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KreirajMeniPoIzboru", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(104, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
  
    ViewData["Title"] = "Moj profil";
    string username = (Context.Session.GetString("Username") != null) ? Context.Session.GetString("Username") : "";
    int broj = ViewBag.Profil;

#line default
#line hidden
            BeginContext(301, 22, true);
            WriteLiteral("\r\n<h1>MojProfil</h1>\r\n");
            EndContext();
#line 14 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
  
    var json = Context.Session.GetString("User") != null ? Context.Session.GetString("User") : null;
    Korisnik user = null;

    if (json != null)
    {
        user = JsonConvert.DeserializeObject<Korisnik>(json);
    }


#line default
#line hidden
            BeginContext(563, 77, true);
            WriteLiteral("\r\n<div class=\"profil-main-container\">\r\n    <div class=\"profil-container\">\r\n\r\n");
            EndContext();
#line 28 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
         if (user != null)
        {
            if (user.Tip.Contains("menadzer"))
            {

#line default
#line hidden
            BeginContext(742, 101, true);
            WriteLiteral("                <dl class=\"row\">\r\n                    <dt class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(843, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3c3426677de607f78276ff589dd4cb0a88ee6c8791", async() => {
                BeginContext(940, 19, true);
                WriteLiteral("Rad sa narudzbinama");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(963, 96, true);
            WriteLiteral("\r\n                    </dt>\r\n                    <dt class=\"col-sm-6\">\r\n                        ");
            EndContext();
            BeginContext(1059, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3c3426677de607f78276ff589dd4cb0a88ee6c10766", async() => {
                BeginContext(1153, 22, true);
                WriteLiteral("Dodaj drugog menadzera");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1179, 52, true);
            WriteLiteral("\r\n                    </dt>\r\n                </dl>\r\n");
            EndContext();
#line 40 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1257, 77, true);
            WriteLiteral("        <dl class=\"row\">\r\n            <dt class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1335, 48, false);
#line 44 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayNameFor(model => model.Korisnik.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1456, 44, false);
#line 47 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayFor(model => model.Korisnik.Ime));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 113, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1614, 52, false);
#line 52 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayNameFor(model => model.Korisnik.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(1666, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1739, 48, false);
#line 55 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayFor(model => model.Korisnik.Prezime));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 148, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-6\">\r\n        </dl>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(1936, 50, false);
#line 61 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayNameFor(model => model.Korisnik.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(2059, 46, false);
#line 64 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayFor(model => model.Korisnik.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2105, 113, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(2219, 53, false);
#line 69 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayNameFor(model => model.Korisnik.Username));

#line default
#line hidden
            EndContext();
            BeginContext(2272, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(2345, 49, false);
#line 72 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayFor(model => model.Korisnik.Username));

#line default
#line hidden
            EndContext();
            BeginContext(2394, 36, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
            EndContext();
            BeginContext(2719, 77, true);
            WriteLiteral("        <dl class=\"row\">\r\n            <dt class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(2797, 57, false);
#line 86 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayNameFor(model => model.Korisnik.BrojTelefona));

#line default
#line hidden
            EndContext();
            BeginContext(2854, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(2927, 53, false);
#line 89 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayFor(model => model.Korisnik.BrojTelefona));

#line default
#line hidden
            EndContext();
            BeginContext(2980, 129, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n        <dl class=\"row\" hidden=\"hidden\">\r\n            <dt class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(3110, 48, false);
#line 94 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayNameFor(model => model.Korisnik.Tip));

#line default
#line hidden
            EndContext();
            BeginContext(3158, 72, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-6\">\r\n                ");
            EndContext();
            BeginContext(3231, 44, false);
#line 97 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
           Write(Html.DisplayFor(model => model.Korisnik.Tip));

#line default
#line hidden
            EndContext();
            BeginContext(3275, 65, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(3340, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3c3426677de607f78276ff589dd4cb0a88ee6c18784", async() => {
                BeginContext(3409, 18, true);
                WriteLiteral("Izmeni informacije");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                                        WriteLiteral(Model.Korisnik.Idkorisnika);

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
            BeginContext(3431, 5, true);
            WriteLiteral("     ");
            EndContext();
            BeginContext(3522, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 105 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
     if (user.Tip.Contains("korisnik"))
    {

#line default
#line hidden
            BeginContext(3600, 19, true);
            WriteLiteral("    <div>\r\n        ");
            EndContext();
            BeginContext(3619, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3c3426677de607f78276ff589dd4cb0a88ee6c21581", async() => {
                BeginContext(3685, 29, true);
                WriteLiteral("Narudzbine koje su prihvacene");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3718, 17, true);
            WriteLiteral(" <br />\r\n        ");
            EndContext();
            BeginContext(3735, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3c3426677de607f78276ff589dd4cb0a88ee6c23400", async() => {
                BeginContext(3795, 35, true);
                WriteLiteral("Narudzbine koje ste kreirali upravo");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3834, 17, true);
            WriteLiteral(" <br />\r\n        ");
            EndContext();
            BeginContext(3851, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3c3426677de607f78276ff589dd4cb0a88ee6c25225", async() => {
                BeginContext(3915, 28, true);
                WriteLiteral("Narudzbine koje ste porucili");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3947, 527, true);
            WriteLiteral(@"
    </div>
    <div class=""bg-white col-7 nar-container"">

        <h1>Vaše narudžbine</h1>



        <table class=""table-nar"">
            <thead class=""thead-nar"">
                <tr class=""tr-nar"">
                    <th>Datum Naručivanja</th>
                    <th>Datum Isporuke</th>
                    <th>Vreme Isporuke</th>
                    <th>Adresa Isporuke</th>
                    <th>Ukupna Cena</th>
                </tr>
            </thead>
            <tbody class=""tbody-nar"">

");
            EndContext();
#line 130 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                 if (Model.Narudzbine.Count > 0)
                {

                    foreach (var item in Model.Narudzbine)
                    {

#line default
#line hidden
            BeginContext(4628, 77, true);
            WriteLiteral("                        <tr class=\"tr-nar\">\r\n                            <td>");
            EndContext();
            BeginContext(4706, 41, false);
#line 136 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                           Write(item.DatumNarucivanja.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(4747, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4787, 38, false);
#line 137 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                           Write(item.DatumIsporuke.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(4825, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4865, 29, false);
#line 138 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                           Write(item.VremeIsporuke.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(4894, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4934, 19, false);
#line 139 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                           Write(item.AdresaIsporuke);

#line default
#line hidden
            EndContext();
            BeginContext(4953, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4993, 15, false);
#line 140 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                           Write(item.UkupnaCena);

#line default
#line hidden
            EndContext();
            BeginContext(5008, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 142 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
                    }


                }

#line default
#line hidden
            BeginContext(5092, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 148 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
         if (Model.Narudzbine.Count == 0)
        {

#line default
#line hidden
            BeginContext(5186, 106, true);
            WriteLiteral("            <p class=\"text-center font-weight-bolder\">Nemate nikakve narudžbine :(</p><br />\r\n            ");
            EndContext();
            BeginContext(5292, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3c3426677de607f78276ff589dd4cb0a88ee6c30750", async() => {
                BeginContext(5362, 80, true);
                WriteLiteral("<p class=\"text-center font-weight-bolder\">Pogledajte neke od naših ponuda :)</p>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5446, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 152 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
        }

#line default
#line hidden
            BeginContext(5459, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 154 "C:\Users\PC2\Desktop\WebApplication5\WebApplication5\Views\User\MojProfil.cshtml"
    }

#line default
#line hidden
            BeginContext(5478, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication5.Models.MojProfil> Html { get; private set; }
    }
}
#pragma warning restore 1591