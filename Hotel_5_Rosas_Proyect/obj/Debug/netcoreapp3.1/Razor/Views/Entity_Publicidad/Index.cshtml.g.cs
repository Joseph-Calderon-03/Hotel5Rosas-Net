#pragma checksum "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42427c3fc6aca5bd27df935e8bdcb8ee13299e2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Publicidad_Index), @"mvc.1.0.view", @"/Views/Entity_Publicidad/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42427c3fc6aca5bd27df935e8bdcb8ee13299e2c", @"/Views/Entity_Publicidad/Index.cshtml")]
    #nullable restore
    public class Views_Entity_Publicidad_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities_Hotel_5_Rosas.Entity_Publicidad>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FK_Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FK_Hotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FK_Imagen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FK_Hotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1194, "\"", 1228, 1);
#nullable restore
#line 46 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
WriteAttributeValue("", 1209, item.PK_Publicidad, 1209, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1281, "\"", 1315, 1);
#nullable restore
#line 47 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
WriteAttributeValue("", 1296, item.PK_Publicidad, 1296, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1370, "\"", 1404, 1);
#nullable restore
#line 48 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
WriteAttributeValue("", 1385, item.PK_Publicidad, 1385, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 51 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities_Hotel_5_Rosas.Entity_Publicidad>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
