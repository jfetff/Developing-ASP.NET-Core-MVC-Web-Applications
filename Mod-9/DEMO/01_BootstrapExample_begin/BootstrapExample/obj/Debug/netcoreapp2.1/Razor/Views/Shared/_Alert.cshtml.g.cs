#pragma checksum "C:\20486D\Ejercicios\Mod-9\DEMO\01_BootstrapExample_begin\BootstrapExample\Views\Shared\_Alert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3328484debd01e18ef4344f7cfec3c491fc31613"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Alert), @"mvc.1.0.view", @"/Views/Shared/_Alert.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Alert.cshtml", typeof(AspNetCore.Views_Shared__Alert))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3328484debd01e18ef4344f7cfec3c491fc31613", @"/Views/Shared/_Alert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Alert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 598, true);
            WriteLiteral(@"<section>
    <h2 class=""m-2"">Did you like the book you borrowed? </h2>
    <button type=""button"" class=""btn btn-outline-success"">Yes</button>
    <button type=""button"" class=""btn btn-outline-danger"">No</button>
    <div id=""alert"" class=""alert alert-success alert-dismissible fade show m-3"" role=""alert"">
        <strong>Thank you for the response!</strong>
        We will take this into consideration the next time we recommend you a book.
        <button type=""button"" class=""close"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591