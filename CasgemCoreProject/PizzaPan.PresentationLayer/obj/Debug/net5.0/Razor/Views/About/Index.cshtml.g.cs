#pragma checksum "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "121853e2c25d44c782a5a4651b0b2bddf1c0db3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"121853e2c25d44c782a5a4651b0b2bddf1c0db3d", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca747c36566c645837262d48badbe8d71cdcab79", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pizzapan-starter/assets/images/pizza.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pizzapan-starter/assets/images/burger.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pizzapan-starter/assets/images/fries.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/pizzapan-starter/assets/images/drink.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n\r\n");
#nullable restore
#line 9 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("_HeadPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d5995", async() => {
                WriteLiteral("\r\n    <!--header-->\r\n    ");
#nullable restore
#line 13 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("_NavbarPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--/header-->\r\n    <!-- Domain Modal -->\r\n    ");
#nullable restore
#line 16 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("_ModalPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- //Domain modal -->
    <section class=""w3l-breadcrumb"">
        <div class=""container"">
            <ul class=""breadcrumbs-custom-path"">
                <li><a href=""#url"">Ana Sayfa</a></li>
                <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Hakkımızda</li>
            </ul>
        </div>
    </section>
    <!--  Intro video popup section -->
    <section class=""w3l-about1 py-5"" id=""intro"">
        <div class=""new-block top-bottom py-lg-5 py-md-4"">
            <div class=""container"">
                <div class=""title-content text-center"">
                    <h6 class=""sub-title"">Biz Kimiz</h6>
                    <h3 class=""title-big"">Hakkımızda</h3>
                </div>
                <div class=""row mt-lg-5 mt-4"">
                    <div class=""col-md-3 left-section"">
                    </div>
                    <div class=""col-md-6 middle-section text-center align-self"">
                        <div class=""section-width");
                WriteLiteral(@" mb-lg-4 py-4"">
                            <h2>Tüm dünyadan en iyi Pizza ve burger fikirleri ve gelenekleri</h2>
                            <p class=""mt-4"">
                                Tüm dünyadan en iyi pizza ve burgerleri en iyi ve usta şeflerimizin sunumuyla hizmetinizdeyiz
                            </p>
                        </div>
                        <a href=""#small-dialog"" class=""popup-with-zoom-anim play-view text-center"">
                            <span class=""video-play-icon"">
                                <span class=""fa fa-play""></span>
                            </span>
                        </a>

                        <!-- dialog itself, mfp-hide class is required to make dialog hidden -->
                        <div id=""small-dialog"" class=""zoom-anim-dialog mfp-hide"">
                            <iframe width=""560"" height=""315"" src=""https://www.youtube.com/embed/TdTq7eg1ITI"" title=""YouTube video player"" frameborder=""0"" allow=""accelerometer; autoplay; clipbo");
                WriteLiteral(@"ard-write; encrypted-media; gyroscope; picture-in-picture; web-share"" allowfullscreen></iframe>
                        </div>
                    </div>
                    <div class=""col-md-3 right-section mt-md-0 mt-4"">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--  //Intro video popup section -->
    <!--  form-12 -->
    <section class=""w3l-form-12"">
        <div class=""form-12-content py-5"" id=""services"">
            <div class=""container py-lg-5 py-md-4"">
                <div class=""row"">
                    <div class=""col-lg-4 column1 align-self"">
                        <h4>Şehrinizdeki En İyi Pizza ve Burgerleri Yapıyoruz</h4>
                        <p>
                            Lorem ipsum dolor sit amet consectetur adipisicing elit. Eligendi suscipit hic, aut aperiam alias
                            corporis. Lorem ipsum dolor sit amet, elit. Quasi?
                        </p>
                    </div>
    ");
                WriteLiteral(@"                <div class=""col-lg-8 column2 mt-lg-0 mt-sm-5 mt-4"">
                        <div class=""row"">
                            <div class=""col-md-3 col-sm-6 col-6"">
                                <a href=""services.html"">
                                    <div class=""courses-item"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d10482", async() => {
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
                                        <p>Pizza</p>
                                    </div>
                                </a>
                            </div>
                            <div class=""col-md-3 col-sm-6 col-6"">
                                <a href=""services.html"">
                                    <div class=""courses-item"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d12063", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        <p>Burger</p>
                                    </div>
                                </a>
                            </div>
                            <div class=""col-md-3 col-sm-6 col-6 mt-md-0 mt-sm-4 mt-3"">
                                <a href=""services.html"">
                                    <div class=""courses-item"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d13666", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        <p>Patates Kızartması</p>
                                    </div>
                                </a>
                            </div>
                            <div class=""col-md-3 col-sm-6 col-6 mt-md-0 mt-sm-4 mt-3"">
                                <a href=""services.html"">
                                    <div class=""courses-item"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d15281", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        <p>Soğuk İçecek</p>
                                    </div>
                                </a>
                            </div>
                            <div class=""col-md-3 col-sm-6 col-6 mt-sm-4 mt-3"">
                                <a href=""services.html"">
                                    <div class=""courses-item mt-2"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d16887", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        <p>Füme burger</p>
                                    </div>
                                </a>
                            </div>
                            <div class=""col-md-3 col-sm-6 col-6 mt-sm-4 mt-3"">
                                <a href=""services.html"">
                                    <div class=""courses-item mt-2"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d18492", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        <p>Mozzarella</p>
                                    </div>
                                </a>
                            </div>
                            <div class=""col-md-3 col-sm-6 col-6 mt-sm-4 mt-3"">
                                <a href=""services.html"">
                                    <div class=""courses-item mt-2"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d20096", async() => {
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
                                        <p>Pizza</p>
                                    </div>
                                </a>
                            </div>
                            <div class=""col-md-3 col-sm-6 col-6 mt-sm-4 mt-3"">
                                <a href=""services.html"">
                                    <div class=""courses-item mt-2"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d21695", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        <p>Sandeviç</p>
                                    </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- // form-12 -->
    <!-- team -->
    ");
#nullable restore
#line 148 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("_OurTeamPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n    <!-- //team -->\r\n    <!-- stats -->\r\n    ");
#nullable restore
#line 151 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("_StatisticPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" 
    <!-- //stats -->
    <!-- features -->
    <section class=""w3l-reasons py-5"">
        <div class=""main-w3 py-lg-5 py-md-4"">
            <div class=""container"">
                <div class=""title-content text-center"">
                    <h6 class=""sub-title"">Biz En İyisiyiz</h6>
                    <h3 class=""title-big"">Bizi seçmek için 4 neden</h3>
                </div>
                <div class=""row main-cont-wthree-fea mt-5 text-center"">
                    <div class=""col-lg-3 col-sm-6 grids-feature"">
                        <a href=""#url"" class=""icon"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d24429", async() => {
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
                WriteLiteral(@"</a>
                        <h4><a href=""#feature"" class=""title-head"">Lezzetli Pizza</a></h4>
                        <p>Sıcak ve lezzetli pizzalar hazırlıyoruz.</p>
                    </div>
                    <div class=""col-lg-3 col-sm-6 grids-feature mt-sm-0 mt-5"">
                        <a href=""#url"" class=""icon"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d25941", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
                        <h4><a href=""#feature"" class=""title-head"">Kaliteli ürünler</a></h4>
                        <p>En kaliteli ürünlerle mşterilerimiz lezzetli pizzalar sunuyoruz.</p>
                    </div>
                    <div class=""col-lg-3 col-sm-6 grids-feature mt-lg-0 mt-sm-5 mt-5"">
                        <a href=""#url"" class=""icon"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d27487", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
                        <h4><a href=""#feature"" class=""title-head"">Dünyanın en iyi şefi</h4>
                        <p>Dünyanın en iyi şefieri ile çalışarak lezzeli pizzalar sunuyoruz.</p>
                    </div>
                    <div class=""col-lg-3 col-sm-6 grids-feature mt-lg-0 mt-sm-5 mt-5"">
                        <a href=""#url"" class=""icon"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "121853e2c25d44c782a5a4651b0b2bddf1c0db3d29034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</a>
                        <h4><a href=""#feature"" class=""title-head"">en hızlı teslimat</a></h4>
                        <p>En kısa sürede kapına teslimat.</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- //features -->
    <!-- footers 20 -->
    ");
#nullable restore
#line 188 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
Write(await  Component.InvokeAsync("_FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n    <!-- move top -->\r\n    ");
#nullable restore
#line 190 "C:\Users\selvi\source\repos\CasgemCoreProject\PizzaPan.PresentationLayer\Views\About\Index.cshtml"
Write(await Component.InvokeAsync("_ScriptPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
