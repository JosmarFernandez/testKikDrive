#pragma checksum "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3365d3589ad6acb2d812b3d0e71743acc6fa60b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoKikDrive.Pages.Supervisor.Pages_Supervisor_Delete), @"mvc.1.0.razor-page", @"/Pages/Supervisor/Delete.cshtml")]
namespace ProyectoKikDrive.Pages.Supervisor
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3365d3589ad6acb2d812b3d0e71743acc6fa60b", @"/Pages/Supervisor/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14feb2ce02be624aa592dccf759ae46c89f6b48c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Supervisor_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/CRUDs/SeccionPrincipal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">


        <h1>Kik Drive </h1>
        <h4 class=""text-center"">Kik Drive Mejorando el Gestionamineto</h4>
        <h1>Eliminar Supervisor</h1>

        <h3>¿Estas seguro que quieres eliminar a este supervisor?</h3>
        
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
                    ");
#nullable restore
#line 19 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.Apellido_Paterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.Apellido_Paterno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 31 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.Apellido_Materno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 34 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.Apellido_Materno));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.Usuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 43 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.Contraseña));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 46 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.Contraseña));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.CreatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.CreatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.UpdatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.UpdatedAT));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 67 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.SupervisorA.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 70 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
               Write(Html.DisplayFor(model => model.SupervisorA.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3365d3589ad6acb2d812b3d0e71743acc6fa60b12875", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3365d3589ad6acb2d812b3d0e71743acc6fa60b13150", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 75 "C:\Users\DABES_JOSMAR\Documents\Visual Studio 2019\Projets\KikDrive_1\ProyectoKikDrive\Pages\Supervisor\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SupervisorA.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-warning\" />\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3365d3589ad6acb2d812b3d0e71743acc6fa60b15002", async() => {
                    WriteLiteral("Regresar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3365d3589ad6acb2d812b3d0e71743acc6fa60b16325", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoKikDrive.Pages.Supervisor.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoKikDrive.Pages.Supervisor.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoKikDrive.Pages.Supervisor.DeleteModel>)PageContext?.ViewData;
        public ProyectoKikDrive.Pages.Supervisor.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
