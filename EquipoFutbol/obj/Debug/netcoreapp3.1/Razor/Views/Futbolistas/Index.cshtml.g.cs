#pragma checksum "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3549878978348890710dced47ee46c683cc693fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Futbolistas_Index), @"mvc.1.0.view", @"/Views/Futbolistas/Index.cshtml")]
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
#line 1 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\_ViewImports.cshtml"
using EquipoFutbol;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\_ViewImports.cshtml"
using EquipoFutbol.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3549878978348890710dced47ee46c683cc693fc", @"/Views/Futbolistas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78287535dcbadf3b0a13c89e37158802004e4705", @"/Views/_ViewImports.cshtml")]
    public class Views_Futbolistas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EquipoFutbol.Entities.View_Futbolistas>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/bundles/futbol.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3549878978348890710dced47ee46c683cc693fc3963", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 4 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class="" container"">
    <div class="" cabecera"">
        <h1> Futbolistas</h1>
    </div>
    <table class=""table table-hover"">
        <thead class=""thead-dark"">
            <tr>
                <th> ID </th>
                <th> Nombres </th>
                <th> Apellidos </th>
                <th> Edad </th>
                <th> Posicion </th>
                <th> Fecha de Registro </th>
                <th>
                    <button class=""btn btn-outline-success"" id=""btnAbreModal"" type=""button"" data-target=""#modalFutbol""> Agregar +</button>
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
             foreach (var item in Model) // va a mostrar todos los campos por cada registro de la tabla
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
               Write(item.FutbolistasID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
               Write(item.Nombres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
               Write(item.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
               Write(item.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
               Write(item.Posicion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
               Write(item.FechaRegristro);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                </td>\r\n\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 1565, "\"", 1599, 2);
            WriteAttributeValue("", 1570, "btnEditar_", 1570, 10, true);
#nullable restore
#line 51 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
WriteAttributeValue("", 1580, item.FutbolistasID, 1580, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-marker fa-lg\"></i></a>\r\n                    <a");
            BeginWriteAttribute("id", " id=\"", 1663, "\"", 1699, 2);
            WriteAttributeValue("", 1668, "btnEliminar_", 1668, 12, true);
#nullable restore
#line 52 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
WriteAttributeValue("", 1680, item.FutbolistasID, 1680, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger ml-1\"><i class=\"fa fa-trash-alt fa-lg\"></i></a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Herny\source\repos\EquipoFutbol\EquipoFutbol\Views\Futbolistas\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EquipoFutbol.Entities.View_Futbolistas>> Html { get; private set; }
    }
}
#pragma warning restore 1591