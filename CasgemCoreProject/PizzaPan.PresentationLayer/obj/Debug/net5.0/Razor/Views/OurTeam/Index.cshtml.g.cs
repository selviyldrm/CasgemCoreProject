#pragma checksum "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32b4bc11e46b7f98d49e0a3258e8338b34ae7a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OurTeam_Index), @"mvc.1.0.view", @"/Views/OurTeam/Index.cshtml")]
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
#line 1 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\_ViewImports.cshtml"
using PizzaPan.PresentationLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\_ViewImports.cshtml"
using PizzaPan.PresentationLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\_ViewImports.cshtml"
using PizzaPan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b4bc11e46b7f98d49e0a3258e8338b34ae7a03", @"/Views/OurTeam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca747c36566c645837262d48badbe8d71cdcab79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_OurTeam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OurTeam>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Takım Listemiz</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Ad Soyad</th>\r\n        <th>Başlık</th>\r\n        <th>Resim</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 21 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
   Write(item.OurTeamID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
              Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><img");
            BeginWriteAttribute("src", " src=\"", 502, "\"", 522, 1);
#nullable restore
#line 24 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
WriteAttributeValue("", 508, item.ImageUrl, 508, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /> </td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 567, "\"", 612, 2);
            WriteAttributeValue("", 574, "/OurTeam/DeleteOurTeam/", 574, 23, true);
#nullable restore
#line 25 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
WriteAttributeValue("", 597, item.OurTeamID, 597, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 661, "\"", 706, 2);
            WriteAttributeValue("", 668, "/OurTeam/UpdateOurTeam/", 668, 23, true);
#nullable restore
#line 26 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
WriteAttributeValue("", 691, item.OurTeamID, 691, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n</tr>\r\n");
#nullable restore
#line 28 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\OurTeam\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/OurTeam/AddOurTeam/\" class=\"btn btn-dark\">Yeni Takım Üyesi Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OurTeam>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
