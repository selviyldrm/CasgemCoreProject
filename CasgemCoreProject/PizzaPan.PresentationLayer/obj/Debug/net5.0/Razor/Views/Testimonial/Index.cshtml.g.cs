#pragma checksum "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "607529084b6243f9e155c0fb181468d18b7dc0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_Index), @"mvc.1.0.view", @"/Views/Testimonial/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"607529084b6243f9e155c0fb181468d18b7dc0d5", @"/Views/Testimonial/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca747c36566c645837262d48badbe8d71cdcab79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Testimonial_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaPan.EntityLayer.Concrete.Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Referans Listesi</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Adı</th>\r\n        <th>Başlık</th>\r\n        <th>Yorum</th>\r\n        <th>Resim</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
           Write(item.TestimonialID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
           Write(item.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
           Write(item.CustomerTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
           Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 639, "\"", 659, 1);
#nullable restore
#line 26 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 645, item.ImageUrl, 645, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 711, "\"", 768, 2);
            WriteAttributeValue("", 718, "/Testimonial/DeleteTestimonial/", 718, 31, true);
#nullable restore
#line 27 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 749, item.TestimonialID, 749, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 833, "\"", 890, 2);
            WriteAttributeValue("", 840, "/Testimonial/UpdateTestimonial/", 840, 31, true);
#nullable restore
#line 28 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
WriteAttributeValue("", 871, item.TestimonialID, 871, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Testimonial\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Testimonial/AddTestimonial/\" class=\"btn btn-info\">Yeni Referans Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaPan.EntityLayer.Concrete.Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591