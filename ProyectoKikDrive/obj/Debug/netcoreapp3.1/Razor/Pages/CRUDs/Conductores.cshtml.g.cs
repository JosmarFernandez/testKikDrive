#pragma checksum "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\CRUDs\Conductores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "184ddfa0b5b3292d714819f26bc846caf4cb71d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoKikDrive.Pages.CRUDs.Pages_CRUDs_Conductores), @"mvc.1.0.razor-page", @"/Pages/CRUDs/Conductores.cshtml")]
namespace ProyectoKikDrive.Pages.CRUDs
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
#line 1 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\_ViewImports.cshtml"
using ProyectoKikDrive;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184ddfa0b5b3292d714819f26bc846caf4cb71d2", @"/Pages/CRUDs/Conductores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14feb2ce02be624aa592dccf759ae46c89f6b48c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CRUDs_Conductores : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""container"">
        <h1>Kik Drive</h1>
        <h4 class=""text-center"">Kik Drive Mejorando el Gestionamineto</h4>
        <h5 class=""text-center"">Registrar Conductores</h5>
        <div class=""containerCard"">
            <div class=""containercd"">

                <asp:Content ID=""Content3"" ContentPlaceHolderID=""MainContent"" runat=""server"">
                    <table>
                        <tr>
                            <td>
                                ID:
                            </td>
                            <td>
                                <asp:TextBox ID=""txtName""
                                             runat=""server""
                                             required=""true""></asp:TextBox>
                            </td>
                            <th>
                                <div class=""form-group"">
                                    <input type=""text"" />
                                </div>
                            </th>
            WriteLiteral(@"
                        </tr>
                        <tr>
                            <td>
                                Nombre:
                            </td>
                            <td>
                                <asp:TextBox ID=""txtEmail""
                                             runat=""server"" required=""true""
                                             type=""Email""></asp:TextBox>
                            </td>
                            <th>
                                <div class=""form-group"">
                                    <input type=""text"" />
                                </div>
                            </th>
                        </tr>
                        <tr>
                            <td>
                                Apellido Paterno:
                            </td>
                            <td>
                                <asp:TextBox ID=""txtPassword""
                                             runat=""server"" required");
            WriteLiteral(@"=""true""
                                             type=""Password""></asp:TextBox>
                            </td>
                            <th>
                                <div class=""form-group"">
                                    <input type=""text"" />
                                </div>
                            </th>
                        </tr>
                        <tr>
                            <td>
                                Apellido Materno:
                            </td>
                            <td>
                                <asp:TextBox ID=""txtConfirmPassword""
                                             runat=""server"" required=""true""
                                             type=""Password""></asp:TextBox>
                            </td>
                            <th>
                                <div class=""form-group"">
                                    <input type=""text"" />
                                </div>
            ");
            WriteLiteral(@"                </th>
                        </tr>
                        <tr>
                            <td>
                                Vehiculo:
                            </td>
                            <td>
                                <asp:TextBox ID=""txtAddress""
                                             runat=""server"" required=""true""
                                             TextMode=""MultiLine""></asp:TextBox>
                            </td>
                            <th>
                                <div class=""form-group"">
                                    <input type=""text"" />
                                </div>
                            </th>
                        </tr>
                        <tr>
                            <td>
                                Tipo de Licencia:
                            </td>
                            <td>
                                <asp:TextBox ID=""txtAddress""
                                   ");
            WriteLiteral(@"          runat=""server"" required=""true""
                                             TextMode=""MultiLine""></asp:TextBox>
                            </td>
                            <th>
                                <div class=""form-group"">
                                    <input type=""text"" />
                                </div>
                            </th>
                        </tr>


                    </table>
                </asp:Content>
                <div class=""container"">

                    <a class=""btn btn-primary"" href=""#"" role=""button"">Agregar</a>


                    <a class=""btn btn-primary"" href=""#"" role=""button"">Eliminar</a>


                    <a class=""btn btn-primary"" href=""#"" role=""button"">Actualizar</a>


                    <a class=""btn btn-primary"" href=""#"" role=""button"">Consultar</a>

                </div>
            </div>
        </div>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoKikDrive.Pages.CRUDs.ConductoresModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoKikDrive.Pages.CRUDs.ConductoresModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoKikDrive.Pages.CRUDs.ConductoresModel>)PageContext?.ViewData;
        public ProyectoKikDrive.Pages.CRUDs.ConductoresModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591