#pragma checksum "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bdb325cb7ba6dd0b7c384995f2afa7149fe290b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RateTypes_Create), @"mvc.1.0.view", @"/Views/RateTypes/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RateTypes/Create.cshtml", typeof(AspNetCore.Views_RateTypes_Create))]
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
#line 1 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
using Open.Sentry.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bdb325cb7ba6dd0b7c384995f2afa7149fe290b", @"/Views/RateTypes/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_RateTypes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Facade.Quantity.RateTypeView>
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
#line 4 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
  
    ViewBag.Title = "Create";
    ViewBag.SubTitle = "Exchange Rate Type";
    ViewBag.Button = "Create";
    Layout = "_EditPartial";

#line default
#line hidden
            BeginContext(221, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(223, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b521120dd4a461c9a7ebd7409853c53", async() => {
                BeginContext(229, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(236, 34, false);
#line 12 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
Write(Html.EditingControlsFor(x => x.ID));

#line default
#line hidden
                EndContext();
                BeginContext(270, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(277, 36, false);
#line 13 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
Write(Html.EditingControlsFor(x => x.Code));

#line default
#line hidden
                EndContext();
                BeginContext(313, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(320, 36, false);
#line 14 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
Write(Html.EditingControlsFor(x => x.Name));

#line default
#line hidden
                EndContext();
                BeginContext(356, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(363, 43, false);
#line 15 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
Write(Html.EditingControlsFor(x => x.Description));

#line default
#line hidden
                EndContext();
                BeginContext(406, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(413, 41, false);
#line 16 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
Write(Html.EditingControlsFor(x => x.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(454, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(461, 39, false);
#line 17 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
Write(Html.EditingControlsFor(x => x.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(500, 2, true);
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
            BeginContext(509, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Actions", async() => {
                BeginContext(531, 40, false);
#line 20 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\RateTypes\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Facade.Quantity.RateTypeView> Html { get; private set; }
    }
}
#pragma warning restore 1591
