#pragma checksum "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51e4b925e2041b0f3fddbf918d7fdc943ff0ad89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Countries_Index), @"mvc.1.0.view", @"/Views/Countries/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Countries/Index.cshtml", typeof(AspNetCore.Views_Countries_Index))]
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
#line 1 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
using Open.Sentry.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51e4b925e2041b0f3fddbf918d7fdc943ff0ad89", @"/Views/Countries/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Countries_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Core.IPaginatedList<Open.Facade.Party.CountryView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
  
    ViewBag.Title = "Countries";
    Layout = "_IndexPartial";

#line default
#line hidden
            BeginContext(167, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Create", async() => {
                BeginContext(186, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(192, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df703c1adac54e6499c07e61065a0a47", async() => {
                    BeginContext(213, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
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
                EndContext();
                BeginContext(227, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(232, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(234, 1272, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe0989e4a52342d682a878513656d1c2", async() => {
                BeginContext(240, 29, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n");
                EndContext();
#line 14 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
           var dummy = Model.FirstOrDefault();

#line default
#line hidden
                BeginContext(318, 51, true);
                WriteLiteral("        <thead>\r\n            <tr>\r\n                ");
                EndContext();
                BeginContext(370, 75, false);
#line 17 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortAlpha3"], model => dummy.Alpha3Code));

#line default
#line hidden
                EndContext();
                BeginContext(445, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(464, 75, false);
#line 18 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortAlpha2"], model => dummy.Alpha2Code));

#line default
#line hidden
                EndContext();
                BeginContext(539, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(558, 67, false);
#line 19 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortName"], model => dummy.Name));

#line default
#line hidden
                EndContext();
                BeginContext(625, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(644, 77, false);
#line 20 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortValidFrom"], model => dummy.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(721, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(740, 75, false);
#line 21 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortValidFrom"], model => dummy.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(815, 83, true);
                WriteLiteral("\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 26 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(955, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1002, 45, false);
#line 29 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Alpha3Code));

#line default
#line hidden
                EndContext();
                BeginContext(1047, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1079, 45, false);
#line 30 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Alpha2Code));

#line default
#line hidden
                EndContext();
                BeginContext(1124, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1156, 39, false);
#line 31 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1195, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1227, 44, false);
#line 32 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(1271, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1303, 42, false);
#line 33 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(1345, 27, true);
                WriteLiteral("</td>\r\n                    ");
                EndContext();
                BeginContext(1373, 54, false);
#line 34 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
               Write(Html.EditDetailDeleteFor(modelItem => item.Alpha3Code));

#line default
#line hidden
                EndContext();
                BeginContext(1427, 25, true);
                WriteLiteral("\r\n                </tr>\r\n");
                EndContext();
#line 36 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Countries\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1467, 32, true);
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            BeginContext(1506, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Core.IPaginatedList<Open.Facade.Party.CountryView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
