#pragma checksum "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d0669169eebeb76d59ce2a738fb6a63ebc287a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_CompareResult_Default), @"mvc.1.0.view", @"/Views/Home/Components/CompareResult/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/CompareResult/Default.cshtml", typeof(AspNetCore.Views_Home_Components_CompareResult_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d0669169eebeb76d59ce2a738fb6a63ebc287a9", @"/Views/Home/Components/CompareResult/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469edcd8bd60dd4d2600dc87e55ed542db34f955", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_CompareResult_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JsonToJsonCompareEngine.ComparisonOutput>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
  
    ViewData["Title"] = "Grid";

#line default
#line hidden
            BeginContext(89, 1198, true);
            WriteLiteral(@"
<div class=""table-responsive center-block"">
    <div>
        <label>Prevoius File Name:</label> <span id=""prevFileName"">TSID_001_CS_OrangeCountry_219_json</span>
    </div>
    <div>
        <label>Current File Name:</label> <span id=""currFileName"">TSID_001_CS_OrangeCountry_219_json</span>
    </div>
    <div>
        <label>State:</label> <span id=""stateName"">NA</span>
        <label>Country:</label> <span id=""countryName"">NA</span>
    </div>
    <table class=""event-list"">
        <tr style=""background-color:cyan"" class=""pointer"" onclick=""Redirect()"">
            <!-- Remove This >>>>> class=""pointer"" onclick=""Redirect()""-->
            <th colspan=""2"" align=""center"">Total Elements Count</th>
            <th rowspan=""2"" align=""center"">Matched elements Count</th>
            <th rowspan=""2"">Mismatched Count</th>
            <th colspan=""2"" align=""center"">Current Version</th>
            <th rowspan=""2"">Exclusion Count</th>
        </tr>
        <tr style=""background-color:cyan;border:2");
            WriteLiteral("px\">\r\n            <th>Previous Version</th>\r\n            <th>Current Version</th>\r\n            <th>Removed Elements</th>\r\n            <th>Added Elements</th>\r\n        </tr>\r\n");
            EndContext();
#line 32 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
         if (Model.FileCompareResult != null)
        {

#line default
#line hidden
            BeginContext(1345, 82, true);
            WriteLiteral("            <tr class=\"pointer\" onclick=\"Redirect(\'param\')\">\r\n                <td>");
            EndContext();
            BeginContext(1428, 39, false);
#line 35 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.StateInPrevious);

#line default
#line hidden
            EndContext();
            BeginContext(1467, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1495, 38, false);
#line 36 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.StateInCurrent);

#line default
#line hidden
            EndContext();
            BeginContext(1533, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1561, 38, false);
#line 37 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.FileExistInNew);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1627, 38, false);
#line 38 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.FileExistInOld);

#line default
#line hidden
            EndContext();
            BeginContext(1665, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1693, 47, false);
#line 39 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.TotalElementsCountInNew);

#line default
#line hidden
            EndContext();
            BeginContext(1740, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1768, 47, false);
#line 40 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.TotalElementsCountInOld);

#line default
#line hidden
            EndContext();
            BeginContext(1815, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1843, 44, false);
#line 41 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.MatchedElementsCount);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1915, 40, false);
#line 42 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.MismatchedCounts);

#line default
#line hidden
            EndContext();
            BeginContext(1955, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1983, 44, false);
#line 43 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.RemovedElementsInNew);

#line default
#line hidden
            EndContext();
            BeginContext(2027, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2055, 42, false);
#line 44 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.AddedElementsInNew);

#line default
#line hidden
            EndContext();
            BeginContext(2097, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2125, 38, false);
#line 45 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
               Write(Model.FileCompareResult.ExclusionCount);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 47 "D:\TestProject\JsonToJsonCompareEngine.UI\Views\Home\Components\CompareResult\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(2200, 135, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n<script>\r\n    function Redirect(param) {\r\n        window.location.href = \"/Home/Results\";\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JsonToJsonCompareEngine.ComparisonOutput> Html { get; private set; }
    }
}
#pragma warning restore 1591
