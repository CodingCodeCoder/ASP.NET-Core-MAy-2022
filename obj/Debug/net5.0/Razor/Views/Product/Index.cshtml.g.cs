#pragma checksum "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc45a99152438781189ab8ae076d157cd8bdbc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\_ViewImports.cshtml"
using ASP.Net_Core_May_2022;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\_ViewImports.cshtml"
using ASP.Net_Core_May_2022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc45a99152438781189ab8ae076d157cd8bdbc6", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d61f44d14a973e7ca53f5a0857f207833ed60da5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP.Net_Core_May_2022.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Products</h1>\n\n");
            WriteLiteral("<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.P_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.P_descript));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.P_InDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.P_QOH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.P_Min));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.P_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 34 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.P_Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 37 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.V_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 43 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 46 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 49 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_descript));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 52 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_InDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 55 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_QOH));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 58 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_Min));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.P_Discount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 67 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.V_code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
            WriteLiteral("            </td>\n        </tr>\n");
#nullable restore
#line 75 "C:\Program Files\Git\repos\ASP.Net-Core-May-2022-master\ASP.Net Core May 2022\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP.Net_Core_May_2022.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591