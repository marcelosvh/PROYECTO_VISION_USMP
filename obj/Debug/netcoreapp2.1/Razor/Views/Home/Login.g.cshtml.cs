#pragma checksum "C:\Users\jeanp_000\Desktop\Vision03-11-18\PROYECTO_VISION_USMP\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd95b7a64ee00296df2ce3a9778c71811f2e4bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Login.cshtml", typeof(AspNetCore.Views_Home_Login))]
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
#line 1 "C:\Users\jeanp_000\Desktop\Vision03-11-18\PROYECTO_VISION_USMP\Views\_ViewImports.cshtml"
using PROYECTO_APP_VISION_VISUAL_STUDIO;

#line default
#line hidden
#line 2 "C:\Users\jeanp_000\Desktop\Vision03-11-18\PROYECTO_VISION_USMP\Views\_ViewImports.cshtml"
using PROYECTO_APP_VISION_VISUAL_STUDIO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd95b7a64ee00296df2ce3a9778c71811f2e4bce", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9623f6e822fbc5d1074dcc9a0ae2312b9704afd5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formAula"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 1841, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab6407fde07a4fc99ef09289793d7cde", async() => {
                BeginContext(41, 1828, true);
                WriteLiteral(@"
	<meta charset=""UTF-8"">
	<meta name=""viewport"" content=""width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"">
	<title>AdminLTE App Vision 1.0</title>
	<link href=""https://fonts.googleapis.com/css?family=Open+Sans:400,600,700"" rel=""stylesheet"">
	<link rel=""stylesheet"" href=""css/estilos.css"">
	<link rel=""stylesheet"" href=""font-awesome/css/font-awesome.min.css"">
	<script src=""js/jquery-3.3.1.js""></script>
	<script>

		// Letras

		function soloLetras(e) {
			key = e.keyCode || e.which;
			tecla = String.fromCharCode(key).toLowerCase();
			letras = "" áéíóúabcdefghijklmnñopqrstuvwxyz"";
			especiales = [8, 37, 39, 46];

			tecla_especial = false
			for(var i in especiales) {
				if(key == especiales[i]) {
					tecla_especial = true;
					break;
				}
			}

			if(letras.indexOf(tecla) == -1 && !tecla_especial)
				return false;
		}

		function limpia() {
			var val = document.getElementById(""letras"").value;
			var tam = val.length;
			for(i ");
                WriteLiteral(@"= 0; i < tam; i++) {
				if(!isNaN(val[i]))
					document.getElementById(""letras"").value = '';
			}
		}

	</script>
	<script>

		// Números

		function soloNumeros(e) {
			key = e.keyCode || e.which;
			tecla = String.fromCharCode(key).toLowerCase();
			numeros = "" 0123456789"";
			especiales = [8, 37, 39, 46];

			tecla_especial = false
			for(var i in especiales) {
				if(key == especiales[i]) {
					tecla_especial = true;
					break;
				}
			}

			if(numeros.indexOf(tecla) == -1 && !tecla_especial)
				return false;
		}

		function limpiaNumeros() {
			var val = document.getElementById(""numeros"").value;
			var tam = val.length;
			for(i = 0; i < tam; i++) {
				if(!isNaN(val[i]))
					document.getElementById(""numeros"").value = '';
			}
		}

	</script>
");
                EndContext();
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
            EndContext();
            BeginContext(1876, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1878, 1144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d63230e7859d47dcba4aefa0f7b876b4", async() => {
                BeginContext(1884, 91, true);
                WriteLiteral("\r\n\t<main class=\"login\">\r\n\t\t<div class=\"contenedor\">\r\n\t\t\t<div class=\"form_contenedor\">\r\n\t\t\t\t");
                EndContext();
                BeginContext(1975, 1007, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60f43d99fb99487291b06fa472adfbbf", async() => {
                    BeginContext(2008, 967, true);
                    WriteLiteral(@"
					<div class=""barra_menu_desplegar"" id=""barra_menu_desplegar"">
						<h2>Iniciar Sesión</h2>
						<div class=""cont_form"">
							<div class=""cont_row"">
								<label for="""" class=""lbl_form"">DNI:</label><input type=""number"" onkeypress=""return soloNumeros(event)"" onblur=""limpiaNumeros()"" id=""numeros"" maxlength=""8"" oninput=""if(this.value.length > this.maxLength) this.value = this.value.slice(0,this.maxLength);"" name=""txtOrden"" placeholder=""DNI"" autofocus="""">
							</div>
							<div class=""cont_row"">
								<label for="""" class=""lbl_form"">Contraseña:</label><input type=""password"" name=""txtContra"" placeholder=""Contraseña"">
							</div>
							<div class=""cont_btns_form"">
								<input type=""submit"" name=""btnIniciarSesion"" value=""Ingresar"" class=""btnRegistrar"">
							</div>
							<div class=""btn_login"">
								<p>¿Aún no tienes una cuenta?</p><a href=""crear-cuenta.jsp"">Crear cuenta</a>
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2982, 33, true);
                WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</main>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3022, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
