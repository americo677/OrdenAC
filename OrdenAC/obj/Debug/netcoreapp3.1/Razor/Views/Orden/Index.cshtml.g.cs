#pragma checksum "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c145abae2b93433e33b72d13030bf1d4f236c0b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orden_Index), @"mvc.1.0.view", @"/Views/Orden/Index.cshtml")]
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
#line 1 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/_ViewImports.cshtml"
using OrdenAC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/_ViewImports.cshtml"
using OrdenAC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c145abae2b93433e33b72d13030bf1d4f236c0b1", @"/Views/Orden/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627101bddd1a6cbbfe1d30aeaa5feb67fe7fd349", @"/Views/_ViewImports.cshtml")]
    public class Views_Orden_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OrdenAC.Models.OrdenModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 8 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<h2>Listado de Órdenes</h2>\n\n<p>\n    ");
#nullable restore
#line 17 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
Write(Html.ActionLink("Registrar", "create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n\n    <tr>\n        <th>\n            ");
#nullable restore
#line 24 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.OrdenModelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 27 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 30 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.OficinaVentaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 33 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n        <th>\n            ");
#nullable restore
#line 36 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Producto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n    </tr>\n\n");
#nullable restore
#line 40 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 44 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrdenModelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OficinaVentaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Producto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n</tr>\n");
#nullable restore
#line 59 "/Users/americo/Proyectos/workspace-studio/OrdenAC/OrdenAC/Views/Orden/Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OrdenAC.Models.OrdenModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
