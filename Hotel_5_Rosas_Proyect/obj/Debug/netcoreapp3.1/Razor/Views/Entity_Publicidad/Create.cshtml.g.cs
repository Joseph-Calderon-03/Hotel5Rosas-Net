#pragma checksum "C:\Users\josep\Desktop\Universidad\Ingenieria de software\Proyecto\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "271965d2f3c15c8bc9de4911271891fca4ec1588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entity_Publicidad_Create), @"mvc.1.0.view", @"/Views/Entity_Publicidad/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"271965d2f3c15c8bc9de4911271891fca4ec1588", @"/Views/Entity_Publicidad/Create.cshtml")]
    #nullable restore
    public class Views_Entity_Publicidad_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities_Hotel_5_Rosas.Entity_Publicidad>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\josep\Desktop\Universidad\Ingenieria de software\Proyecto\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Entity_Publicidad</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nombre"" class=""control-label""></label>
                <input asp-for=""Nombre"" class=""form-control"" />
                <span asp-validation-for=""Nombre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Descripcion"" class=""control-label""></label>
                <input asp-for=""Descripcion"" class=""form-control"" />
                <span asp-validation-for=""Descripcion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FK_Imagen"" class=""control-label""></label>
                <input asp-for=""FK_Imagen"" class=""form-control"" />
                <span asp-validation-for=""FK_Imagen"" class=""");
            WriteLiteral(@"text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""FK_Hotel"" class=""control-label""></label>
                <input asp-for=""FK_Hotel"" class=""form-control"" />
                <span asp-validation-for=""FK_Hotel"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\josep\Desktop\Universidad\Ingenieria de software\Proyecto\Hotel5Rosas-Net\Hotel_5_Rosas_Proyect\Views\Entity_Publicidad\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities_Hotel_5_Rosas.Entity_Publicidad> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
