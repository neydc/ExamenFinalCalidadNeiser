#pragma checksum "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05a1e112a8fa7eccc36a4719feaec3a163ba3647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JuegoDePoker_DetalleCartas), @"mvc.1.0.view", @"/Views/JuegoDePoker/DetalleCartas.cshtml")]
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
#line 1 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\_ViewImports.cshtml"
using Calidad_NeiserFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\_ViewImports.cshtml"
using Calidad_NeiserFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05a1e112a8fa7eccc36a4719feaec3a163ba3647", @"/Views/JuegoDePoker/DetalleCartas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece001f7413a3ab20e36bdda5e1150798a44f324", @"/Views/_ViewImports.cshtml")]
    public class Views_JuegoDePoker_DetalleCartas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-sm-2\">\n        Jugador: <strong>");
#nullable restore
#line 3 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                    Write(ViewBag.Jugadores[0].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n        <table class=\"table table-dark\">\n            <thead>\n            <tr>\n\n                <th>Numero</th>\n                <th>Tipo</th>\n          \n            </tr>\n            </thead>\n");
#nullable restore
#line 13 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
             foreach (var item in @ViewBag.Jugador1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n\n                    <td>");
#nullable restore
#line 17 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                   Write(item.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>");
#nullable restore
#line 18 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                   Write(item.tipoCarta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    \n                </tr>\n");
#nullable restore
#line 21 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </table>\n        <h4>Puntaje: ");
#nullable restore
#line 24 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                Write(ViewBag.Jugadores[0].Puntaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col-sm-2\">\n        Jugador:<strong>");
#nullable restore
#line 27 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                   Write(ViewBag.Jugadores[1].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n        <table class=\"table table-dark\">\n            <thead>\n                <tr>\n\n                    <th>Numero</th>\n                    <th>Tipo</th>\n\n                </tr>\n            </thead>\n");
#nullable restore
#line 37 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
             foreach (var item in @ViewBag.Jugador2)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n\n        <td>");
#nullable restore
#line 41 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 42 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.tipoCarta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    </tr>\n");
#nullable restore
#line 45 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </table>\n        <h4>Puntaje: ");
#nullable restore
#line 48 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                Write(ViewBag.Jugadores[1].Puntaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col-sm-2\">\n        Jugador: <strong> ");
#nullable restore
#line 51 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                     Write(ViewBag.Jugadores[2].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>    \n        <table class=\" table table-dark\">\n            <thead>\n                <tr>\n\n                    <th>Numero</th>\n                    <th>Tipo</th>\n\n                </tr>\n            </thead>\n");
#nullable restore
#line 61 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
             foreach (var item in @ViewBag.Jugador3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n\n        <td>");
#nullable restore
#line 65 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 66 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.tipoCarta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    </tr>            ");
#nullable restore
#line 68 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </table>\n        <h4>Puntaje: ");
#nullable restore
#line 71 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                Write(ViewBag.Jugadores[2].Puntaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col-sm-2\">\n        Jugador: <strong> ");
#nullable restore
#line 74 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                     Write(ViewBag.Jugadores[3].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n        <table class=\"table table-dark\">\n            <thead>\n                <tr>\n\n                    <th>Numero</th>\n                    <th>Tipo</th>\n\n                </tr>\n            </thead>\n");
#nullable restore
#line 84 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
             foreach (var item in @ViewBag.Jugador4)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n\n        <td>");
#nullable restore
#line 88 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 89 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.tipoCarta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    </tr>            ");
#nullable restore
#line 91 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </table>\n        <h4>Puntaje: ");
#nullable restore
#line 94 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                Write(ViewBag.Jugadores[3].Puntaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n    <div class=\"col-sm-2\">\n        Jugador: <strong> ");
#nullable restore
#line 97 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                     Write(ViewBag.Jugadores[2].Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n        <table class=\"table table-dark\">\n            <thead>\n                <tr>\n\n                    <th>Numero</th>\n                    <th>Tipo</th>\n\n                </tr>\n            </thead>\n");
#nullable restore
#line 107 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
             foreach (var item in @ViewBag.Jugador5)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n\n        <td>");
#nullable restore
#line 111 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 112 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
       Write(item.tipoCarta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n    </tr>            ");
#nullable restore
#line 114 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </table>\n        <h4>Puntaje: ");
#nullable restore
#line 117 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
                Write(ViewBag.Jugadores[4].Puntaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    </div>\n</div>\n<strong>");
#nullable restore
#line 120 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
   Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\n");
#nullable restore
#line 121 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
 foreach (var item in @ViewBag.JugadoresGanadores)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>\n    ");
#nullable restore
#line 124 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 124 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
            Write(item.Puntaje);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Pts\n\n\n</h2>\n");
#nullable restore
#line 128 "C:\Users\Administrador\source\repos\Calidad_NeiserFinal\Calidad_NeiserFinal\Views\JuegoDePoker\DetalleCartas.cshtml"
    
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
