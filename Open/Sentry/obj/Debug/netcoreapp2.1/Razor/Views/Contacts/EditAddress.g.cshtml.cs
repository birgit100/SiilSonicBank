#pragma checksum "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84daa1a0d132fa185dce87283e8ad31b878266b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contacts_EditAddress), @"mvc.1.0.view", @"/Views/Contacts/EditAddress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contacts/EditAddress.cshtml", typeof(AspNetCore.Views_Contacts_EditAddress))]
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
#line 1 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
using Open.Facade.Party;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84daa1a0d132fa185dce87283e8ad31b878266b0", @"/Views/Contacts/EditAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59898f1f519a9ae9f6b6759299108b34acce5888", @"/Views/_ViewImports.cshtml")]
    public class Views_Contacts_EditAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Open.Facade.Party.GeographicAddressView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
  
    ViewBag.Title = "Edit";
    ViewBag.SubTitle = $"{Model.AddressType} Address";
    ViewBag.Button = "Save";
    Layout = "_EditPartial";
    var devices = ViewBag.Devices as AddressViewsList ?? new AddressViewsList(null);
    var prevDisabled = !devices.HasPreviousPage ? "disabled" : "";
    var nextDisabled = !devices.HasNextPage ? "disabled" : "";

#line default
#line hidden
            BeginContext(446, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(448, 2330, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8c1de17c13f4bac806050402d830291", async() => {
                BeginContext(454, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(461, 46, false);
#line 15 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
Write(await Html.PartialAsync("_EditAddress", Model));

#line default
#line hidden
                EndContext();
                BeginContext(507, 42, true);
                WriteLiteral("\r\n\r\n    <div class=\"form-group\">\r\n        ");
                EndContext();
                BeginContext(550, 91, false);
#line 18 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
   Write(Html.LabelFor(m => m.RegisteredTelecomAddresses, new { @class = "control-label col-md-2" }));

#line default
#line hidden
                EndContext();
                BeginContext(641, 95, true);
                WriteLiteral(",\r\n        <div class=\"col-md-4\" style=\"margin-top: 10px\">\r\n            <table class=\"table\">\r\n");
                EndContext();
#line 21 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                   var r = Model.RegisteredTelecomAddresses.FirstOrDefault(); 

#line default
#line hidden
                BeginContext(817, 79, true);
                WriteLiteral("                <thead>\r\n                    <tr>\r\n                        <th>");
                EndContext();
                BeginContext(897, 29, false);
#line 24 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                       Write(Html.LabelFor(x => r.Contact));

#line default
#line hidden
                EndContext();
                BeginContext(926, 120, true);
                WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
                EndContext();
#line 29 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                     foreach (var item in Model.RegisteredTelecomAddresses)
                    {

#line default
#line hidden
                BeginContext(1146, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1209, 34, false);
#line 32 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                           Write(Html.DisplayFor(x => item.Contact));

#line default
#line hidden
                EndContext();
                BeginContext(1243, 39, true);
                WriteLiteral("</td>\r\n                            <td>");
                EndContext();
                BeginContext(1283, 80, false);
#line 33 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                           Write(Html.ActionLink("Remove", "RemoveDevice", new { adr = Model.ID, dev = item.ID }));

#line default
#line hidden
                EndContext();
                BeginContext(1363, 38, true);
                WriteLiteral("</td>\r\n                        </tr>\r\n");
                EndContext();
#line 35 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                    }

#line default
#line hidden
                BeginContext(1424, 132, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n            <div class=\"form-horizontal\">\r\n                <p>\r\n                    ");
                EndContext();
                BeginContext(1556, 240, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fab91efcd6174106af275ffee1c59831", async() => {
                    BeginContext(1789, 3, true);
                    WriteLiteral(" < ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 41 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                            WriteLiteral(devices.PageIndex - 1);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 42 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                                    WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1758, "btn", 1758, 3, true);
                AddHtmlAttributeValue(" ", 1761, "btn-default", 1762, 12, true);
#line 43 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
AddHtmlAttributeValue(" ", 1773, prevDisabled, 1774, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1796, 60, true);
                WriteLiteral("\r\n                    <input type=\"text\" name=\"SearchString\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1856, "\"", 1890, 1);
#line 44 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
WriteAttributeValue("", 1864, ViewData["CurrentFilter"], 1864, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1891, 141, true);
                WriteLiteral(" formmethod=\"get\" />\r\n                    <input type=\"submit\" value=\"Find\" class=\"btn btn-default\" formmethod=\"get\" />\r\n                    ");
                EndContext();
                BeginContext(2032, 240, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90f72d91f4014c5396f6221677c6435c", async() => {
                    BeginContext(2265, 3, true);
                    WriteLiteral(" > ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 47 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                            WriteLiteral(devices.PageIndex + 1);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 48 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                                    WriteLiteral(ViewData["CurrentFilter"]);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentFilter", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentFilter"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2234, "btn", 2234, 3, true);
                AddHtmlAttributeValue(" ", 2237, "btn-default", 2238, 12, true);
#line 49 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
AddHtmlAttributeValue(" ", 2249, nextDisabled, 2250, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2272, 104, true);
                WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <table class=\"table\">\r\n                <tbody>\r\n");
                EndContext();
#line 54 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                 foreach (var item in devices)
                {

#line default
#line hidden
                BeginContext(2443, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(2498, 34, false);
#line 57 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                       Write(Html.DisplayFor(x => item.Contact));

#line default
#line hidden
                EndContext();
                BeginContext(2532, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(2568, 74, false);
#line 58 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                       Write(Html.ActionLink("Add", "AddDevice", new { adr = Model.ID, dev = item.ID }));

#line default
#line hidden
                EndContext();
                BeginContext(2642, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 60 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
                }

#line default
#line hidden
                BeginContext(2695, 76, true);
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(2778, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Actions", async() => {
                BeginContext(2799, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2806, 40, false);
#line 68 "D:\Documents\Rider\Source\SiilSonicBank\Open\Sentry\Views\Contacts\EditAddress.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
                EndContext();
                BeginContext(2846, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(2851, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Open.Facade.Party.GeographicAddressView> Html { get; private set; }
    }
}
#pragma warning restore 1591
