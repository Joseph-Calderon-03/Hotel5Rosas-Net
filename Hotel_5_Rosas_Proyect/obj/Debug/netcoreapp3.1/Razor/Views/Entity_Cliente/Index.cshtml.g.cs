#pragma checksum "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7b15c1b77a94f2fcbe417ac0eed86c92724de72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Cliente_Index), @"mvc.1.0.view", @"/Views/Entity_Cliente/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7b15c1b77a94f2fcbe417ac0eed86c92724de72", @"/Views/Entity_Cliente/Index.cshtml")]
    #nullable restore
    public class Views_Entity_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities_Hotel_5_Rosas.Entity_Cliente>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FK_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero_Tarjeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FK_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero_Tarjeta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1000, "\"", 1031, 1);
#nullable restore
#line 40 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
WriteAttributeValue("", 1015, item.PK_Cliente, 1015, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1084, "\"", 1115, 1);
#nullable restore
#line 41 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
WriteAttributeValue("", 1099, item.PK_Cliente, 1099, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1170, "\"", 1201, 1);
#nullable restore
#line 42 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
WriteAttributeValue("", 1185, item.PK_Cliente, 1185, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Cliente\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities_Hotel_5_Rosas.Entity_Cliente>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
