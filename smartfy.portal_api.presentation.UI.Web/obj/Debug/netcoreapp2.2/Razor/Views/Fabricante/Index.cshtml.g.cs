#pragma checksum "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "455e4a6544c49e8044aec9a808f9b13a40565a4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fabricante_Index), @"mvc.1.0.view", @"/Views/Fabricante/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fabricante/Index.cshtml", typeof(AspNetCore.Views_Fabricante_Index))]
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
#line 1 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using smartfy.portal_api.domain.Entities;

#line default
#line hidden
#line 2 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using smartfy.portal_api.presentation.UI.Web;

#line default
#line hidden
#line 3 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using smartfy.portal_api.presentation.UI.Web.Models;

#line default
#line hidden
#line 4 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using smartfy.portal_api.Infra.CrossCutting.Identity.Entities.ManagerViewModels;

#line default
#line hidden
#line 5 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using smartfy.portal_api.Infra.CrossCutting.Identity.Entities.AccountViewModels;

#line default
#line hidden
#line 6 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using smartfy.portal_api.Infra.CrossCutting.Identity.Entities;

#line default
#line hidden
#line 7 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 8 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\_ViewImports.cshtml"
using smartfy.portal_api.presentation.UI.Web.Controllers;

#line default
#line hidden
#line 1 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"455e4a6544c49e8044aec9a808f9b13a40565a4c", @"/Views/Fabricante/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1066962ad48d2ffc9704bd8149d1e346ca2324b6", @"/Views/_ViewImports.cshtml")]
    public class Views_Fabricante_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FabricanteViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FilterNome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "FilterNome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FilterCnpj"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "FilterCnpj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FilterEndereco"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "FilterEndereco", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FilterTelefone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "FilterTelefone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pesquisa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
   var tokenSet = antiforgery.GetAndStoreTokens(Context); 

#line default
#line hidden
            BeginContext(164, 35, true);
            WriteLiteral("\r\n<fieldset class=\"fieldset\">\r\n    ");
            EndContext();
            BeginContext(199, 2952, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455e4a6544c49e8044aec9a808f9b13a40565a4c9238", async() => {
                BeginContext(239, 43, true);
                WriteLiteral("\r\n\r\n        <div class=\"row\">\r\n            ");
                EndContext();
                BeginContext(282, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "455e4a6544c49e8044aec9a808f9b13a40565a4c9667", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 10 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(348, 463, true);
                WriteLiteral(@"

            <div class=""col-12"">
                <div class=""card mt-2"">
                    <div class=""card-body"">
                        <div class=""card-title""><h6>Filtros</h6></div>
                        <div class=""row"">
                            <div class=""col-1"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Codigo</label>
                                    ");
                EndContext();
                BeginContext(811, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "455e4a6544c49e8044aec9a808f9b13a40565a4c11938", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 20 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilterCodigo);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(880, 300, true);
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-5"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Nome</label>
                                    ");
                EndContext();
                BeginContext(1180, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "455e4a6544c49e8044aec9a808f9b13a40565a4c13950", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 26 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilterNome);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1281, 300, true);
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-2"">
                                <div class=""form-group"">
                                    <label class=""control-label"">CNPJ</label>
                                    ");
                EndContext();
                BeginContext(1581, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "455e4a6544c49e8044aec9a808f9b13a40565a4c16255", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 32 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilterCnpj);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1682, 304, true);
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-2"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Endereço</label>
                                    ");
                EndContext();
                BeginContext(1986, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "455e4a6544c49e8044aec9a808f9b13a40565a4c18564", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 38 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilterEndereco);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2099, 304, true);
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-2"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Telefone</label>
                                    ");
                EndContext();
                BeginContext(2403, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "455e4a6544c49e8044aec9a808f9b13a40565a4c20877", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 44 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FilterTelefone);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2516, 628, true);
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-3"">
                                <div class=""form-group"">
                                    <label class=""control-label""></label>
                                    <input type=""submit"" value=""Pesquisar"" class=""btn btn-success w-150"" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3151, 149, true);
            WriteLiteral("\r\n</fieldset>\r\n\r\n<fieldset class=\"fieldset\">\r\n    <legend>Fabricante</legend>\r\n    <div class=\"row-fluid\">\r\n        <div class=\"span6\">\r\n            ");
            EndContext();
            BeginContext(3301, 23, false);
#line 66 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(3324, 2033, true);
            WriteLiteral(@"
            <table id=""dt"" class=""dt table table-striped table-bordered""
                   style=""width:100%""
                   data-url=""/Fabricante/List""
                   data-cols=""codigo,nome,cnpj,telefone,endereco""
                   data-what=""Fabricante KeepTrack""
                   data-delete-url=""/Fabricante/Delete""
                   data-create-url=""/Fabricante/Create""
                   data-edit-url=""/Fabricante/Edit"">
                <thead>
                    <tr>
                        <th>Cod.</th>
                        <th>Nome</th>
                        <th>CNPJ</th>
                        <th>Telefone</th>
                        <th>Endereço</th>
                        <th data-orderable=""false"" class=""w-110""></th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
</fieldset>

<br />


<!-- Modal -->
<div class=""modal fade"" id=""excludeproduct"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hi");
            WriteLiteral(@"dden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Excluir Fabricante</h5>>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">

                <p>Você esta prestes a deletar <b id=""fabricante""></b>, essa ação não poderá mais ser desfeita.</p>
                <input type=""hidden"" id=""fabricanteId"" />
            </div>
            <div class=""modal-footer"">
                <button id=""btnCloseModal"" type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                <a id=""btnDeleteConfirmed"" href="""" type=""submit"" class=""btn btn-danger"">Excluir</a>
            </div>
        </div>
    </div>
</div>

<!-- PUSH JS likes-->
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5375, 971, true);
                WriteLiteral(@"
    <script>
$('#btnDeleteConfirmed').click(function () {
            //cb starts
            deleteItem($('#fabricanteId').val());
            //cb ends
        });


        function displayItem(fabricanteId) {
            //pegar o item
            $.ajax({
                url: '/api/Fabricante/' + fabricanteId,
                method: 'GET'
            }).done(function (data) {
                console.log(data.descricao);
                $(""#fabricante"").text(data.descricao);
                $(""#fabricanteId"").val(data.id);
            }).fail(function (errorMsg) {
                console.log(errorMsg);
                alert('Failed to save.');
            });
            //
        }

        function deleteItem(fabricanteId) {
            console.log(fabricanteId);



            $.ajax({
                url: '/Fabricante/DeleteConfirmed',
                type: 'POST',
                headers: {
                    '");
                EndContext();
                BeginContext(6347, 19, false);
#line 151 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
                Write(tokenSet.HeaderName);

#line default
#line hidden
                EndContext();
                BeginContext(6366, 5, true);
                WriteLiteral("\' : \'");
                EndContext();
                BeginContext(6372, 21, false);
#line 151 "C:\Dev\PortalApi\src\smartfy.portal_api.presentation.UI.Web\Views\Fabricante\Index.cshtml"
                                         Write(tokenSet.RequestToken);

#line default
#line hidden
                EndContext();
                BeginContext(6393, 206, true);
                WriteLiteral("\'\r\n                },\r\n                data: {\r\n                    Id: fabricanteId\r\n                },\r\n                dataType: \"json\",\r\n                success: function (response)\r\n                {\r\n");
                EndContext();
                BeginContext(6692, 321, true);
                WriteLiteral(@"
                },
                error: function (xhr) {
                }
            });

        }

        function rowCallBack(row, data) {

            $(row).find('#btn-remove').unbind('click').click(function () {
                displayItem(data.dT_RowId);
            });
        }</script>


");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAntiforgery antiforgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FabricanteViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
