#pragma checksum "C:\20486D\Ejercicios\Mod-8\LAK\01_ZooSite_begin\ZooSite\Views\Zoo\VisitorDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c4897686ad491bba94e29a96834f426f4d5462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zoo_VisitorDetails), @"mvc.1.0.view", @"/Views/Zoo/VisitorDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Zoo/VisitorDetails.cshtml", typeof(AspNetCore.Views_Zoo_VisitorDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c4897686ad491bba94e29a96834f426f4d5462", @"/Views/Zoo/VisitorDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b35857dd199098649926cf8d40cf1622e149676b", @"/Views/_ViewImports.cshtml")]
    public class Views_Zoo_VisitorDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\20486D\Ejercicios\Mod-8\LAK\01_ZooSite_begin\ZooSite\Views\Zoo\VisitorDetails.cshtml"
  
    ViewData["Title"] = "VisitorDetails";

#line default
#line hidden
            BeginContext(48, 921, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""info"">
        <p class=""contact-title"">Park Hours</p>
        <p class=""sub-header"">Weekends and Holidays</p>
        <p>10:00 AM - 5:00 PM</p>
        <p>Monday - Friday</p>
        <p>10:00 AM - 5:30 PM</p>
    </div>
    <div class=""info"">
        <p class=""contact-title"">Zoo Schedule</p>
        <table>
            <tr>
                <td>09:00 AM</td>
                <td>Zoo Opens</td>
            </tr>
            <tr>
                <td>11:00 AM</td>
                <td>Sea Water Show</td>
            </tr>
            <tr>
                <td>2:00 PM</td>
                <td>Sea Lion Feeding</td>
            </tr>
            <tr>
                <td>5:00 PM</td>
                <td>Exhibits Close</td>
            </tr>
            <tr>
                <td>5:30 PM</td>
                <td>Zoo Closes</td>
            </tr>
        </table>
    </div>
</div>
");
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
