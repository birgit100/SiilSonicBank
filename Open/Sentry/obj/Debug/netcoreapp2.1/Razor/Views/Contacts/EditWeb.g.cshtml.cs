#pragma checksum "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\EditWeb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "248886559fa1f0d5cbff5ce748f6d331c43f8970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_EditWeb), @"mvc.1.0.view", @"/Views/Contacts/EditWeb.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/EditWeb.cshtml", typeof(AspNetCore.Views_Contacts_EditWeb))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"248886559fa1f0d5cbff5ce748f6d331c43f8970", @"/Views/Contacts/EditWeb.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_EditWeb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Facade.Party.WebPageAddressView>
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
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\EditWeb.cshtml"
  
    ViewBag.Title = "Edit";
    ViewBag.SubTitle = $"{Model.AddressType} Address";
    ViewBag.Button = "Save";
    Layout = "_EditPartial";

#line default
#line hidden
            BeginContext(199, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(201, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5181beb9fe745808825dd0317d28c23", async() => {
                BeginContext(207, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(210, 42, false);
#line 11 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\EditWeb.cshtml"
Write(await Html.PartialAsync("_EditWeb", Model));

#line default
#line hidden
                EndContext();
                BeginContext(252, 2, true);
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
            BeginContext(261, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Actions", async() => {
                BeginContext(282, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(289, 40, false);
#line 15 "C:\Users\marti\Source\Repos\birgit100\SiilSonicBank\Open\Sentry\Views\Contacts\EditWeb.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(329, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(334, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Facade.Party.WebPageAddressView> Html { get; private set; }
    }
}
#pragma warning restore 1591
