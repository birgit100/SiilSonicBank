#pragma checksum "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8df5973fa9ea7d6f84c11d4dc74b6f98056865e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DeletePartial), @"mvc.1.0.view", @"/Views/Shared/_DeletePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_DeletePartial.cshtml", typeof(AspNetCore.Views_Shared__DeletePartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8df5973fa9ea7d6f84c11d4dc74b6f98056865e", @"/Views/Shared/_DeletePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DeletePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(41, 13, false);
#line 6 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(54, 98, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n\r\n<div class=\"form-horizontal\">\r\n    <h4>");
            EndContext();
            BeginContext(153, 16, false);
#line 11 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
   Write(ViewBag.SubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(169, 25, true);
            WriteLiteral("</h4>\r\n    <hr />\r\n\r\n    ");
            EndContext();
            BeginContext(195, 12, false);
#line 14 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(207, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(289, 123, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 412, "", 434, 1);
#line 22 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
WriteAttributeValue("", 419, ViewBag.Button, 419, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(434, 92, true);
            WriteLiteral(" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(527, 24, false);
#line 26 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
       Write(RenderSection("Actions"));

#line default
#line hidden
            EndContext();
            BeginContext(551, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 28 "C:\Users\Stella.Leego.HLP030\RiderProjects\SiilSonicBank\Open\Sentry\Views\Shared\_DeletePartial.cshtml"
    }

#line default
#line hidden
            BeginContext(576, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
