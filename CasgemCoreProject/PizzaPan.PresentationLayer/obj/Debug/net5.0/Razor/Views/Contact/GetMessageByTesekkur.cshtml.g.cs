#pragma checksum "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d53a411c1b7926493f46c8622aa011bdfd4843"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_GetMessageByTesekkur), @"mvc.1.0.view", @"/Views/Contact/GetMessageByTesekkur.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d53a411c1b7926493f46c8622aa011bdfd4843", @"/Views/Contact/GetMessageByTesekkur.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca747c36566c645837262d48badbe8d71cdcab79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contact_GetMessageByTesekkur : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
  
    ViewData["Title"] = "GetMessageByTesekkur";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
   int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Teşekkür Mesajları</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Gönderen</th>\r\n        <th>Konu</th>\r\n        <th>Tarih</th>\r\n        <th>Sİl</th>\r\n        <th>Mesajı Gör</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
            Write(((DateTime)item.SendDateMessage).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 657, "\"", 702, 2);
            WriteAttributeValue("", 664, "/Contact/DeleteContact/", 664, 23, true);
#nullable restore
#line 27 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
WriteAttributeValue("", 687, item.ContactID, 687, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sİl</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 767, "\"", 820, 2);
            WriteAttributeValue("", 774, "/Contact/MessageDetailsContact/", 774, 31, true);
#nullable restore
#line 28 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
WriteAttributeValue("", 805, item.ContactID, 805, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Mesaj Detayları</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\Contact\GetMessageByTesekkur.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
