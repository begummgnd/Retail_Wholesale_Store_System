#pragma checksum "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fd77777dca9476ee2e6366e3a650e69cda1b258"
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
#line 1 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\_ViewImports.cshtml"
using BakkalUygulamasi.webui;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fd77777dca9476ee2e6366e3a650e69cda1b258", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e45005215c93f1c8b48dbc1603caebd9c8a573", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\BGM\source\repos\BakkalUygulamasi\BakkalUygulamasi.webui\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6fd77777dca9476ee2e6366e3a650e69cda1b2583885", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""text-center mt-2"">
    <h6 class=""display-5"">Hoş Geldiniz</h6>
</div>

<html class=""index"">
<div class=""container mt-4"" style=""text-align:center"">

    <div class=""btn-group "" style="" margin-top: 100px; height:70px"">
        <button type=""button"" class=""btn btn-success"">Hesap İşlemleri</button>
        <button type=""button"" class=""btn btn-success dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"">
        </button>
        <div class=""dropdown-menu"">
            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" style=""text-align:center"" data-toggle=""dropdown"">
                Kullanıcı İşlemleri
            </button>

            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item "" href=""/hesap/kullanıcı/ekle"">Yeni Kullanıcı Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/hesap/kullanıcı/liste"">Kullanıcı Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
        
            </div>");
            WriteLiteral(@"

            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split "" style=""text-align:center"" data-toggle=""dropdown"">
                Rol İşlemleri
            </button>

            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item"" href=""/hesap/rol/ekle"">Yeni Rol Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/hesap/rol/liste"">Rol Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
   
            </div>
        </div>
    </div>
    <div class=""btn-group"" style=""margin-top:100px; height:70px"">
        <button type=""button"" class=""btn btn-danger"">Personel İşlemleri</button>
        <button type=""button"" class=""btn btn-danger dropdown-toggle dropdown-toggle-split"" data-toggle=""dropdown"">
        </button>
        <div class=""dropdown-menu"">
            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" style=""text-align:center"" data-toggle=""dropdown"">
                Kategori İş");
            WriteLiteral(@"lemleri
            </button>
            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item "" href=""/personel/kategori/ekle"">Yeni Kategori Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/personel/kategori/liste"">Kategori Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
        
            </div>
            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" style=""text-align:center"" data-toggle=""dropdown"">
                Ürün İşlemleri
            </button>
            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item "" href=""/personel/urun/ekle"">Yeni Ürün Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/personel/urun/liste"">Ürün Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
           
            </div>
            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" style=""text-align:center"" data-toggle=""dropdown"">
    ");
            WriteLiteral(@"            Marka İşlemleri
            </button>
            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item "" href=""/personel/marka/ekle"">Yeni Marka Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/personel/marka/liste"">Marka Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
           
            </div>
            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" style=""text-align:center"" data-toggle=""dropdown"">
                Stok İşlemleri
            </button>
            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item "" href=""/personel/stok/ekle"">Yeni Stok Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/personel/stok/liste"">Stok Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
    
            </div>
            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" style=""text-align:center"" data-toggle=""dropdown"">
");
            WriteLiteral(@"                Satış İşlemleri
            </button>
            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item "" href=""/personel/satis/ekle"">Yeni Satış Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/personel/satis/liste"">Satış Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
         
            </div>
            <button type=""button"" class=""btn btn-warning dropdown-toggle dropdown-toggle-split"" style=""text-align:center"" data-toggle=""dropdown"">
                Satış Maddeleri İşlemleri
            </button>
            <div class=""dropdown-item"">
                <a class=""bg-light dropdown-item "" href=""/personel/satismaddeleri/ekle"">Yeni Satış Maddeleri Ekle</a>
                <a class=""bg-light dropdown-item"" href=""/personel/satismaddeleri/liste"">Satış Maddeleri Listesi (Güncelleme ve Silme İşlemleri İçin Seçiniz)</a>
         
            </div>
        </div>
    </div>


</div>

</html>
");
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
