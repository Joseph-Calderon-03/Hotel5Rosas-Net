#pragma checksum "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfc3aff4334708b6dd8a1d109f7c3b2dfe8a9463"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Administrador_Delete), @"mvc.1.0.view", @"/Views/Entity_Administrador/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfc3aff4334708b6dd8a1d109f7c3b2dfe8a9463", @"/Views/Entity_Administrador/Delete.cshtml")]
    #nullable restore
    public class Views_Entity_Administrador_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities_Hotel_5_Rosas.Entity_Administrador>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Entity_Administrador</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FK_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FK_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre_Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Constrasenna));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\mario\OneDrive\Escritorio\Proyecto5Rosas\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Administrador\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Constrasenna));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""PK_Administrador"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities_Hotel_5_Rosas.Entity_Administrador> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
