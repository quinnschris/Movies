#pragma checksum "/Users/quinnchristensen/OneDrive - BYU/College/Junior Core/Winter 2021/IS 413 ~ Enterprise Application Development/Movies/Movies/Views/Home/Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad51b2d7df66a13f282dd91a0ee167e0a9b07b8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmation), @"mvc.1.0.view", @"/Views/Home/Confirmation.cshtml")]
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
#nullable restore
#line 1 "/Users/quinnchristensen/OneDrive - BYU/College/Junior Core/Winter 2021/IS 413 ~ Enterprise Application Development/Movies/Movies/Views/_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/quinnchristensen/OneDrive - BYU/College/Junior Core/Winter 2021/IS 413 ~ Enterprise Application Development/Movies/Movies/Views/_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad51b2d7df66a13f282dd91a0ee167e0a9b07b8b", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4086b040a53f3ecc1a39220bf19c4bdad8b179c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movies.Models.AddMovie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/quinnchristensen/OneDrive - BYU/College/Junior Core/Winter 2021/IS 413 ~ Enterprise Application Development/Movies/Movies/Views/Home/Confirmation.cshtml"
  
    ViewBag.Title = "Confirmation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<!--Page to confirm a movie was accepted-->\n\n<div class=\"masthead container d-flex align-items-center flex-column\">\n    <h2>Your Movie was successfully submitted!</h2>\n    <p>The movie, \"");
#nullable restore
#line 12 "/Users/quinnchristensen/OneDrive - BYU/College/Junior Core/Winter 2021/IS 413 ~ Enterprise Application Development/Movies/Movies/Views/Home/Confirmation.cshtml"
              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" was added to the list.</p>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movies.Models.AddMovie> Html { get; private set; }
    }
}
#pragma warning restore 1591
