#pragma checksum "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c685a7a0a6e81987e513ba2dc5e816c1b252c425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StationList), @"mvc.1.0.view", @"/Views/Home/StationList.cshtml")]
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
#line 1 "C:\Users\amosm\source\repos\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amosm\source\repos\MvcMovie\Views\_ViewImports.cshtml"
using MvcMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c685a7a0a6e81987e513ba2dc5e816c1b252c425", @"/Views/Home/StationList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"686ad2e38abb871af45be971520cc6c3156da389", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StationList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MvcMovie.Models.Station>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml"
  
    ViewData["Title"] = "StationList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c685a7a0a6e81987e513ba2dc5e816c1b252c4253426", async() => {
                WriteLiteral(@"
    <script>
         $('.btn-click').click(function() {
    $(""body"").css(""background"",""#AFD629"");
})
        // These condition will change the body background color when toggle button clicked
        $('#btn-toggle').click(function () {
            $(""body"").toggleClass(""second-color"");
        })
    </script>
    <style>
        body {
            background: #EEA011;
            transition: background 1s ease 0s;
        }

        button {
            background: rgba(255,255,255,0.3);
            border-radius: 10px;
            border: 1px solid #FFF;
            padding: 10px;
            color: #ffffff;
            cursor: pointer;
            font-weight: bold;
            margin: 1px;
            box-shadow: 2px 2px 2px rgba(0,0,0,0.3);
            text-shadow: 1px 1px 1px rgba(0,0,0,0.3)
        }

        .second-color {
            background: #AFD629 !important;
        }
    </style>
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c685a7a0a6e81987e513ba2dc5e816c1b252c4255356", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Liste des stations</h1>

        <div>

            <div>
                <table class=""table"">
                    <thead>
                        <tr>
                            <th scope=""col"">#</th>
                            <th scope=""col"">Vélos disponibles</th>
                            <th scope=""col"">Adresse</th>
                            <th scope=""col"">Commune</th>
                            <th scope=""col"">Code postal</th>
                            <th scope=""col"">Favoris</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 61 "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml"
                         foreach (var bike in Model)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <th scope=\"row\"></th>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml"
                           Write(bike.available_bikes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml"
                           Write(bike.address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml"
                           Write(bike.commune);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 69 "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml"
                           Write(bike.code_insee);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td><button id=\"btn-toggle\">Ajouter</button></td>\r\n                        </tr>\r\n");
#nullable restore
#line 72 "C:\Users\amosm\source\repos\MvcMovie\Views\Home\StationList.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n    ");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MvcMovie.Models.Station>> Html { get; private set; }
    }
}
#pragma warning restore 1591
