#pragma checksum "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9385874ecfb6efc96d1d029d7d82833e5259dd52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Results.cshtml", typeof(AspNetCore.Views_Home_Results))]
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
#line 1 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\_ViewImports.cshtml"
using JsonToJsonCompareEngine.UI;

#line default
#line hidden
#line 2 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\_ViewImports.cshtml"
using JsonToJsonCompareEngine.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9385874ecfb6efc96d1d029d7d82833e5259dd52", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469edcd8bd60dd4d2600dc87e55ed542db34f955", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("result-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/TickIcon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/CautionIcon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/BlockIcon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/CloseIcon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Results.cshtml"
  
    ViewData["Title"] = "Results";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 50, true);
            WriteLiteral("<br />\r\n<p class=\"text-right\"><b>Report-Date: </b>");
            EndContext();
            BeginContext(143, 23, false);
#line 7 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Results.cshtml"
                                     Write(DateTime.Now.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(166, 225, true);
            WriteLiteral("</p>\r\n<div class=\"text-center heading-top\">\r\n    <h2 style=\"background-color: #ffffd4\">\r\n        Previous VS Current Version - CDR Files Comparision\r\n    </h2>\r\n</div>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        ");
            EndContext();
            BeginContext(391, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d3b079bffb74611a10957f56479ef57", async() => {
                BeginContext(404, 121, true);
                WriteLiteral("\r\n            <i class=\"glyphicon glyphicon-arrow-left\" style=\"margin:0px;\"></i>\r\n            <span>back</span>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(529, 784, true);
            WriteLiteral(@"
        <div class=""clearfix""></div>
        <br />

        <div>
            <label>Prevoius File Name:</label> <span id=""prevFileName"">{{PreviousFileName}}</span>
        </div>
        <div>
            <label>Current File Name:</label> <span id=""currFileName"">{{CurrentFileName}}</span>
        </div>
        <div>
            <label>State:</label> <span id=""stateName"">{{State}}</span>
            <label>County:</label> <span id=""countyName"">{{County}}</span>
        </div>

        <div class=""panel-group result-panel"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#collapse1"">
                            ");
            EndContext();
            BeginContext(1313, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a72b6d7956d4328b45a49e66e465e9d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1365, 6723, true);
            WriteLiteral(@"
                            Matched Element List
                        </a>
                        <div class=""btn-group pull-right"">
                            <a data-toggle=""collapse"" href=""#collapse1"" class=""btn btn-default btn-sm"">
                                <i class=""indicator glyphicon glyphicon-menu-down""></i>
                            </a>
                        </div>
                    </h4>

                </div>
                <div id=""collapse1"" class=""panel-collapse collapse"">
                    <div class=""panel-body result-table"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th>
                                            Sr. No.
                                        </th>
                                        <th>
                                           ");
            WriteLiteral(@" Element Name
                                        </th>
                                        <th>
                                            Previous Version
                                        </th>
                                        <th>
                                            Current Version
                                        </th>
                                    </tr>
                                </thead>
                                <tbody id=""ExlusionListBody"">
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
        ");
            WriteLiteral(@"                                <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                        ");
            WriteLiteral(@"                <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        ");
            WriteLiteral(@"<td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTim");
            WriteLiteral(@"eMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
      ");
            WriteLiteral(@"                                  <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
");
            EndContext();
            BeginContext(8158, 326, true);
            WriteLiteral(@"                </div>
                <div class=""clearfix""></div>
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#collapse2"">
                            ");
            EndContext();
            BeginContext(8484, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "727ba837528b40a3adb01df23e213831", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8539, 2358, true);
            WriteLiteral(@"
                            Mismatched Element List
                        </a>
                        <div class=""btn-group pull-right"">
                            <a data-toggle=""collapse"" href=""#collapse2"" class=""btn btn-default btn-sm"">
                                <i class=""indicator glyphicon glyphicon-menu-down""></i>
                            </a>
                        </div>
                    </h4>

                </div>
                <div id=""collapse2"" class=""panel-collapse collapse"">
                    <div class=""panel-body result-table"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th>
                                            Sr. No.
                                        </th>
                                        <th>
                                        ");
            WriteLiteral(@"    Element Name
                                        </th>
                                        <th>
                                            Previous Version
                                        </th>
                                        <th>
                                            Current Version
                                        </th>
                                    </tr>
                                </thead>
                                <tbody id=""ExlusionListBody"">
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
     ");
            WriteLiteral(@"                                   <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
");
            EndContext();
            BeginContext(10967, 326, true);
            WriteLiteral(@"                </div>
                <div class=""clearfix""></div>
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#collapse3"">
                            ");
            EndContext();
            BeginContext(11293, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d35199f5b8dc41b3aa879f5a930b6f69", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11346, 2359, true);
            WriteLiteral(@"
                            New/Removed Element List
                        </a>
                        <div class=""btn-group pull-right"">
                            <a data-toggle=""collapse"" href=""#collapse3"" class=""btn btn-default btn-sm"">
                                <i class=""indicator glyphicon glyphicon-menu-down""></i>
                            </a>
                        </div>
                    </h4>

                </div>
                <div id=""collapse3"" class=""panel-collapse collapse"">
                    <div class=""panel-body result-table"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th>
                                            Sr. No.
                                        </th>
                                        <th>
                                       ");
            WriteLiteral(@"     Element Name
                                        </th>
                                        <th>
                                            Previous Version
                                        </th>
                                        <th>
                                            Current Version
                                        </th>
                                    </tr>
                                </thead>
                                <tbody id=""ExlusionListBody"">
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
    ");
            WriteLiteral(@"                                    <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
");
            EndContext();
            BeginContext(13775, 326, true);
            WriteLiteral(@"                </div>
                <div class=""clearfix""></div>
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle=""collapse"" href=""#collapse4"">
                            ");
            EndContext();
            BeginContext(14101, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "35033fd00eba4fd79f104219a2b5dbe4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14154, 2356, true);
            WriteLiteral(@"
                            Excluded Element List
                        </a>
                        <div class=""btn-group pull-right"">
                            <a data-toggle=""collapse"" href=""#collapse4"" class=""btn btn-default btn-sm"">
                                <i class=""indicator glyphicon glyphicon-menu-down""></i>
                            </a>
                        </div>
                    </h4>

                </div>
                <div id=""collapse4"" class=""panel-collapse collapse"">
                    <div class=""panel-body result-table"">
                        <div class=""table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th>
                                            Sr. No.
                                        </th>
                                        <th>
                                          ");
            WriteLiteral(@"  Element Name
                                        </th>
                                        <th>
                                            Previous Version
                                        </th>
                                        <th>
                                            Current Version
                                        </th>
                                    </tr>
                                </thead>
                                <tbody id=""ExlusionListBody"">
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                    <tr>
                                        <td>1 </td>
                                        <td>* elapsedTimeMS</td>
       ");
            WriteLiteral(@"                                 <td>* elapsedTimeMS</td>
                                        <td>* elapsedTimeMS</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
");
            EndContext();
            BeginContext(16580, 126, true);
            WriteLiteral("                </div>\r\n                <div class=\"clearfix\"></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(16729, 392, true);
                WriteLiteral(@"
    <script>
        function toggleChevron(e) {
            $(e.target)
                .prev('.panel-heading')
                .find(""i.indicator"")
                .toggleClass('glyphicon-menu-down glyphicon-menu-up');
        }
        $('.result-panel').on('hidden.bs.collapse', toggleChevron);
        $('.result-panel').on('shown.bs.collapse', toggleChevron);
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
