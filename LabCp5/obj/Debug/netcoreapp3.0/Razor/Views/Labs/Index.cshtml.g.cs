#pragma checksum "C:\Users\eugene\source\repos\Lab5_CP\Views\Labs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a40c587beb8ad1407d0ee43693f5039e72bcfea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Labs_Index), @"mvc.1.0.view", @"/Views/Labs/Index.cshtml")]
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
#line 1 "C:\Users\eugene\source\repos\Lab5_CP\Views\_ViewImports.cshtml"
using TaskAuthenticationAuthorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eugene\source\repos\Lab5_CP\Views\_ViewImports.cshtml"
using TaskAuthenticationAuthorization.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a40c587beb8ad1407d0ee43693f5039e72bcfea", @"/Views/Labs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c888d70e8cc542637613e6c131fe6b3ef545a25", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Labs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TaskAuthenticationAuthorization.Models.Lab1Model>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\eugene\source\repos\Lab5_CP\Views\Labs\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 6 "C:\Users\eugene\source\repos\Lab5_CP\Views\Labs\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.x));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 9 "C:\Users\eugene\source\repos\Lab5_CP\Views\Labs\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.y));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 12 "C:\Users\eugene\source\repos\Lab5_CP\Views\Labs\Index.cshtml"
       Write(Html.DisplayFor(modelItem => item.answer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\eugene\source\repos\Lab5_CP\Views\Labs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TaskAuthenticationAuthorization.Models.Lab1Model>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591