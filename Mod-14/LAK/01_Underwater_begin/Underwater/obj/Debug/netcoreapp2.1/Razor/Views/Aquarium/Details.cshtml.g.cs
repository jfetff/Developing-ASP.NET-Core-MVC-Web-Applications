#pragma checksum "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4b5b5a6346e8c391c6e84cddbf5f57eeaefb9ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aquarium_Details), @"mvc.1.0.view", @"/Views/Aquarium/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Aquarium/Details.cshtml", typeof(AspNetCore.Views_Aquarium_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4b5b5a6346e8c391c6e84cddbf5f57eeaefb9ae", @"/Views/Aquarium/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Aquarium_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Underwater.Models.Fish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 123, true);
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"photo-index-card-details\">\n        <h3 class=\"display-picture-title\">\n            ");
            EndContext();
            BeginContext(195, 44, false);
#line 10 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
       Write(Html.DisplayFor(modelItem => modelItem.Name));

#line default
#line hidden
            EndContext();
            BeginContext(239, 15, true);
            WriteLiteral("\n        </h3>\n");
            EndContext();
#line 12 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
         if (Model.ImageName != null)
       {
        

#line default
#line hidden
#line 14 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
         if (Model.ImageURL != null)
           {

#line default
#line hidden
            BeginContext(351, 78, true);
            WriteLiteral("        <div class=\"photo-display\">\n            <img class=\"photo-display-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 429, "\"", 450, 1);
#line 17 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
WriteAttributeValue("", 435, Model.ImageURL, 435, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(451, 19, true);
            WriteLiteral(" />\n        </div>\n");
            EndContext();
#line 19 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           }
           else
           {

#line default
#line hidden
            BeginContext(512, 78, true);
            WriteLiteral("        <div class=\"photo-display\">\n            <img class=\"photo-display-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 590, "\"", 658, 1);
#line 23 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
WriteAttributeValue("", 596, Url.Action("GetImage", "Aquarium", new { Id = Model.FishId }), 596, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 19, true);
            WriteLiteral(" />\n        </div>\n");
            EndContext();
#line 25 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           }

#line default
#line hidden
#line 25 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
            
       }

#line default
#line hidden
            BeginContext(700, 68, true);
            WriteLiteral("        <div>\n            <p class=\"display-label\">\n                ");
            EndContext();
            BeginContext(769, 50, false);
#line 29 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(819, 91, true);
            WriteLiteral("\n            </p>\n            <br />\n            <p class=\"display-field\">\n                ");
            EndContext();
            BeginContext(911, 46, false);
#line 33 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayFor(model => model.ScientificName));

#line default
#line hidden
            EndContext();
            BeginContext(957, 101, true);
            WriteLiteral("\n            </p>\n        </div>\n        <div>\n            <p class=\"display-label\">\n                ");
            EndContext();
            BeginContext(1059, 46, false);
#line 38 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CommonName));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 91, true);
            WriteLiteral("\n            </p>\n            <br />\n            <p class=\"display-field\">\n                ");
            EndContext();
            BeginContext(1197, 42, false);
#line 42 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
           Write(Html.DisplayFor(model => model.CommonName));

#line default
#line hidden
            EndContext();
            BeginContext(1239, 106, true);
            WriteLiteral("\n            </p>\n        </div>\n        <div>\n            <button class=\"btn btn-secondary\" type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1345, "\"", 1403, 3);
            WriteAttributeValue("", 1355, "location.href=\'", 1355, 15, true);
#line 46 "C:\20486D\Ejercicios\Mod-14\LAK\01_Underwater_begin\Underwater\Views\Aquarium\Details.cshtml"
WriteAttributeValue("", 1370, Url.Action("Index", "Aquarium"), 1370, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 1402, "\'", 1402, 1, true);
            EndWriteAttribute();
            BeginContext(1404, 48, true);
            WriteLiteral(">Back</button>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Underwater.Models.Fish> Html { get; private set; }
    }
}
#pragma warning restore 1591
