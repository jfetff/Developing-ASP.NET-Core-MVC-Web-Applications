#pragma checksum "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc47626a80428cc331bee5ad70a3c35ec7570cfc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc47626a80428cc331bee5ad70a3c35ec7570cfc", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PhotoSharingSample.Models.Photo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/photo-sharing-styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(77, 25, true);
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(102, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27e86195c62e47c2a202d18277feffb3", async() => {
                BeginContext(108, 93, true);
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Home page</title>\n\n    ");
                EndContext();
                BeginContext(201, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "510ba0c4679f447c9a507a2a290f0b0c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                BeginContext(280, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(288, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(289, 1359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c476dd67d6674b75b1520c7b9055d0ec", async() => {
                BeginContext(295, 215, true);
                WriteLiteral("\n    <h1 class=\"main-title\">Photos Unlimited</h1>\n    <p class=\"into\">Join, upload, share, and comment instantly. Bring your photographic vision to everyone.</p>\n    <p class=\"into\">Our latest Photos</p>\n    <br />\n");
                EndContext();
#line 21 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
                BeginContext(549, 103, true);
                WriteLiteral("        <div class=\"photo-index-card\">\n            <h3 class=\"display-picture-title\">\n                \"");
                EndContext();
                BeginContext(653, 40, false);
#line 25 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
            Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
                EndContext();
                BeginContext(693, 20, true);
                WriteLiteral("\"\n            </h3>\n");
                EndContext();
#line 27 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
             if (item.PhotoFileName != null)
            {

#line default
#line hidden
                BeginContext(772, 94, true);
                WriteLiteral("                <div class=\"photo-display\">\n                    <img class=\"photo-display-img\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 866, "\"", 935, 1);
#line 30 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
WriteAttributeValue("", 872, Url.Action("GetImage", "Home", new { PhotoId = item.PhotoID }), 872, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(936, 27, true);
                WriteLiteral(" />\n                </div>\n");
                EndContext();
#line 32 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(977, 84, true);
                WriteLiteral("\n            <div>\n                <span class=\"display-label\">\n                    ");
                EndContext();
                BeginContext(1062, 47, false);
#line 36 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1109, 114, true);
                WriteLiteral(":\n                </span>\n                <br />\n                <span class=\"display-field\">\n                    ");
                EndContext();
                BeginContext(1224, 42, false);
#line 40 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
                EndContext();
                BeginContext(1266, 128, true);
                WriteLiteral("\n                </span>\n            </div>\n\n            <div>\n                <span class=\"display-label\">\n                    ");
                EndContext();
                BeginContext(1395, 47, false);
#line 46 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1442, 91, true);
                WriteLiteral(":\n                </span>\n                <span class=\"display-field\">\n                    ");
                EndContext();
                BeginContext(1534, 42, false);
#line 49 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(model => item.CreatedDate));

#line default
#line hidden
                EndContext();
                BeginContext(1576, 59, true);
                WriteLiteral("\n                </span>\n            </div>\n        </div>\n");
                EndContext();
#line 53 "C:\20486D\Ejercicios\Mod-1\DEMO\01_PhotoSharingSample\PhotoSharingSample\Views\Home\Index.cshtml"
    }

#line default
#line hidden
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
            BeginContext(1648, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PhotoSharingSample.Models.Photo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
