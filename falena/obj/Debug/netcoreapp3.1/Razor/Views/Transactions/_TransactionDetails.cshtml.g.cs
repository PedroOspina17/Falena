#pragma checksum "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e1fef54864f6a6c7c4e29752a3a2ed1ab9138b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions__TransactionDetails), @"mvc.1.0.view", @"/Views/Transactions/_TransactionDetails.cshtml")]
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
#line 1 "C:\Pedro\Repos\falena\falena\Views\_ViewImports.cshtml"
using falena;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Pedro\Repos\falena\falena\Views\_ViewImports.cshtml"
using falena.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e1fef54864f6a6c7c4e29752a3a2ed1ab9138b4", @"/Views/Transactions/_TransactionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f05375bd78e10dc1aec715645f6f9ad598aa2f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions__TransactionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<falena.Models.TransactionDetail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 7 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 10 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 13 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.CurrentProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 16 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SellPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 24 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Product.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.CurrentProductPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.SellPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.SubTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 43 "C:\Pedro\Repos\falena\falena\Views\Transactions\_TransactionDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<falena.Models.TransactionDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591