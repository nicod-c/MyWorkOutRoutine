#pragma checksum "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92bcab1db1bf80461e637bac8d9cb67a759c9e1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ejercicios_Nuevo), @"mvc.1.0.view", @"/Views/Ejercicios/Nuevo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92bcab1db1bf80461e637bac8d9cb67a759c9e1f", @"/Views/Ejercicios/Nuevo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e48b1ff962b5b24692fc4eeca2ae1f4f7cc7d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Ejercicios_Nuevo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<primerParcial.Models.VM.EjercicioVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
  
    ViewData["Title"] = "Nuevo Ejercicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cargar nuevo ejercicio</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
 using (@Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 13 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Ejercicio.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.Ejercicio.Nombre, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div> \r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 17 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Ejercicio.MusculoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.DropDownListFor(m =>m.Ejercicio.MusculoId,
    new SelectList(Model.Musculos, "MusculoId", "Nombre"), "--Seleccionar--",
    new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div> \r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 23 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Ejercicio.ParteDelCuerpoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.DropDownListFor(m =>m.Ejercicio.ParteDelCuerpoId,
    new SelectList(Model.PartesDelCuerpo, "ParteDelCuerpoId", "Nombre"), "--Seleccionar--",
    new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div> \r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 29 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.LabelFor(m=>m.Ejercicio.Urlvideo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 30 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
   Write(Html.TextBoxFor(m=>m.Ejercicio.Urlvideo, new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" name=\"guardar\" value=\"Guardar\" class=\"btn btn-primary\" />\r\n    <input type=\"submit\" name=\"cancelar\" value=\"Cancelar\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 35 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Nuevo.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<primerParcial.Models.VM.EjercicioVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
