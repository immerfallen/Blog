#pragma checksum "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1b9dfebbe1d4d3c8a46d9f78bdbd12b1d0c114e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1b9dfebbe1d4d3c8a46d9f78bdbd12b1d0c114e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ListaComentarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FormComentarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
  
    Layout = "_LayoutBlog";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 9 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
     foreach (Post item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <article");
            BeginWriteAttribute("id", " id=\"", 162, "\"", 180, 2);
            WriteAttributeValue("", 167, "post-", 167, 5, true);
#nullable restore
#line 11 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 172, item.Id, 172, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post\">\r\n            <h2 class=\"post-title\">");
#nullable restore
#line 12 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
                              Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <span class=\"post-date\">");
#nullable restore
#line 13 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
                               Write(item.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <div class=\"post-content\">\r\n                <p>");
#nullable restore
#line 15 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
              Write(item.Texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n            <section");
            BeginWriteAttribute("id", " id=\"", 424, "\"", 446, 2);
            WriteAttributeValue("", 429, "comments-", 429, 9, true);
#nullable restore
#line 18 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 438, item.Id, 438, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"comments>\r\n                <h4>Comentários</h4>\r\n                <partial name=\"_ListaComentarios\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1b9dfebbe1d4d3c8a46d9f78bdbd12b1d0c114e6462", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Comentarios;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f1b9dfebbe1d4d3c8a46d9f78bdbd12b1d0c114e8100", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </section>\r\n\r\n        </article>\r\n");
#nullable restore
#line 26 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
     for(int i=1;i<= (int)ViewData["Paginas"];i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 840, "\"", 853, 2);
            WriteAttributeValue("", 847, "/?p=", 847, 4, true);
#nullable restore
#line 31 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
WriteAttributeValue("", 851, i, 851, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 32 "D:\SENAC-CursoTecnico\Módulo 2\02 - Documentar e realizar manutenção de sites\codigos\Blog\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
