#pragma checksum "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d9066a0b0997a689266755b7263df39f87e8a93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Search_Filter), @"mvc.1.0.view", @"/Views/Client/Search_Filter.cshtml")]
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
#line 1 "D:\Framework\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Framework\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d9066a0b0997a689266755b7263df39f87e8a93", @"/Views/Client/Search_Filter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Search_Filter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9066a0b0997a689266755b7263df39f87e8a936392", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9066a0b0997a689266755b7263df39f87e8a937853", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9066a0b0997a689266755b7263df39f87e8a939031", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9066a0b0997a689266755b7263df39f87e8a9310209", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d9066a0b0997a689266755b7263df39f87e8a9311388", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9066a0b0997a689266755b7263df39f87e8a9313661", async() => {
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
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"">Giả tưởng</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Ngôn tình"">Ngôn tình</a>
                                </li>
                                <li class=""category-item"">
                                    <a hr");
                WriteLiteral(@"ef=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Huyền bí"">Huyền bí</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Kinh dị"">Kinh dị</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Tâm linh"">Tâm linh</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Khoa học viễn tưởng"">Khoa học viễn tưởng</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""s");
                WriteLiteral(@"ubmit"" class=""category-item__link"" value=""Du ký"">Du ký</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Tuổi teen"">Tuổi teen</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Thơ ca, ca dao"">Thơ ca, ca dao</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Phát triển bản thân"">Phát triển bản thân</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-ite");
                WriteLiteral(@"m__link"" value=""Động lực"">Động lực</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Tác phẩm kinh điển"">Tác phẩm kinh điển</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Du lịch"">Du lịch</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Hài hước"">Hài hước</a>
                                </li>
                                <li class=""category-item"">
                                    <a href=""/Client/Search_Category"" type=""submit"" class=""category-item__link"" value=""Sách thiếu nhi"">Sách t");
                WriteLiteral(@"hiếu nhi</a>
                                </li>

                            </ul>
                        </nav>

                        <div class=""card"" style=""margin-top: -2px ;"">
                            <article class=""card-group-item"">
                                <header class=""card-header"">
                                    <h6 class=""title"">Giá </h6>
                                </header>
                                <div class=""filter-content"">
                                    <div class=""card-body"">

                                        <label class=""form-check giaban_ft"">
                                            <input name=""giaban""
                                                   class=""form-check-input""
                                                   type=""radio""
                                                   value=""50000"" />
                                            <span class=""form-check-label"">
                                       ");
                WriteLiteral(@"         Dưới 50.000
                                            </span>
                                        </label>
                                        <!-- form-check.// -->
                                        <label class=""form-check giaban_ft"">
                                            <input name=""giaban""
                                                   class=""form-check-input""
                                                   type=""radio""
                                                   value=""100000"" />
                                            <span class=""form-check-label"">
                                                50.000 - 100.000
                                            </span>
                                        </label>
                                        <!-- form-check.// -->
                                        <label class=""form-check giaban_ft"">
                                            <input class=""form-check-input""
              ");
                WriteLiteral(@"                                     type=""radio""
                                                   value=""150000"" />
                                            <span class=""form-check-label"">
                                                100.000 - 150.000
                                            </span>
                                        </label>
                                        <!-- form-check.// -->
                                        <label class=""form-check giaban_ft"">
                                            <input class=""form-check-input""
                                                   type=""radio""
                                                   value=""200000"" />
                                            <span class=""form-check-label"">
                                                150.000 - 200.000
                                            </span>
                                        </label>
                                        <!-- form-check");
                WriteLiteral(@".// -->
                                        <label class=""form-check giaban_ft"">
                                            <input class=""form-check-input""
                                                   type=""radio""
                                                   value=""200001"" />
                                            <span class=""form-check-label"">
                                                Trên 200.000
                                            </span>
                                        </label>
                                        <!-- form-check.// -->


                                    </div>
                                    <!-- card-body.// -->
                                </div>
                            </article>

                            <article class=""card-group-item"">
                                <header class=""card-header"">
                                    <h6 class=""title"">Ngôn ngữ sách </h6>
                              ");
                WriteLiteral(@"  </header>
                                <div class=""filter-content"">
                                    <div class=""card-body"">

                                        <label class=""form-check ngonngu"">
                                            <input class=""form-check-input""
                                                   type=""checkbox""
                                                   value=""Tiếng Anh"" />
                                            <span class=""form-check-label"">
                                                Tiếng Anh
                                            </span>
                                        </label>
                                        <!-- form-check.// -->
                                        <label class=""form-check ngonngu"">
                                            <input class=""form-check-input""
                                                   type=""checkbox""
                                                   value=""Tiếng Việt");
                WriteLiteral(@""" />
                                            <span class=""form-check-label"">
                                                Tiếng Việt
                                            </span>
                                        </label>

                                    </div>
                                    <!-- card-body.// -->
                                </div>
                            </article>

                            <article class=""card-group-item"">
                                <header class=""card-header"">
                                    <h6 class=""title"">Nhà xuất bản </h6>
                                </header>
                                <div class=""filter-content"">
                                    <div class=""card-body"">

                                        <label class=""form-check nhaxuatban"">
                                            <input class=""form-check-input""
                                                   type=""checkbox""
");
                WriteLiteral(@"                                                   value=""NXB Trẻ"" />
                                            <span class=""form-check-label"">
                                                NXB Trẻ
                                            </span>
                                        </label>
                                        <label class=""form-check nhaxuatban"">
                                            <input class=""form-check-input""
                                                   type=""checkbox""
                                                   value=""NXB Kim Đồng"" />
                                            <span class=""form-check-label"">
                                                NXB Kim Đồng
                                            </span>
                                        </label>
                                        <label class=""form-check nhaxuatban"">
                                            <input class=""form-check-input""
                  ");
                WriteLiteral(@"                                 type=""checkbox""
                                                   value=""NXB Giáo dục"" />
                                            <span class=""form-check-label"">
                                                NXB Giáo dục
                                            </span>
                                        </label>

                                        <label class=""form-check nhaxuatban"">
                                            <input class=""form-check-input""
                                                   type=""checkbox""
                                                   value=""NXB Văn Học"" />
                                            <span class=""form-check-label"">
                                                NXB Văn Học
                                            </span>
                                        </label>

                                    </div>
                                </div>
                            ");
                WriteLiteral("</article>\r\n\r\n                        </div>\r\n\r\n                        <a class=\"timkiem_z\" style=\"text-decoration:none\">\r\n                            <button id=\"btn-timkiem-boloc\"\r\n                                    ");
                WriteLiteral(@"                                    class=""btn btn-primary""
                                    style=""width: 188px; margin-top: 4px; padding: -4px 0px"">
                                Tìm kiếm
                            </button>
                        </a>

                    </div>
                    <div class=""grid__column-10"" style=""margin-top: -10px"">
                        <div class=""home-product"">
                            <!-- Grid -> row -> column -->
                            <div class=""grid__row"">
                                <!-- Product item -->
");
#nullable restore
#line 246 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
                                 foreach (Book item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"grid__column-2-4\">\r\n\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d9066a0b0997a689266755b7263df39f87e8a9328236", async() => {
                    WriteLiteral("\r\n                                            <div class=\"home-product-item__img\"");
                    BeginWriteAttribute("style", "\r\n                                                 style=\"", 15427, "\"", 15522, 4);
                    WriteAttributeValue("", 15485, "background-image:", 15485, 17, true);
                    WriteAttributeValue(" ", 15502, "url(", 15503, 5, true);
#nullable restore
#line 252 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
WriteAttributeValue("", 15507, item.Hinhanh, 15507, 13, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 15520, ");", 15520, 2, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                            </div>\r\n                                            <h4 class=\"home-product-item__name\">\r\n                                                ");
#nullable restore
#line 255 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
                                           Write(item.Tensach);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                                            </h4>\r\n                                            <div class=\"home-product-item__price\">\r\n                                                <span class=\"home-product-item__price-old\">");
#nullable restore
#line 258 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
                                                                                      Write(item.Giagoc);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</span>\r\n                                                <span class=\"home-product-item__price-current\">");
#nullable restore
#line 259 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
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
#line 279 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
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
#line 250 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
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
#line 286 "D:\Framework\WebApplication\WebApplication\Views\Client\Search_Filter.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </div>


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script>
        var list = document.querySelectorAll('.category-item__link');
        Array.prototype.forEach.call(list, function (element, index) {
            var value = element.innerHTML;
            element.href = ""/Client/Search_Category?cate="" + value;
        });
    </script>

    <script>
        $(document).ready(function () {
            console.log('Hello')
            var giaban_send = '';
            var ngonngu_send = '';
            var nxb_send = '';

            var giaban = $('.giaban_ft')
            var ngonngu = $('.ngonngu');
            var nhaxuatban = $('.nhaxuatban');

            console.log(giaban)
            console.log(ngonngu)
            console.log(nhaxuatban)

            $('.timkiem_z').on('click', function () {
                console.log(""Hello"")

                giaba");
                WriteLiteral(@"n.each(function () {
                    if ($(this).find('.form-check-input').prop('checked') === true) {
                        giaban_send = $(this).find('.form-check-input').val()
                    }
                })

                ngonngu.each(function () {
                    if ($(this).find('.form-check-input').prop('checked') === true) {
                        if (ngonngu_send === '') {
                            ngonngu_send += $(this).find('.form-check-input').val()
                        }
                        else {
                            ngonngu_send += (""$$"" + $(this).find('.form-check-input').val())
                        }
                    }
                })

                nhaxuatban.each(function () {
                    if ($(this).find('.form-check-input').prop('checked') === true) {
                        if (nxb_send === '') {
                            nxb_send += $(this).find('.form-check-input').val()
                        }
        ");
                WriteLiteral(@"                else {
                            nxb_send += (""$$"" + $(this).find('.form-check-input').val())
                        }
                    }
                })

                $('.timkiem_z').attr(""href"", '/Client/Search_Filter?giaban=' + giaban_send + '&ngonngu=' + ngonngu_send + '&nhaxuatban=' + nxb_send)

            })
        })

    </script>

");
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
