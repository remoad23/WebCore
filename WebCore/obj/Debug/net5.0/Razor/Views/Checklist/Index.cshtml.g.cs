#pragma checksum "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\Checklist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22bfa22aadb9aaa24266a3e3ec6d426bcfdfb617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checklist_Index), @"mvc.1.0.view", @"/Views/Checklist/Index.cshtml")]
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
#line 1 "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\_ViewImports.cshtml"
using WebCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22bfa22aadb9aaa24266a3e3ec6d426bcfdfb617", @"/Views/Checklist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a6ce6d537e67e986845c61db3446ee688b862fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Checklist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tuple<ICollection<WebCore.Models.Check>, string, int>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Checklist</h1>\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\Checklist\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 10 "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\Checklist\Index.cshtml"
           Write(item.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Checked</th>\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\Checklist\Index.cshtml"
         foreach (var check in item.Item1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 16 "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\Checklist\Index.cshtml"
               Write(check.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\Checklist\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 20 "C:\Users\Patrick\source\repos\WebCore\WebCore\Views\Checklist\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tuple<ICollection<WebCore.Models.Check>, string, int>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
