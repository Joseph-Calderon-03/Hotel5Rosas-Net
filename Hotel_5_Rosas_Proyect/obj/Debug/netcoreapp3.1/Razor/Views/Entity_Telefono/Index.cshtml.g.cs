#pragma checksum "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c6cb40e344273619805cf0144837e89cef1dfbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Telefono_Index), @"mvc.1.0.view", @"/Views/Entity_Telefono/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c6cb40e344273619805cf0144837e89cef1dfbb", @"/Views/Entity_Telefono/Index.cshtml")]
    #nullable restore
    public class Views_Entity_Telefono_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities_Hotel_5_Rosas.Entity_Telefono>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FK_Hotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FK_Hotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 786, "\"", 818, 1);
#nullable restore
#line 34 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
WriteAttributeValue("", 801, item.PK_Telefono, 801, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 871, "\"", 903, 1);
#nullable restore
#line 35 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
WriteAttributeValue("", 886, item.PK_Telefono, 886, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 958, "\"", 990, 1);
#nullable restore
#line 36 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
WriteAttributeValue("", 973, item.PK_Telefono, 973, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\juanp\OneDrive\Escritorio\API Angular\Hotel_5_Rosas_Proyect\Views\Entity_Telefono\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities_Hotel_5_Rosas.Entity_Telefono>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
