#pragma checksum "C:\dev\PTIProject\PTI\Pages\CSS\StylesPane.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894811decc034ca23a71a50800975475809f0849"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PodstawoweTechnologieInternetowe.Pages.CSS.Pages_CSS_StylesPane), @"mvc.1.0.razor-page", @"/Pages/CSS/StylesPane.cshtml")]
namespace PodstawoweTechnologieInternetowe.Pages.CSS
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
#line 1 "C:\dev\PTIProject\PTI\Pages\_ViewImports.cshtml"
using PodstawoweTechnologieInternetowe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894811decc034ca23a71a50800975475809f0849", @"/Pages/CSS/StylesPane.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293cd21bb9e01a564d0a235dc07f0374333f91f1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CSS_StylesPane : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\dev\PTIProject\PTI\Pages\CSS\StylesPane.cshtml"
  
    ViewData["Title"] = "StylesPane";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Panel Styli</h3>

<ul>
    <li>Wybierz element w drzewku DOM</li>
    <li>W panelu <b>Styles</b> możesz podejrzeć jego CSS</li>
    <li>Opcja filtrowania</li>
    <li>Zmień mu kolor!</li>
    <li>Autocomplete, prawie nic nie musisz pamiętać! italic?</li>
    <li>Podświetlanie elementów które są zmieniane</li>
    <li>Increment Shfit+UP / Shift+DOWN +-10px</li>
    <li>Pseudo klasy :hov</li>
    <li>Klasy też są (twoje klasy:P)</li>  
    <li>Contrast Ratio - zmień kolor czcionki (darktheme)</li>
    <li><a href=""https://css-tricks.com/snippets/css/css-triangle/"">Tutaj będzie trójkąt</a></li>

</ul>
<p>Panel <b>Styles</b> umożliwia podejrzenie styli CSS przypisanych do zaznaczonego elementu z drzewka DOM.</p>
<p> W tym miejscu również można eksperymentować dodając lub zmieniając już istniejące style.</p>

<div class=""colorBox theme-green"">
    <p>Inspect Me!</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PodstawoweTechnologieInternetowe.Pages.CSS.StylesPaneModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PodstawoweTechnologieInternetowe.Pages.CSS.StylesPaneModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PodstawoweTechnologieInternetowe.Pages.CSS.StylesPaneModel>)PageContext?.ViewData;
        public PodstawoweTechnologieInternetowe.Pages.CSS.StylesPaneModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
