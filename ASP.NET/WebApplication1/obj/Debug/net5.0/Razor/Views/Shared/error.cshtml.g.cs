#pragma checksum "C:\Users\moham\Desktop\moso\ASP.NET\WebApplication1\Views\Shared\error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a01dac1afb235d4fa06a3d0460cb9b312e7107"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_error), @"mvc.1.0.view", @"/Views/Shared/error.cshtml")]
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
#line 1 "C:\Users\moham\Desktop\moso\ASP.NET\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\moham\Desktop\moso\ASP.NET\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a01dac1afb235d4fa06a3d0460cb9b312e7107", @"/Views/Shared/error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d35ac56dd50ef88310c7a9e17225608ef4972b7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h3>\r\n    An error occured while processing your request.\r\n    The support team has been notified and we are working on the fix\r\n</h3>\r\n<h5>\r\n    Please contact us on mohammadsorkhian@gmail.com\r\n</h5>\r\n<hr />\r\n<h3>Exception Details:</h3>\r\n<h3>Path: ");
#nullable restore
#line 10 "C:\Users\moham\Desktop\moso\ASP.NET\WebApplication1\Views\Shared\error.cshtml"
     Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Message: ");
#nullable restore
#line 11 "C:\Users\moham\Desktop\moso\ASP.NET\WebApplication1\Views\Shared\error.cshtml"
        Write(ViewBag.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Stack Trace: ");
#nullable restore
#line 12 "C:\Users\moham\Desktop\moso\ASP.NET\WebApplication1\Views\Shared\error.cshtml"
            Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
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
