#pragma checksum "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/Home/Confirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52f9a8a1705fa9354f4248f9c12a5889f6a459f8"
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
#line 1 "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/_ViewImports.cshtml"
using DateMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/_ViewImports.cshtml"
using DateMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f9a8a1705fa9354f4248f9c12a5889f6a459f8", @"/Views/Home/Confirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b035ddeb23ca3f1ed9053bdf891bb4246414da0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DateMe.Models.ApplicationResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/Home/Confirmation.cshtml"
  
    ViewData["Title"] = "Application Submitted";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/Home/Confirmation.cshtml"
 if (Model.CreeperStalker == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>My bad. I forgot that I\'m already in a relationship. But I have a friend who I think would be perfect for you.</h2>\n");
#nullable restore
#line 9 "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/Home/Confirmation.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Application received. Thank you, ");
#nullable restore
#line 12 "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/Home/Confirmation.cshtml"
                                    Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\n    <h3>(Although, you really ought to be thanking me for even considering going out with you.)</h3>\n");
#nullable restore
#line 14 "/Users/cadenkarras/Documents/TestingIS414Github/Mission5/DateMe/Views/Home/Confirmation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DateMe.Models.ApplicationResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
