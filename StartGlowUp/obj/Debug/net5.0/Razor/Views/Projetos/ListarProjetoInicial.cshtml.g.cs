#pragma checksum "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2929ac8a4f9fbffd5e4e2cd3f7f6b5eac91705c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projetos_ListarProjetoInicial), @"mvc.1.0.view", @"/Views/Projetos/ListarProjetoInicial.cshtml")]
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
#line 1 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\_ViewImports.cshtml"
using StartGlowUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\_ViewImports.cshtml"
using StartGlowUp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
using MySql.Data.MySqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2929ac8a4f9fbffd5e4e2cd3f7f6b5eac91705c8", @"/Views/Projetos/ListarProjetoInicial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"460d851391e83043c77055127acbf42f1fe020fb", @"/Views/_ViewImports.cshtml")]
    public class Views_Projetos_ListarProjetoInicial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projetos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" pesquisa d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!doctype html>\r\n<html lang=\"pt-br\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2929ac8a4f9fbffd5e4e2cd3f7f6b5eac91705c84657", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""/CSS/index.css"">
    <link rel=""stylesheet"" href=""/JS/index.js"">
    <script src=""https://kit.fontawesome.com/9ab573c9fb.js"" crossorigin=""anonymous""></script>
    <title>Página Inicial</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2929ac8a4f9fbffd5e4e2cd3f7f6b5eac91705c86211", async() => {
                WriteLiteral("\r\n\r\n    <header>\r\n\r\n        <nav class=\"navbar navbar-expand-lg \">\r\n            <div class=\"container\">\r\n                <div");
                BeginWriteAttribute("class", " class=\"", 864, "\"", 872, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <a href=\"/HOME/inicio.html\"><img class=\"logo\" src=\"/IMG/logo1.JPG\"></a>\r\n                </div>\r\n\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2929ac8a4f9fbffd5e4e2cd3f7f6b5eac91705c86914", async() => {
                    WriteLiteral(@"
                    <input class=""form-control me-2"" type=""search"" placeholder=""Pesquisar"" aria-label=""Search"">
                    <button class=""btn btn-outline-primary"" type=""submit""><i class=""fa-solid fa-magnifying-glass""></i></button>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


                <div class=""div-links"">
                    <div class=""link"">
                        <a href=""#"">Nome do Usuário</a>
                    </div>
                    <div class=""link"">
                        <a href=""#""><i id=""icones"" class=""fa-solid fa-arrow-right-to-bracket""></i></a>
                    </div>
                </div>
            </div>

        </nav>
    </header>
");
#nullable restore
#line 48 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
     if (Model != null) {


        foreach (Projetos p in Model) {
            byte[] img_user = null;
            string nome_user = "";
            MySqlConnection con = new MySqlConnection("Server=ESN509VMYSQL;Database=sgu;User id=aluno;Password=Senai1234");
            con.Open();
            MySqlCommand comando = new MySqlCommand("select img_user , nome_user from usuario where doc_user = @doc", con);
            comando.Parameters.AddWithValue("@doc", p.Doc_user);
            MySqlDataReader leitor = comando.ExecuteReader();
            while (leitor.Read()) {
                img_user = (byte[])leitor["img_user"];
                nome_user = leitor["nome_user"].ToString();
            }
            string formatoImg_user = "data:image/jpeg;base64," + Convert.ToBase64String(img_user);
            int i = 0;
            con.Close();


#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"publicacao container\">\r\n\r\n            <div class=\"identificacao conteiner row \">\r\n                <div class=\"foto-perfil col-3\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 2777, "\"", 2799, 1);
#nullable restore
#line 71 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
WriteAttributeValue("", 2783, formatoImg_user, 2783, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"col\">\r\n                    <h4>");
#nullable restore
#line 74 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
                   Write(nome_user);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                    <h6>\r\n                      ");
#nullable restore
#line 76 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
                 Write(p.Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h6>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 80 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
             foreach (byte[] img in p.Galeria) {

                string formatoImg_proj = "data:image/jpeg;base64," + Convert.ToBase64String(p.Galeria[i]);


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"imagens container\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 3258, "\"", 3280, 1);
#nullable restore
#line 85 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
WriteAttributeValue("", 3264, formatoImg_proj, 3264, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n");
#nullable restore
#line 87 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
                i++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""comentarios"">
                <button id=""like"">
                    <div class=""label"">
                        <i class=""fa-regular fa-heart""></i>
                        Curtir
                    </div>

                    <div class=""number"" id=""number"">0</div>
                </button>
            </div>
        </div>
");
#nullable restore
#line 100 "C:\Users\aluno\Downloads\StartGlowUp\StartGlowUp\StartGlowUp\Views\Projetos\ListarProjetoInicial.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <div class=\"add\">\r\n            <a");
                BeginWriteAttribute("href", " href=\"", 3769, "\"", 3776, 0);
                EndWriteAttribute();
                WriteLiteral(@"><i id=""icone"" class="" fa-solid fa-square-plus""></i></a>
        </div>
        

        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js""
                integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p""
                crossorigin=""anonymous""></script>


    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projetos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
