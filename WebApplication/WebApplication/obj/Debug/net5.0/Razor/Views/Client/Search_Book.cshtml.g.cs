#pragma checksum "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "929532166837719ac448f46e33ed111fdbe0659d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Search_Book), @"mvc.1.0.view", @"/Views/Client/Search_Book.cshtml")]
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
#line 1 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929532166837719ac448f46e33ed111fdbe0659d", @"/Views/Client/Search_Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Search_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/base.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/fonts/themify-icons/themify-icons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/fonts/fontawesome-free-5.15.4/fontawesome-free-5.15.4-web/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("home-product-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "chitietsach", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "929532166837719ac448f46e33ed111fdbe0659d6454", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>DaBook Shop</title>
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>DaBook Shop</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/normalize/8.0.1/normalize.min.css""
          integrity=""sha512-NhSC1YmyruXifcj/KFRWoC561YpHpc5Jtzgvbuzx5VozKpWvQ+4nXhPdFgmx8xqexRcpAglTj9sIBWINXa8x5w==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css""
          integrity=""sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l"" crossorigin=""anonymo");
                WriteLiteral("us\">\r\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/swiper@7/swiper-bundle.min.css\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "929532166837719ac448f46e33ed111fdbe0659d7915", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "929532166837719ac448f46e33ed111fdbe0659d9093", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "929532166837719ac448f46e33ed111fdbe0659d10271", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "929532166837719ac448f46e33ed111fdbe0659d11450", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link href=""https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,200;0,300;0,400;0,500;0,600;0,700;0,800;1,200;1,400&display=swap""
          rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/Swiper/4.3.3/css/swiper.min.css"">
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Swiper/4.3.3/js/swiper.min.js""></script>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "929532166837719ac448f46e33ed111fdbe0659d13723", async() => {
                WriteLiteral(@"
    <!-- container -->
    <div class=""app"">
        <!-- container -->
        <div class=""app__container"">
            <div class=""grid"">
                <div class=""grid__row app__content"">
                    <div class=""grid__column-2"">
                        <nav class=""category"">
                            <h3 class=""category__heading""> Danh mục</h3>

                            <ul class=""category-list"">
                                <li class=""category-item category-item--active"">
                                    <a");
                BeginWriteAttribute("href", " href=\"", 2458, "\"", 2465, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Giả tưởng</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2647, "\"", 2654, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Ngôn tình</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 2836, "\"", 2843, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Huyền bí</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3024, "\"", 3031, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Kinh dị</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3211, "\"", 3218, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Trinh thám</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3401, "\"", 3408, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Tâm linh</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3589, "\"", 3596, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Khoa học viễn tưởng</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3788, "\"", 3795, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Du ký</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 3973, "\"", 3980, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Nấu ăn</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4159, "\"", 4166, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Tuổi teen</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4348, "\"", 4355, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Nghệ thuật</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4538, "\"", 4545, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Phát triển bản thân</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4737, "\"", 4744, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Động lực</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 4925, "\"", 4932, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Sức khỏe</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 5113, "\"", 5120, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Lịch sử</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 5300, "\"", 5307, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Du lịch</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 5487, "\"", 5494, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Sách hướng dẫn</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 5681, "\"", 5688, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Gia đình và xã hội</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 5879, "\"", 5886, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"category-item__link\">Hài hước</a>\r\n                                </li>\r\n                                <li class=\"category-item\">\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 6067, "\"", 6074, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""category-item__link"">Sách thiếu nhi</a>
                                </li>

                            </ul>
                        </nav>

                       
                    </div>
                    <div class=""grid__column-10"" style=""margin-top: -10px"">
                        <div class=""home-product"">
                            <!-- Grid -> row -> column -->
                            <div class=""grid__row"">
                                <!-- Product item -->
");
#nullable restore
#line 114 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
                                 foreach (Book item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"grid__column-2-4\">\r\n\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "929532166837719ac448f46e33ed111fdbe0659d22185", async() => {
                    WriteLiteral("\r\n                                            <div class=\"home-product-item__img\"");
                    BeginWriteAttribute("style", "\r\n                                                 style=\"", 6982, "\"", 7077, 4);
                    WriteAttributeValue("", 7040, "background-image:", 7040, 17, true);
                    WriteAttributeValue(" ", 7057, "url(", 7058, 5, true);
#nullable restore
#line 120 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
WriteAttributeValue("", 7062, item.Hinhanh, 7062, 13, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 7075, ");", 7075, 2, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                            </div>\r\n                                            <h4 class=\"home-product-item__name\">\r\n                                                ");
#nullable restore
#line 123 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
                                           Write(item.Tensach);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </h4>\r\n                                            <div class=\"home-product-item__price\">\r\n                                                <span class=\"home-product-item__price-old\">");
#nullable restore
#line 126 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
                                                                                      Write(item.Giagoc);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n                                                <span class=\"home-product-item__price-current\">");
#nullable restore
#line 127 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
                                                                                          Write(item.Giaban);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@" đ</span>
                                            </div>
                                            <div class=""home-product-item__action"">
                                                <span class=""home-product-item__like home-product-item--liked"">
                                                    <i class=""home-product-item__like-icon-empty far fa-heart""></i>
                                                    <i class=""home-product-item__like-icon-fill fas fa-heart""></i>
                                                </span>
                                                <div class=""home-product-item__rating"">
                                                    <i class=""home-product-item__star--gold fas fa-star""></i>
                                                    <i class=""home-product-item__star--gold fas fa-star""></i>
                                                    <i class=""home-product-item__star--gold fas fa-star""></i>
                                                   ");
                    WriteLiteral(@" <i class=""home-product-item__star--gold fas fa-star""></i>
                                                    <i class=""fas fa-star""></i>
                                                </div>
                                                <span class=""home-product-item__sold"">57 đã bán</span>
                                                <div class=""home-product-item__favourite"">
                                                    <i class=""fas fa-check""></i>
                                                    <span>Yêu thích</span>
                                                </div>
                                                <div class=""home-product-item__sale-off"">
                                                    <span class=""home-product-item__sale-off-percent"">");
#nullable restore
#line 147 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
                                                                                                 Write(item.Giamgia);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"%</span>
                                                    <span class=""home-product-item__sale-off-label"">GIẢM</span>
                                                </div>
                                            </div>
                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 118 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
                                                                                                                          WriteLiteral(item.Tensach);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 154 "C:\Users\USER\Source\Repos\Framework\WebApplication\WebApplication\Views\Client\Search_Book.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n\r\n                           \r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    \r\n\r\n");
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
            WriteLiteral("\r\n\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
