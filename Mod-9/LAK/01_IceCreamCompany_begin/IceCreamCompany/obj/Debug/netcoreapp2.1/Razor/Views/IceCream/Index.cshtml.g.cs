#pragma checksum "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4259ae1f4580fc9043dba7c9e497df6d1af80f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IceCream_Index), @"mvc.1.0.view", @"/Views/IceCream/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/IceCream/Index.cshtml", typeof(AspNetCore.Views_IceCream_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4259ae1f4580fc9043dba7c9e497df6d1af80f7", @"/Views/IceCream/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_IceCream_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IceCreamCompany.Models.IceCream>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(91, 64, true);
            WriteLiteral("\n<h1>Choose your favourite one</h1>\n<div class=\"img-container\">\n");
            EndContext();
#line 9 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(194, 60, true);
            WriteLiteral("        <div class=\"item\">\n            <h3>\n                ");
            EndContext();
            BeginContext(255, 41, false);
#line 13 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flavor));

#line default
#line hidden
            EndContext();
            BeginContext(296, 19, true);
            WriteLiteral("\n            </h3>\n");
            EndContext();
#line 15 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
             if (item.PhotoFileName != null)
            {

#line default
#line hidden
            BeginContext(374, 46, true);
            WriteLiteral("                <div>\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 420, "\"", 499, 1);
#line 18 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
WriteAttributeValue("", 426, Url.Action("GetImage", "IceCream", new { iceCreamId = item.IceCreamId }), 426, 73, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(500, 27, true);
            WriteLiteral(" />\n                </div>\n");
            EndContext();
#line 20 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(541, 58, true);
            WriteLiteral("            <div>\n                <p>\n                    ");
            EndContext();
            BeginContext(600, 36, false);
#line 23 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
               Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(636, 56, true);
            WriteLiteral("\n                </p>\n            </div>\n        </div>\n");
            EndContext();
#line 27 "C:\20486D\Ejercicios\Mod-9\LAK\01_IceCreamCompany_begin\IceCreamCompany\Views\IceCream\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(698, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IceCreamCompany.Models.IceCream>> Html { get; private set; }
    }
}
#pragma warning restore 1591
