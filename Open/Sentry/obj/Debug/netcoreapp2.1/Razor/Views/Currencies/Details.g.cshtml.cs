#pragma checksum "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "388d9fcc8f8332ea2b627f156b8b122a99f6eb37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currencies_Details), @"mvc.1.0.view", @"/Views/Currencies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Currencies/Details.cshtml", typeof(AspNetCore.Views_Currencies_Details))]
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
#line 1 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
using Open.Sentry.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388d9fcc8f8332ea2b627f156b8b122a99f6eb37", @"/Views/Currencies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Currencies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Facade.Quantity.CurrencyView>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
  
    ViewBag.Title = "Details";
    ViewBag.SubTitle = "Currency";
    Layout = "_DetailsPartial";

#line default
#line hidden
            BeginContext(183, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(185, 1221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad8f1c4ea68449f7ae5fc95daeed477c", async() => {
                BeginContext(191, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(198, 47, false);
#line 11 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
Write(Html.ViewingControlsFor(model => model.IsoCode));

#line default
#line hidden
                EndContext();
                BeginContext(245, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(252, 46, false);
#line 12 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
Write(Html.ViewingControlsFor(model => model.Symbol));

#line default
#line hidden
                EndContext();
                BeginContext(298, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(305, 44, false);
#line 13 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
Write(Html.ViewingControlsFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(349, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(356, 49, false);
#line 14 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
Write(Html.ViewingControlsFor(model => model.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(405, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(412, 47, false);
#line 15 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
Write(Html.ViewingControlsFor(model => model.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(459, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
     if (Model.UsedInCountries.Count > 0) {

#line default
#line hidden
                BeginContext(506, 26, true);
                WriteLiteral("        <p/>\r\n        <h4>");
                EndContext();
                BeginContext(533, 51, false);
#line 18 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UsedInCountries));

#line default
#line hidden
                EndContext();
                BeginContext(584, 52, true);
                WriteLiteral("</h4>\r\n        <p/>\r\n        <table class=\"table\">\r\n");
                EndContext();
#line 21 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
               var dummy = Model.UsedInCountries.FirstOrDefault(); 

#line default
#line hidden
                BeginContext(706, 59, true);
                WriteLiteral("            <thead>\r\n            <tr>\r\n                <th>");
                EndContext();
                BeginContext(766, 34, false);
#line 24 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
               Write(Html.LabelFor(model => dummy.Name));

#line default
#line hidden
                EndContext();
                BeginContext(800, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(828, 40, false);
#line 25 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
               Write(Html.LabelFor(model => dummy.Alpha3Code));

#line default
#line hidden
                EndContext();
                BeginContext(868, 27, true);
                WriteLiteral("</th>\r\n                <th>");
                EndContext();
                BeginContext(896, 40, false);
#line 26 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
               Write(Html.LabelFor(model => dummy.Alpha2Code));

#line default
#line hidden
                EndContext();
                BeginContext(936, 69, true);
                WriteLiteral("</th>\r\n            </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 30 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
             foreach (var item in Model.UsedInCountries) {

#line default
#line hidden
                BeginContext(1065, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1112, 39, false);
#line 32 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1151, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1183, 45, false);
#line 33 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Alpha3Code));

#line default
#line hidden
                EndContext();
                BeginContext(1228, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1260, 45, false);
#line 34 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Alpha2Code));

#line default
#line hidden
                EndContext();
                BeginContext(1305, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 36 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
            }

#line default
#line hidden
                BeginContext(1350, 40, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n");
                EndContext();
#line 39 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
    }

#line default
#line hidden
                BeginContext(1397, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1406, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Actions", async() => {
                BeginContext(1427, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1434, 57, false);
#line 44 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new {id = Model.IsoCode}));

#line default
#line hidden
                EndContext();
                BeginContext(1491, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1498, 40, false);
#line 45 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Currencies\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(1538, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(1543, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Facade.Quantity.CurrencyView> Html { get; private set; }
    }
}
#pragma warning restore 1591
