#pragma checksum "C:\Users\p.suryadi.suryadi\source\repos\DataKar\DataKar\Views\Karyawan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d02a20de5f188a80b55ed2ac17310c568d0c64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Karyawan_Index), @"mvc.1.0.view", @"/Views/Karyawan/Index.cshtml")]
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
#line 1 "C:\Users\p.suryadi.suryadi\source\repos\DataKar\DataKar\Views\_ViewImports.cshtml"
using DataKar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\p.suryadi.suryadi\source\repos\DataKar\DataKar\Views\_ViewImports.cshtml"
using DataKar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d02a20de5f188a80b55ed2ac17310c568d0c64", @"/Views/Karyawan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faac2da17edba0afa99693f12bd944f1a5801c42", @"/Views/_ViewImports.cshtml")]
    public class Views_Karyawan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DataKar.Models.Karyawan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\p.suryadi.suryadi\source\repos\DataKar\DataKar\Views\Karyawan\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\"><i class=\"fas fa-address-book\"></i>Data Karyawan Terbaru</h1>\r\n\r\n   \r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 12 "C:\Users\p.suryadi.suryadi\source\repos\DataKar\DataKar\Views\Karyawan\Index.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DataKar.Models.Karyawan>> Html { get; private set; }
    }
}
#pragma warning restore 1591