#pragma checksum "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fdd93779cc9f5f70ae9db46214d470c6a4dee24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rates_Edit), @"mvc.1.0.view", @"/Views/Rates/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rates/Edit.cshtml", typeof(AspNetCore.Views_Rates_Edit))]
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
#line 1 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
using Open.Sentry.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdd93779cc9f5f70ae9db46214d470c6a4dee24", @"/Views/Rates/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Rates_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Facade.Quantity.RateView>
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    ViewBag.SubTitle = "Exchange Rate";
    ViewBag.Button = "Save";
    Layout = "_EditPartial";

#line default
#line hidden
            BeginContext(208, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(210, 306, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c74eb784f544f09a77adad806b28cb1", async() => {
                BeginContext(216, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(219, 33, false);
#line 12 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
                EndContext();
                BeginContext(252, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(255, 44, false);
#line 13 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.Rate));

#line default
#line hidden
                EndContext();
                BeginContext(299, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(302, 50, false);
#line 14 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.CurrencyID));

#line default
#line hidden
                EndContext();
                BeginContext(352, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(355, 50, false);
#line 15 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.RateTypeID));

#line default
#line hidden
                EndContext();
                BeginContext(405, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(408, 49, false);
#line 16 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(457, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(460, 47, false);
#line 17 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(507, 2, true);
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
            BeginContext(516, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Actions", async() => {
                BeginContext(538, 40, false);
#line 20 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Rates\Edit.cshtml"
            Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Facade.Quantity.RateView> Html { get; private set; }
    }
}
#pragma warning restore 1591
