#pragma checksum "C:\Users\josep\Desktop\Universidad\Ingenieria de software\Proyecto\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Reserva\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d7f789360116b02ea52c74f5f3a3465467db44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Reserva_Edit), @"mvc.1.0.view", @"/Views/Entity_Reserva/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d7f789360116b02ea52c74f5f3a3465467db44", @"/Views/Entity_Reserva/Edit.cshtml")]
    #nullable restore
    public class Views_Entity_Reserva_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities_Hotel_5_Rosas.Entity_Reserva>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\josep\Desktop\Universidad\Ingenieria de software\Proyecto\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Reserva\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Entity_Reserva</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""PK_Reserva"" />
            <div class=""form-group"">
                <label asp-for=""FK_Habitacion"" class=""control-label""></label>
                <input asp-for=""FK_Habitacion"" class=""form-control"" />
                <span asp-validation-for=""FK_Habitacion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FK_Cliente"" class=""control-label""></label>
                <input asp-for=""FK_Cliente"" class=""form-control"" />
                <span asp-validation-for=""FK_Cliente"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fecha_Transaccion"" class=""control-label""></label>
                <input asp-for=""Fecha_Transaccion"" ");
            WriteLiteral(@"class=""form-control"" />
                <span asp-validation-for=""Fecha_Transaccion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fecha_Inicio"" class=""control-label""></label>
                <input asp-for=""Fecha_Inicio"" class=""form-control"" />
                <span asp-validation-for=""Fecha_Inicio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Fecha_Fin"" class=""control-label""></label>
                <input asp-for=""Fecha_Fin"" class=""form-control"" />
                <span asp-validation-for=""Fecha_Fin"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Tarifa_Total"" class=""control-label""></label>
                <input asp-for=""Tarifa_Total"" class=""form-control"" />
                <span asp-validation-for=""Tarifa_Total"" class=""text-danger""></span>
            </div>
            <div class");
            WriteLiteral("=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 58 "C:\Users\josep\Desktop\Universidad\Ingenieria de software\Proyecto\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Reserva\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities_Hotel_5_Rosas.Entity_Reserva> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
