#pragma checksum "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "073573167488d751117de71ed5d78dc23e0e62cd05bb63341daa2c54f112f351"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Noticia_Create), @"mvc.1.0.view", @"/Views/Noticia/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\_ViewImports.cshtml"
using ICI.ProvaCandidato.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\_ViewImports.cshtml"
using ICI.ProvaCandidato.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
using ICI.ProvaCandidato.Negocio.Models.Noticias;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"073573167488d751117de71ed5d78dc23e0e62cd05bb63341daa2c54f112f351", @"/Views/Noticia/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d8cce516d9545c6313b79436eec1fa4615695139125fbf1dfa5db0c836b5cf25", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Noticia_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Noticiia>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
  
    ViewBag.Title = "Criar Notícia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Criar Nova Notícia</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
 using (Html.BeginForm("Create", "Noticia", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 13 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
   Write(Html.LabelFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
   Write(Html.TextBoxFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 17 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
   Write(Html.LabelFor(model => model.Texto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
   Write(Html.TextAreaFor(model => model.Texto, new { rows = 4, cols = 40 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <!-- Adicione mais campos conforme necessário -->\r\n    <div>\r\n        <input type=\"submit\" value=\"Salvar\" />\r\n    </div>\r\n");
#nullable restore
#line 24 "C:\Users\jessi\OneDrive\Ambiente de Trabalho\ICI.ProvaCandidato\ICI.ProvaCandidato.Web\Views\Noticia\Create.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Noticiia> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
