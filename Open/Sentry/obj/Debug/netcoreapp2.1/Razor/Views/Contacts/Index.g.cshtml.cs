#pragma checksum "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8f84cf2b7c9a9bdddb95501b23c18745a4b065d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_Index), @"mvc.1.0.view", @"/Views/Contacts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/Index.cshtml", typeof(AspNetCore.Views_Contacts_Index))]
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
#line 1 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
using Open.Sentry.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f84cf2b7c9a9bdddb95501b23c18745a4b065d", @"/Views/Contacts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Core.IPaginatedList<Open.Facade.Party.AddressView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateWeb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTelecom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
  
    ViewBag.Title = "Contacts";
    Layout = "_IndexPartial";

#line default
#line hidden
            DefineSection("Create", async() => {
                BeginContext(183, 30, true);
                WriteLiteral("\r\n    <t>Create new </t>\r\n    ");
                EndContext();
                BeginContext(213, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d08456e654d14021bec6688527577ea1", async() => {
                    BeginContext(237, 3, true);
                    WriteLiteral("Web");
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
                BeginContext(244, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(250, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be50edcde8ab47788cef5149f00f087a", async() => {
                    BeginContext(276, 5, true);
                    WriteLiteral("Email");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(285, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(291, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a9af65011c49bd9983569556ad3ce3", async() => {
                    BeginContext(319, 7, true);
                    WriteLiteral("Telecom");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(330, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(336, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bcc4ec2be9c4ec3a63f01476fd3310c", async() => {
                    BeginContext(357, 7, true);
                    WriteLiteral("Address");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(368, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(373, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(375, 1110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e84826f9089446308414f6b6723016b0", async() => {
                BeginContext(381, 29, true);
                WriteLiteral("\r\n    <table class=\"table\">\r\n");
                EndContext();
#line 17 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
           var dummy = Model.FirstOrDefault();

#line default
#line hidden
                BeginContext(459, 51, true);
                WriteLiteral("        <thead>\r\n            <tr>\r\n                ");
                EndContext();
                BeginContext(511, 81, false);
#line 20 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortAddressType"], model => dummy.AddressType));

#line default
#line hidden
                EndContext();
                BeginContext(592, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(611, 74, false);
#line 21 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortToString"], model => dummy.Contact));

#line default
#line hidden
                EndContext();
                BeginContext(685, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(704, 77, false);
#line 22 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortValidFrom"], model => dummy.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(781, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(800, 75, false);
#line 23 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
           Write(Html.SortColumnHeaderFor(ViewData["SortValidFrom"], model => dummy.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(875, 83, true);
                WriteLiteral("\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 28 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
                BeginContext(1015, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1062, 46, false);
#line 31 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AddressType));

#line default
#line hidden
                EndContext();
                BeginContext(1108, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1140, 42, false);
#line 32 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Contact));

#line default
#line hidden
                EndContext();
                BeginContext(1182, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1214, 44, false);
#line 33 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(1258, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(1290, 42, false);
#line 34 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(1332, 27, true);
                WriteLiteral("</td>\r\n                    ");
                EndContext();
                BeginContext(1360, 46, false);
#line 35 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
               Write(Html.EditDetailDeleteFor(modelItem => item.ID));

#line default
#line hidden
                EndContext();
                BeginContext(1406, 25, true);
                WriteLiteral("\r\n                </tr>\r\n");
                EndContext();
#line 37 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(1446, 32, true);
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
            BeginContext(1485, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Core.IPaginatedList<Open.Facade.Party.AddressView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
