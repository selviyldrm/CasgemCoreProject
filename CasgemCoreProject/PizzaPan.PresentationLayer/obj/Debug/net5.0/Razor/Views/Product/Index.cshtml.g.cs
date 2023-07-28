#pragma checksum "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4f8fa26042dbe2eb148835e2fb0d1ae426a5d4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4f8fa26042dbe2eb148835e2fb0d1ae426a5d4a", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca747c36566c645837262d48badbe8d71cdcab79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaPan.EntityLayer.Concrete.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ürün Listesi</h1>

<table class=""table table-bordered"">
   <tr>
       <th>Ürün Adı</th>
       <th>Ürün Açıklaması</th>
       <th>Ürün Resim</th>
       <th>Ürün Fiyat</th> 
       <th>Ürün Kategorisi</th>
       <th>Sil</th>
       <th>Güncelle</th>
   </tr>
");
#nullable restore
#line 19 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><img");
            BeginWriteAttribute("src", " src=\"", 578, "\"", 598, 1);
#nullable restore
#line 24 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
WriteAttributeValue("", 584, item.ImageUrl, 584, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" /></td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 734, "\"", 779, 2);
            WriteAttributeValue("", 741, "/Product/DeleteProduct/", 741, 23, true);
#nullable restore
#line 27 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
WriteAttributeValue("", 764, item.ProductID, 764, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 889, 2);
            WriteAttributeValue("", 851, "/Product/UpdateProduct/", 851, 23, true);
#nullable restore
#line 28 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
WriteAttributeValue("", 874, item.ProductID, 874, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Product/AddProduct/\" class=\"btn btn-dark\">Yeni Ürün Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaPan.EntityLayer.Concrete.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
