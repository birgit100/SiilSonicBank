#pragma checksum "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "427e4cd756b16212ea55baf79236028c8e6fddaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Currencies_Create), @"mvc.1.0.view", @"/Views/Currencies/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Currencies/Create.cshtml", typeof(AspNetCore.Views_Currencies_Create))]
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
#line 1 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
using Open.Sentry.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"427e4cd756b16212ea55baf79236028c8e6fddaf", @"/Views/Currencies/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Currencies_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Facade.Quantity.CurrencyView>
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
#line 4 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
  
    ViewBag.Title = "Create";
    ViewBag.SubTitle = "Currency";
    ViewBag.Button = "Create";
    Layout = "_EditPartial";

#line default
#line hidden
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 263, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38958bb3cb044da0aa3ca352393a31b3", async() => {
                BeginContext(219, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(222, 47, false);
#line 12 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
Write(Html.EditingControlsFor(model => model.IsoCode));

#line default
#line hidden
                EndContext();
                BeginContext(269, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(272, 46, false);
#line 13 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
Write(Html.EditingControlsFor(model => model.Symbol));

#line default
#line hidden
                EndContext();
                BeginContext(318, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(321, 44, false);
#line 14 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
Write(Html.EditingControlsFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(365, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(368, 49, false);
#line 15 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
Write(Html.EditingControlsFor(model => model.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(417, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(420, 47, false);
#line 16 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
Write(Html.EditingControlsFor(model => model.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(467, 2, true);
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
            BeginContext(476, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Actions", async() => {
                BeginContext(497, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(504, 40, false);
#line 20 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Currencies\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(544, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(549, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Facade.Quantity.CurrencyView> Html { get; private set; }
    }
}
#pragma warning restore 1591
