#pragma checksum "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "082d91f94f23d2ef0ee3158fd20f783d7e12eae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082d91f94f23d2ef0ee3158fd20f783d7e12eae1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AzureStorageDemo.Models.Photo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 118, true);
            WriteLiteral("\n<h1 class=\"into\">My Photo Album</h1>\n<h2 class=\"into\">Latest Memories</h2>\n<button type=\"button\" class=\"btn btn-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 207, "\"", 267, 3);
            WriteAttributeValue("", 217, "location.href=\'", 217, 15, true);
#line 9 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 232, Url.Action("CreateImage", "Blob"), 232, 34, false);

#line default
#line hidden
            WriteAttributeValue("", 266, "\'", 266, 1, true);
            EndWriteAttribute();
            BeginContext(268, 34, true);
            WriteLiteral(">Upload New Image</button>\n<br />\n");
            EndContext();
#line 11 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(333, 90, true);
            WriteLiteral("    <div class=\"photo-index-card\">\n        <h3 class=\"display-picture-title\">\n            ");
            EndContext();
            BeginContext(424, 40, false);
#line 15 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(464, 15, true);
            WriteLiteral("\n        </h3>\n");
            EndContext();
#line 17 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
         if (item.ImageName != null)
        {

#line default
#line hidden
            BeginContext(526, 86, true);
            WriteLiteral("            <div class=\"photo-display\">\n                <img class=\"photo-display-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 612, "\"", 671, 1);
#line 20 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
WriteAttributeValue("", 618, Url.Action("GetImage", "Home", new { Id = item.Id }), 618, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(672, 23, true);
            WriteLiteral(" />\n            </div>\n");
            EndContext();
#line 22 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(705, 72, true);
            WriteLiteral("\n        <div>\n            <span class=\"display-label\">\n                ");
            EndContext();
            BeginContext(778, 47, false);
#line 26 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(825, 98, true);
            WriteLiteral(":\n            </span>\n            <br />\n            <span class=\"display-field\">\n                ");
            EndContext();
            BeginContext(924, 42, false);
#line 30 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(966, 108, true);
            WriteLiteral("\n            </span>\n        </div>\n\n        <div>\n            <span class=\"display-label\">\n                ");
            EndContext();
            BeginContext(1075, 47, false);
#line 36 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1122, 79, true);
            WriteLiteral(":\n            </span>\n            <span class=\"display-field\">\n                ");
            EndContext();
            BeginContext(1202, 42, false);
#line 39 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(model => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 47, true);
            WriteLiteral("\n            </span>\n        </div>\n    </div>\n");
            EndContext();
#line 43 "C:\20486D\Ejercicios\Mod-14\DEMO\02_AzureStorageDemo_begin\AzureStorageDemo\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1293, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AzureStorageDemo.Models.Photo>> Html { get; private set; }
    }
}
#pragma warning restore 1591