#pragma checksum "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67030482e40c655ac900bf8929dd5f13ff0ab0ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tour_Index), @"mvc.1.0.view", @"/Views/Tour/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tour/Index.cshtml", typeof(AspNetCore.Views_Tour_Index))]
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
#line 1 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web;

#line default
#line hidden
#line 3 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models;

#line default
#line hidden
#line 4 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models.AccountViewModels;

#line default
#line hidden
#line 5 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\_ViewImports.cshtml"
using TakeATrip.Web.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67030482e40c655ac900bf8929dd5f13ff0ab0ad", @"/Views/Tour/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff3c2c691ef0ab1f7a8a2736014cf2edd31c8c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Tour_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TakeATrip.Services.Models.TourModels.TourPage>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("What are you looking for..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Where"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("wide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pagination.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-2.2.4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 1949, true);
            WriteLiteral(@"
<section class=""hero_in tours"">
    <div class=""wrapper"">
        <div class=""container"">
            <h1 class=""fadeInUp""><span></span>Paris tours grid</h1>
        </div>
    </div>
</section>
<!--/hero_in-->

<div class=""filters_listing sticky_horizontal"">
    <div class=""container"">
        <ul class=""clearfix"">
            <li>
                <div class=""switch-field"">
                    <input type=""radio"" id=""all"" name=""listing_filter"" value=""all"" checked onclick=""SortingEvenHandlers($(this))"">
                    <label for=""all"">All</label>
                    <input type=""radio"" id=""popular"" name=""listing_filter"" value=""popular"" onclick=""SortingEvenHandlers($(this))"">
                    <label for=""popular"">Popular</label>
                    <input type=""radio"" id=""latest"" name=""listing_filter"" value=""latest"" onclick=""SortingEvenHandlers($(this))"">
                    <label for=""latest"">Latest</label>
                </div>
            </li>
            <li>
           ");
            WriteLiteral(@"     <div class=""layout_view"">
                    <a href=""#0"" class=""active"" onclick=""ShowTourGrid()""><i class=""icon-th""></i></a>
                    <a href=""#0"" onclick=""ShowTourList()""><i class=""icon-th-list""></i></a>
                </div>
            </li>
            <li>
                <a class=""btn_map"" data-toggle=""collapse"" href=""#collapseMap"" aria-expanded=""false"" aria-controls=""collapseMap"" data-text-swap=""Hide map"" data-text-original=""View on map"">View on map</a>
            </li>
        </ul>
    </div>
    <!-- /container -->
</div>
<!-- /filters -->
<div class=""collapse"" id=""collapseMap"">
    <div id=""map"" class=""map""></div>
</div>
<!-- End Map -->
<div class=""container margin_60_35"">
    <div class=""col-lg-12"">
        <div class=""row no-gutters custom-search-input-2 inner"">
            <div class=""col-lg-4"">
                <div class=""form-group"">
                    ");
            EndContext();
            BeginContext(2047, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e087972b35bf4c2684dc70d8190e21a0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 52 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchText);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2150, 193, true);
            WriteLiteral("\r\n                    <i class=\"icon_search\"></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3\">\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2343, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f65b54e95b1543e787e8714feb1d34ce", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 58 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Locations);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2423, 98, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-3\">\r\n                ");
            EndContext();
            BeginContext(2521, 314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f7f794d2bbb45d497110d42a826180b", async() => {
                BeginContext(2563, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2585, 31, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c558f8172bd4dfca05891c23bbfafa8", async() => {
                    BeginContext(2593, 14, true);
                    WriteLiteral("All Categories");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2616, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2638, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99bbe9ddb2f74db7b48b4ae472c55f98", async() => {
                    BeginContext(2646, 8, true);
                    WriteLiteral("Churches");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2663, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2685, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ece17e7451f4cef8315fccb94c98a61", async() => {
                    BeginContext(2693, 8, true);
                    WriteLiteral("Historic");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2710, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2732, 24, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ec7cab0b73d466a950555d92476c2ee", async() => {
                    BeginContext(2740, 7, true);
                    WriteLiteral("Museums");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2756, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2778, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "083ce325960d431689cd8558550b80b9", async() => {
                    BeginContext(2786, 13, true);
                    WriteLiteral("Walking tours");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2808, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 62 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchText);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2835, 1625, true);
            WriteLiteral(@"
            </div>
            <div class=""col-lg-2"">
                <input type=""submit"" name=""btn-search"" class=""btn_search"" onclick=""SearchClick()"" value=""Search"">
            </div>
        </div>
        <!-- /row -->
    </div>
    <div class=""wrapper-grid"">
        <div id=""tour-page-container""></div>
        <!-- /row -->
    </div>
    <!-- /wrapper-grid -->
    <p class=""text-center""><a href=""#"" onclick=""LoadMore()"" class=""btn_1 rounded add_top_30"">Load more</a></p>
</div>
<!-- /container -->
<div class=""bg_color_1"">
    <div class=""container margin_60_35"">
        <div class=""row"">
            <div class=""col-md-4"">
                <a href=""#0"" class=""boxed_list"">
                    <i class=""pe-7s-help2""></i>
                    <h4>Need Help? Contact us</h4>
                    <p>Cum appareat maiestatis interpretaris et, et sit.</p>
                </a>
            </div>
            <div class=""col-md-4"">
                <a href=""#0"" class=""boxed_list"">
          ");
            WriteLiteral(@"          <i class=""pe-7s-wallet""></i>
                    <h4>Payments</h4>
                    <p>Qui ea nemore eruditi, magna prima possit eu mei.</p>
                </a>
            </div>
            <div class=""col-md-4"">
                <a href=""#0"" class=""boxed_list"">
                    <i class=""pe-7s-note2""></i>
                    <h4>Cancel Policy</h4>
                    <p>Hinc vituperata sed ut, pro laudem nonumes ex.</p>
                </a>
            </div>
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
</div>
<!-- /bg_color_1 -->
");
            EndContext();
            BeginContext(4460, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d9d87178f434db5a589dd6142687796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4502, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4504, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b6334a495404c1fa5867bbc33e35ea6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4552, 251, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n        $(function () {\r\n            loadTourPage(0);\r\n        });\r\n\r\n        var loadTourPage = function (pageIndex, searchText, location, tourType,orderBy,viewType) {\r\n\r\n            $.ajax({\r\n                url: \'");
            EndContext();
            BeginContext(4804, 33, false);
#line 124 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml"
                 Write(Url.Action("GetTourList", "Tour"));

#line default
#line hidden
            EndContext();
            BeginContext(4837, 1022, true);
            WriteLiteral(@"',
                data: {
                        pageIndex: pageIndex,
                        pageSize: 6,
                        searchText: searchText,
                        location: location,
                        tourType: tourType,
                        orderBy: orderBy,
                        viewType: viewType
                },
                type: 'GET',
                success: function (data) {
                    var containerId = $(""#tour-page-container"").attr('id');
                    $(""#"" + containerId).html(data);
                }
            });
        }

        function SearchClick() {
            var searchText = $(""#SearchText"").val();
            var location = $(""#Location"").val();
            var tourType = $(""#TourType"").val();
            var viewType = $(""#ViewType"").val();
            loadTourPage(0, searchText, location, tourType, '', viewType);
    }


    function SortingEvenHandlers($this) {
        $.ajax({
                url: '");
            EndContext();
            BeginContext(5860, 42, false);
#line 153 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml"
                 Write(Url.Action("GetTourListByOrderBy", "Tour"));

#line default
#line hidden
            EndContext();
            BeginContext(5902, 597, true);
            WriteLiteral(@"',
            data: {
                orderBy: $this.val()
                },
                type: 'GET',
            success: function (data) {
                    var containerId = $(""#tour-page-container"").attr('id');
                    $(""#"" + containerId).html(data);
                }
            });
    }

    function ShowTourList() {
        loadTourPage(0,'','','','','true');
    }

    function ShowTourGrid() {
        loadTourPage(0);
    }


    function LoadMore() {
        var pageIndex = $(""#PageIndex"").val();
        $.ajax({
                url: '");
            EndContext();
            BeginContext(6500, 33, false);
#line 177 "E:\takeatrip\TakeATrip\TakeATrip.Web\Views\Tour\Index.cshtml"
                 Write(Url.Action("GetTourList", "Tour"));

#line default
#line hidden
            EndContext();
            BeginContext(6533, 658, true);
            WriteLiteral(@"',
                data: {
                    pageIndex: pageIndex+1,
                        pageSize: 3,
                        searchText: '',
                        location: '',
                        tourType: '',
                        orderBy: '',
                        viewType: ''
                },
                type: 'GET',
            success: function (data) {
                    alert
                    var containerId = $(""#tour-page-container"").attr('id');
                $(""#"" + containerId).append(data);
                $(""#PageIndex"").val(pageIndex+1);
                }
            });
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TakeATrip.Services.Models.TourModels.TourPage> Html { get; private set; }
    }
}
#pragma warning restore 1591