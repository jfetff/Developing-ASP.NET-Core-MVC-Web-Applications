#pragma checksum "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53b42d950e2ab3cde477e2864c04b2c1258a7015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aquarium_Index), @"mvc.1.0.view", @"/Views/Aquarium/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aquarium/Index.cshtml", typeof(AspNetCore.Views_Aquarium_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b42d950e2ab3cde477e2864c04b2c1258a7015", @"/Views/Aquarium/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Aquarium_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Underwater.Models.Fish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(82, 87, true);
            WriteLiteral("\n\n<h2 class=\"title\">\n    Dive Into Our Fish Species\n</h2>\n\n<div class=\"img-container\">\n");
            EndContext();
#line 13 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(208, 90, true);
            WriteLiteral("    <div class=\"photo-index-card\">\n        <h3 class=\"display-picture-title\">\n            ");
            EndContext();
            BeginContext(299, 39, false);
#line 17 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(338, 15, true);
            WriteLiteral("\n        </h3>\n");
            EndContext();
#line 19 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
         if (item.ImageName != null)
        {
    

#line default
#line hidden
#line 21 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
     if (item.ImageURL != null)
    {

#line default
#line hidden
            BeginContext(438, 70, true);
            WriteLiteral("    <div class=\"photo-display\">\n        <img class=\"photo-display-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 508, "\"", 528, 1);
#line 24 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
WriteAttributeValue("", 514, item.ImageURL, 514, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(529, 15, true);
            WriteLiteral(" />\n    </div> ");
            EndContext();
#line 25 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
           }
                        else
                        {

#line default
#line hidden
            BeginContext(601, 70, true);
            WriteLiteral("    <div class=\"photo-display\">\n        <img class=\"photo-display-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 671, "\"", 738, 1);
#line 29 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
WriteAttributeValue("", 677, Url.Action("GetImage", "Aquarium", new { Id = item.FishId }), 677, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(739, 14, true);
            WriteLiteral(" />\n    </div>");
            EndContext();
#line 30 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
          }

#line default
#line hidden
#line 30 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
           }

#line default
#line hidden
            BeginContext(756, 68, true);
            WriteLiteral("        <div>\n            <p class=\"display-label\">\n                ");
            EndContext();
            BeginContext(825, 49, false);
#line 33 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
           Write(Html.DisplayNameFor(model => item.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(874, 91, true);
            WriteLiteral("\n            </p>\n            <br />\n            <p class=\"display-field\">\n                ");
            EndContext();
            BeginContext(966, 45, false);
#line 37 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
           Write(Html.DisplayFor(model => item.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 59, true);
            WriteLiteral("\n            </p>\n        </div>\n        <div>\n            ");
            EndContext();
            BeginContext(1070, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bee28ff078c6462bbc5a3c740c0e68ad", async() => {
                BeginContext(1119, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
                                   WriteLiteral(item.FishId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1127, 15, true);
            WriteLiteral(" |\n            ");
            EndContext();
            BeginContext(1142, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebef1f63bbdf4613a8a201b710ffcd9e", async() => {
                BeginContext(1194, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
                                      WriteLiteral(item.FishId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1205, 15, true);
            WriteLiteral(" |\n            ");
            EndContext();
            BeginContext(1220, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63e015b38955409480e8d068a1a18b54", async() => {
                BeginContext(1271, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
                                     WriteLiteral(item.FishId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1281, 27, true);
            WriteLiteral("\n        </div>\n    </div>\n");
            EndContext();
#line 46 "C:\20486D\Developing-ASP.NET-Core-MVC-Web-Applications\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1314, 8, true);
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Underwater.Models.Fish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
