#pragma checksum "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b794a5a483c6d4eab753c2e116ef3d79e5d6547e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour__ReviewPagePartial), @"mvc.1.0.view", @"/Views/Tour/_ReviewPagePartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tour/_ReviewPagePartial.cshtml", typeof(AspNetCore.Views_Tour__ReviewPagePartial))]
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
#line 1 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web;

#line default
#line hidden
#line 3 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models;

#line default
#line hidden
#line 4 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b794a5a483c6d4eab753c2e116ef3d79e5d6547e", @"/Views/Tour/_ReviewPagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff3c2c691ef0ab1f7a8a2736014cf2edd31c8c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour__ReviewPagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TakeATrip.Services.Models.ReviewModels.ReviewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 219, true);
            WriteLiteral("\r\n<section id=\"reviews\">\r\n    <h2>Reviews</h2>\r\n    <div class=\"reviews-container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3\">\r\n                <div id=\"review_summary\">\r\n                    <strong>");
            EndContext();
            BeginContext(279, 13, false);
#line 9 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                       Write(Model.RateAvg);

#line default
#line hidden
            EndContext();
            BeginContext(292, 84, true);
            WriteLiteral("</strong>\r\n                    <em>Superb</em>\r\n                    <small>Based on ");
            EndContext();
            BeginContext(377, 17, false);
#line 11 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                               Write(Model.TotalReview);

#line default
#line hidden
            EndContext();
            BeginContext(394, 98, true);
            WriteLiteral(" reviews</small>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-9\">\r\n");
            EndContext();
#line 15 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                 foreach (var item in Model.Rate)
                {

#line default
#line hidden
            BeginContext(562, 222, true);
            WriteLiteral("                    <div class=\"row\">\r\n                        <div class=\"col-lg-10 col-9\">\r\n                            <div class=\"progress\">\r\n                                <div class=\"progress-bar\" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 784, "\"", 813, 3);
            WriteAttributeValue("", 792, "width:", 792, 6, true);
#line 20 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
WriteAttributeValue(" ", 798, item.Percent, 799, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 812, "%", 812, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 814, "\"", 843, 1);
#line 20 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
WriteAttributeValue("", 830, item.Percent, 830, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(844, 182, true);
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-lg-2 col-3\"><small><strong>");
            EndContext();
            BeginContext(1027, 9, false);
#line 23 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                                                              Write(item.star);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 59, true);
            WriteLiteral(" stars</strong></small></div>\r\n                    </div>\r\n");
            EndContext();
#line 25 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1114, 120, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!-- /row -->\r\n    </div>\r\n    <hr>\r\n    <div class=\"reviews-container\">\r\n");
            EndContext();
#line 33 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
         foreach (var item in Model.Review)
        {

#line default
#line hidden
            BeginContext(1290, 286, true);
            WriteLiteral(@"            <div class=""review-box clearfix"">
                <figure class=""rev-thumb"">
                    <img src=""/img/avatar1.jpg"" alt="""">
                </figure>
                <div class=""rev-content"">
                    <div class=""rating"">
                        <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1576, "\"", 1629, 2);
            WriteAttributeValue("", 1584, "icon_star", 1584, 9, true);
#line 41 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
WriteAttributeValue(" ", 1593,  item.Rates >= 1 ? "voted" : "" , 1594, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1630, 7, true);
            WriteLiteral("></i><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1637, "\"", 1690, 2);
            WriteAttributeValue("", 1645, "icon_star", 1645, 9, true);
#line 41 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
WriteAttributeValue(" ", 1654,  item.Rates >= 2 ? "voted" : "" , 1655, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1691, 7, true);
            WriteLiteral("></i><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1698, "\"", 1751, 2);
            WriteAttributeValue("", 1706, "icon_star", 1706, 9, true);
#line 41 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
WriteAttributeValue(" ", 1715,  item.Rates >= 3 ? "voted" : "" , 1716, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1752, 7, true);
            WriteLiteral("></i><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1759, "\"", 1812, 2);
            WriteAttributeValue("", 1767, "icon_star", 1767, 9, true);
#line 41 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
WriteAttributeValue(" ", 1776,  item.Rates >= 4 ? "voted" : "" , 1777, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1813, 7, true);
            WriteLiteral("></i><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1820, "\"", 1872, 2);
            WriteAttributeValue("", 1828, "icon_star", 1828, 9, true);
#line 41 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
WriteAttributeValue(" ", 1837,  item.Rates >=5 ? "voted" : "" , 1838, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1873, 103, true);
            WriteLiteral("></i>\r\n                    </div>\r\n                    <div class=\"rev-info\">\r\n                        ");
            EndContext();
            BeginContext(1977, 13, false);
#line 44 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                   Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1990, 2, true);
            WriteLiteral(" –");
            EndContext();
            BeginContext(1993, 16, false);
#line 44 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                                   Write(item.CreatedDate);

#line default
#line hidden
            EndContext();
            BeginContext(2009, 132, true);
            WriteLiteral(":\r\n                    </div>\r\n                    <div class=\"rev-text\">\r\n                        <p>\r\n                            ");
            EndContext();
            BeginContext(2142, 12, false);
#line 48 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
                       Write(item.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(2154, 104, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 53 "G:\Freelancer\takeatrip\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\_ReviewPagePartial.cshtml"
        }

#line default
#line hidden
            BeginContext(2269, 54, true);
            WriteLiteral("    </div>\r\n    <!-- /review-container -->\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TakeATrip.Services.Models.ReviewModels.ReviewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
