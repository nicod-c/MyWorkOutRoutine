#pragma checksum "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda3101ca6028285c1b062660a78d9e122a5a5b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Nuevo), @"mvc.1.0.view", @"/Views/Clientes/Nuevo.cshtml")]
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
#line 1 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\_ViewImports.cshtml"
using primerParcial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\_ViewImports.cshtml"
using primerParcial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda3101ca6028285c1b062660a78d9e122a5a5b8", @"/Views/Clientes/Nuevo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e48b1ff962b5b24692fc4eeca2ae1f4f7cc7d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Nuevo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
  
    ViewData["Title"] = "Nuevo Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Ingresar nuevo cliente</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
 using (@Html.BeginForm(null, null, FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    // @Html.ValidationSummary(false,"", new { @class = "text-danger" })


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.Nombre, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.ValidationMessageFor(m=>m.Nombre,"",new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.Apellido, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 23 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.ValidationMessageFor(m=>m.Apellido,"",new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.DNI, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.ValidationMessageFor(m=>m.DNI,"",new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 32 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.fechaNac));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.fechaNac,new {@class="form-control", type="date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.ValidationMessageFor(m=>m.fechaNac,"",new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 38 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.Peso,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.ValidationMessageFor(m=>m.Peso,"",new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 42 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 43 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.Altura,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.ValidationMessageFor(m=>m.Altura,"",new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 48 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.ObjetivoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 49 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.DropDownListFor(m => m.ObjetivoId,
    new SelectList(ViewBag.Objetivos, "ObjetivoId", "Nombre"), "--Seleccionar--",
    new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 55 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Foto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"custom-file\">\r\n            ");
#nullable restore
#line 57 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
       Write(Html.TextBoxFor(m=>m.Foto,new {type="file",@class="form-control custom-file-input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 58 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
       Write(Html.LabelFor(m=>m.Foto,"Seleccionar Foto",new {@class="custom-file-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" name=\"guardar\" value=\"Guardar\" class=\"btn btn-primary\" />\r\n    <input type=\"submit\" name=\"cancelar\" value=\"Cancelar\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 64 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Clientes\Nuevo.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
