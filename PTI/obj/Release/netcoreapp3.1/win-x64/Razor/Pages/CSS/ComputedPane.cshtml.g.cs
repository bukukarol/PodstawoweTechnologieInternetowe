#pragma checksum "C:\dev\PTIProject\PTI\Pages\CSS\ComputedPane.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4524d8ed9a15e44be4b2a1e97e24de81046f94d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PodstawoweTechnologieInternetowe.Pages.CSS.Pages_CSS_ComputedPane), @"mvc.1.0.razor-page", @"/Pages/CSS/ComputedPane.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4524d8ed9a15e44be4b2a1e97e24de81046f94d7", @"/Pages/CSS/ComputedPane.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"293cd21bb9e01a564d0a235dc07f0374333f91f1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CSS_ComputedPane : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\dev\PTIProject\PTI\Pages\CSS\ComputedPane.cshtml"
  
    ViewData["Title"] = "ComputedPane";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Panel Computed</h3>

<ul>
    <li>Wybierz element w drzewku DOM</li>
    <li>W panelu <b>Computed</b> </li>
    <li>Opcja filtrowania</li>
    <li>Nawiguj do stylu</li>
</ul>
<p>Panel <b>Computed</b> przedstawia już ""przeliczone"" style, których rezultatem jest to co widzimy na ekranie</p>
<p>Dzięki opcji filtrowania oraz szybkich linków jesteśmy w stanie szybciej odnaleźć plik CSS, deklarację styli która obecnie wpływa na nasz element DOM.</p>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PodstawoweTechnologieInternetowe.Pages.CSS.ComputedPaneModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PodstawoweTechnologieInternetowe.Pages.CSS.ComputedPaneModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PodstawoweTechnologieInternetowe.Pages.CSS.ComputedPaneModel>)PageContext?.ViewData;
        public PodstawoweTechnologieInternetowe.Pages.CSS.ComputedPaneModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
