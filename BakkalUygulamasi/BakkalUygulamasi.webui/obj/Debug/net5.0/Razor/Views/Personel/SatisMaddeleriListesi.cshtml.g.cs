#pragma checksum "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e2c207a303f9492cb1eed22d63b65d988c3af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personel_SatisMaddeleriListesi), @"mvc.1.0.view", @"/Views/Personel/SatisMaddeleriListesi.cshtml")]
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
#line 1 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\_ViewImports.cshtml"
using BakkalUygulamasi.webui;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e2c207a303f9492cb1eed22d63b65d988c3af5", @"/Views/Personel/SatisMaddeleriListesi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e45005215c93f1c8b48dbc1603caebd9c8a573", @"/Views/_ViewImports.cshtml")]
    public class Views_Personel_SatisMaddeleriListesi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BakkalUygulamasi.entity.Data.SatisMaddeleri>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/personel/satismaddelerisil"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/personel/fatura/yazdir"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""w-100"">
    <div class=""row"">
        <div class=""com-md-12"">
            <h1 class=""h3"">Satış Maddeleri Listesi</h1>
            <hr />
            <a class=""btn btn-primary btn-sm"" href=""/personel/satismaddeleri/ekle"">Satış Maddeleri Ekle</a>
            <table class=""table table-bordered mt-3"">
                <thead>
                    <tr>
                        <td style=""width:70px;"">Id</td>
                        <td style=""width:170px"">Miktar</td>
                        <td style=""width:170px;"">Fiyat</td>
                        <td style=""width:170px;"">İskonto</td>
                        <td style=""width:170px;"">Satış Id</td>
                        <td style=""width:170px;"">Ürün Id</td>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 21 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                       Write(item.SmId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                       Write(item.SiMiktar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                       Write(item.SiFiyat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                       Write(item.SiIskonto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                       Write(item.SatisId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                       Write(item.UrunId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1322, "\"", 1373, 2);
            WriteAttributeValue("", 1329, "/personel/satismaddeleri/guncelle/", 1329, 34, true);
#nullable restore
#line 31 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
WriteAttributeValue("", 1363, item.SmId, 1363, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm mr-2\">Düzenle</a>\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e2c207a303f9492cb1eed22d63b65d988c3af58208", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"smId\"");
                BeginWriteAttribute("value", " value=\"", 1600, "\"", 1618, 1);
#nullable restore
#line 34 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
WriteAttributeValue("", 1608, item.SmId, 1608, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e2c207a303f9492cb1eed22d63b65d988c3af510445", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"UrunId\"");
                BeginWriteAttribute("value", " value=\"", 1931, "\"", 1951, 1);
#nullable restore
#line 38 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
WriteAttributeValue("", 1939, item.UrunId, 1939, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"SatisId\"");
                BeginWriteAttribute("value", " value=\"", 2024, "\"", 2045, 1);
#nullable restore
#line 39 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
WriteAttributeValue("", 2032, item.SatisId, 2032, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"SmId\"");
                BeginWriteAttribute("value", " value=\"", 2115, "\"", 2133, 1);
#nullable restore
#line 40 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
WriteAttributeValue("", 2123, item.SmId, 2123, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                                <button type=\"submit\" class=\"btn btn-success btn-sm\">Fatura Yazdır</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 46 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Personel\SatisMaddeleriListesi.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BakkalUygulamasi.entity.Data.SatisMaddeleri>> Html { get; private set; }
    }
}
#pragma warning restore 1591