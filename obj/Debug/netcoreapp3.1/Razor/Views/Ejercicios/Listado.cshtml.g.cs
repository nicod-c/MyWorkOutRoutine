#pragma checksum "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ee419eea4a63cce9c8f831f80b007cf28bf2e1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ejercicios_Listado), @"mvc.1.0.view", @"/Views/Ejercicios/Listado.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#nullable restore
#line 2 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
using X.PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ee419eea4a63cce9c8f831f80b007cf28bf2e1a", @"/Views/Ejercicios/Listado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1e48b1ff962b5b24692fc4eeca2ae1f4f7cc7d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Ejercicios_Listado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.PagedList<Ejercicio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
  
    ViewData["Title"] = "Ejercicios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<button class=\"fas fa-plus\" , style=\"float: right; background-color: yellow; color: white; border:solid-blue;\r\n    margin-top: 1rem;\">\r\n    ");
#nullable restore
#line 24 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
Write(Html.ActionLink("Nuevo","Nuevo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</button>\r\n\r\n<h1>Ejercicios</h1>\r\n\r\n");
#nullable restore
#line 29 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Buscar ejercicio: ");
#nullable restore
#line 32 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
                     Write(Html.TextBox("campobusqueda"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Buscar\" class=\"btn btn-primary\" />\r\n    </p>\r\n");
#nullable restore
#line 35 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table table-hover "" style=""text-align: center; padding-top: 1rem"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Ejercicio</th>
            <th scope=""col"">Video</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
         foreach (var item in Model)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 51 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
                                              Write(item.EjercicioId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"vertical-align: middle\">");
#nullable restore
#line 52 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
                                              Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"vertical-align: middle\">\r\n                    ");
#nullable restore
#line 54 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
               Write(MostrarVideoYouTube(@item.Urlvideo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td style=\"vertical-align: middle\">\r\n                    ");
#nullable restore
#line 58 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
               Write(Html.ActionLink("", "Editar", new{id = item.EjercicioId}
                ,new {@class="far fa-edit"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 60 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
               Write(Html.ActionLink("", "Borrar", new{id = item.EjercicioId}
                ,new {@class="fas fa-trash-alt"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n\r\n<div style=\"display: flex; justify-content: center\">\r\n    P??gina ");
#nullable restore
#line 70 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
       Write(Model.PageCount <Model.PageNumber ? 0: Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" de ");
#nullable restore
#line 70 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
                                                                    Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 72 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
Write(Html.PagedListPager(Model, pagina => Url.Action("Listado",
new {pagina,sortOrder=ViewBag.CurrentSort , currentFilter=ViewBag.currentFilter }),
new X.PagedList.Mvc.Core.Common.PagedListRenderOptions{
ContainerDivClasses=new[] {"pagination justify-content-center"},
PageClasses=new[] {"page-link"},
LiElementClasses=Enumerable.Empty<string>()
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
            
    string MostrarVideoYouTube(string Urlvideo)
    {

#line default
#line hidden
#nullable disable
        WriteLiteral("        <iframe width=\"280\" height=\"160\"");
        BeginWriteAttribute("src", " src=\"", 278, "\"", 293, 1);
#nullable restore
#line 13 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"
WriteAttributeValue("", 284, Urlvideo, 284, 9, false);

#line default
#line hidden
#nullable disable
        EndWriteAttribute();
        WriteLiteral(" title=\"YouTube video player\" frameborder=\"0\"\r\n        allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\"\r\n        allowfullscreen></iframe>\r\n");
#nullable restore
#line 16 "C:\Programacion_y_sistemas\ISTEA_tec_sistemas\2do_cuatri_mar21\Herramientas_de_programacion\Proyectos\primerParcial - Copy\Views\Ejercicios\Listado.cshtml"

        return string.Empty;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.PagedList<Ejercicio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
