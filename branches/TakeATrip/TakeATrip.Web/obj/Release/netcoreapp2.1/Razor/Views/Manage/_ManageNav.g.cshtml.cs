#pragma checksum "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc16f52b0f5122bfe5aaab6a9f4c340f976b9b94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage__ManageNav), @"mvc.1.0.view", @"/Views/Manage/_ManageNav.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manage/_ManageNav.cshtml", typeof(AspNetCore.Views_Manage__ManageNav))]
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
#line 1 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web;

#line default
#line hidden
#line 3 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models;

#line default
#line hidden
#line 4 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models.ManageViewModels;

#line default
#line hidden
#line 1 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
using TakeATrip.Web.Views.Manage;

#line default
#line hidden
#line 2 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
using TakeATrip.Entities.IdentityDB;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc16f52b0f5122bfe5aaab6a9f4c340f976b9b94", @"/Views/Manage/_ManageNav.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff3c2c691ef0ab1f7a8a2736014cf2edd31c8c4", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd844d52ec39e294dd0cdc0340a696b30f9bbf1d", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage__ManageNav : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExternalLogins", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TwoFactorAuthentication", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
  
    var hasExternalLogins = (await SignInManager.GetExternalAuthenticationSchemesAsync()).Any();

#line default
#line hidden
            BeginContext(232, 49, true);
            WriteLiteral("\r\n<ul class=\"nav nav-pills nav-stacked\">\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 281, "\"", 331, 1);
#line 9 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 289, ManageNavPages.IndexNavClass(ViewContext), 289, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(332, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(333, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1383b9928c614ff79b7098ee86506484", async() => {
                BeginContext(355, 7, true);
                WriteLiteral("Profile");
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
            BeginContext(366, 14, true);
            WriteLiteral("</li>\r\n    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 380, "\"", 439, 1);
#line 10 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 388, ManageNavPages.ChangePasswordNavClass(ViewContext), 388, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(440, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(441, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9936c25cdbe1400c819c8a41e2e23bca", async() => {
                BeginContext(472, 8, true);
                WriteLiteral("Password");
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
            BeginContext(484, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
     if (hasExternalLogins)
    {

#line default
#line hidden
            BeginContext(527, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 538, "\"", 597, 1);
#line 13 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 546, ManageNavPages.ExternalLoginsNavClass(ViewContext), 546, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(598, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(599, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f426d82d7e5349ecad8e50c738eb09f9", async() => {
                BeginContext(630, 15, true);
                WriteLiteral("External logins");
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
            BeginContext(649, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 14 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
    }

#line default
#line hidden
            BeginContext(663, 7, true);
            WriteLiteral("    <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 670, "\"", 738, 1);
#line 15 "D:\OneDrive - CONASI JSC\PhuGiaSC\SoftwareDeployments\TakeATrip\branches\TakeATrip\TakeATrip.Web\Views\Manage\_ManageNav.cshtml"
WriteAttributeValue("", 678, ManageNavPages.TwoFactorAuthenticationNavClass(ViewContext), 678, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(739, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(740, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51843edab35148cc9e3a733b4b6d4897", async() => {
                BeginContext(780, 25, true);
                WriteLiteral("Two-factor authentication");
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
            BeginContext(809, 16, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
