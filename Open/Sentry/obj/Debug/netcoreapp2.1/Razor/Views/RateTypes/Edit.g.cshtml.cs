#pragma checksum "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "670cb29c011a6c24fae3f3df0fc9578184a1f157"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RateTypes_Edit), @"mvc.1.0.view", @"/Views/RateTypes/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RateTypes/Edit.cshtml", typeof(AspNetCore.Views_RateTypes_Edit))]
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
#line 1 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
using Open.Sentry.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"670cb29c011a6c24fae3f3df0fc9578184a1f157", @"/Views/RateTypes/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_RateTypes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Facade.Quantity.RateTypeView>
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
#line 4 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
  
    ViewBag.Title = "Edit";
    ViewBag.SubTitle = $"Exchange Rate Type ({Model.ID})";
    ViewBag.Button = "Save";
    Layout = "_EditPartial";

#line default
#line hidden
            BeginContext(231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(233, 321, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4f4cddc362ad425eb79dc65b7fa8962f", async() => {
                BeginContext(239, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(246, 33, false);
#line 12 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
                EndContext();
                BeginContext(279, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(286, 44, false);
#line 13 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.Code));

#line default
#line hidden
                EndContext();
                BeginContext(330, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(337, 44, false);
#line 14 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(381, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(384, 51, false);
#line 15 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(435, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(442, 49, false);
#line 16 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.ValidFrom));

#line default
#line hidden
                EndContext();
                BeginContext(491, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(498, 47, false);
#line 17 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
Write(Html.EditingControlsFor(model => model.ValidTo));

#line default
#line hidden
                EndContext();
                BeginContext(545, 2, true);
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
            BeginContext(554, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Actions", async() => {
                BeginContext(576, 40, false);
#line 20 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\RateTypes\Edit.cshtml"
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
