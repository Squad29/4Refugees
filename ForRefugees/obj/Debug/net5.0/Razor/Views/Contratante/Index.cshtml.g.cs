#pragma checksum "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "693f5fee8bf7a6eaf619a86a0cbfacfd8efab3d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contratante_Index), @"mvc.1.0.view", @"/Views/Contratante/Index.cshtml")]
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
#line 1 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\_ViewImports.cshtml"
using ForRefugees;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\_ViewImports.cshtml"
using ForRefugees.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693f5fee8bf7a6eaf619a86a0cbfacfd8efab3d0", @"/Views/Contratante/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"886b6422216bf3dc58cd0b74bce86c4670b6c544", @"/Views/_ViewImports.cshtml")]
    public class Views_Contratante_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ForRefugees.Models.Contratante>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693f5fee8bf7a6eaf619a86a0cbfacfd8efab3d04916", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Seguimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorHora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 64 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cnpj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Seguimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorHora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataCadastro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bairro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693f5fee8bf7a6eaf619a86a0cbfacfd8efab3d017714", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 106 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693f5fee8bf7a6eaf619a86a0cbfacfd8efab3d019963", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "693f5fee8bf7a6eaf619a86a0cbfacfd8efab3d022218", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 111 "C:\Users\Naassom Pedro\Documents\Desenvolvimento\Recode\squad-29\Site Projeto Refugees\Site Projeto Refugees\4Refugees\ForRefugees\Views\Contratante\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ForRefugees.Models.Contratante>> Html { get; private set; }
    }
}
#pragma warning restore 1591
