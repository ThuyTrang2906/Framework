#pragma checksum "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37fbf86a13009046f45b9cc573cea245e4af8e6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_cart), @"mvc.1.0.view", @"/Views/Client/cart.cshtml")]
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
#line 1 "D:\Framework\Framework\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Framework\Framework\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37fbf86a13009046f45b9cc573cea245e4af8e6f", @"/Views/Client/cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cart.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart-logo-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Client/payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37fbf86a13009046f45b9cc573cea245e4af8e6f6086", async() => {
                WriteLiteral(@"
    <title>Document</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta2/css/all.min.css"" integrity=""sha512-YWzhKL2whUzgiheMoBFwW8CKV4qpHQAEuvilg9FAn5VJUDwKZZxkJNuGM4XkWuk94WCrrwslk8yWNGmY1EduTA=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37fbf86a13009046f45b9cc573cea245e4af8e6f6778", async() => {
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
                WriteLiteral("\r\n    <script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js\"></script>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37fbf86a13009046f45b9cc573cea245e4af8e6f8768", async() => {
                WriteLiteral(@"
    <div class=""cart__container grid"">
        <h1>Gi??? h??ng</h1>
        <div class=""cart transition is-open"">

            <div class=""table"">

                <div class=""layout-inline row th"">
                    <div class=""col-auto "">Ch???n</div>
                    <div class=""col-4 col-pro"">S???n ph???m</div>
                    <div class=""col col-price align-center "">
                        ????n gi??
                    </div>
                    <div class=""col-auto col-qty align-center"">S??? l?????ng</div>

                    <div class=""col"">Th??nh ti???n</div>
                    <div class=""col-auto col__bin""><i class=""far fa-trash-alt""></i></div>
                </div>


");
#nullable restore
#line 32 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                 foreach (var item in ViewBag.ListCart)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""san_pham layout-inline row"">
                        <div class=""col-auto col__checkbox"">
                            <input class=""checkbuy"" id=""input_loai"" name=""loai"" type=""checkbox"" value=""Web"" />
                        </div>
                        <div class=""col-4 col-pro layout-inline"">
                            <p class=""ma-sach"" hidden>");
#nullable restore
#line 39 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                                 Write(item.GetType().GetProperty("Masach").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <img class=\"cart__img\"");
                BeginWriteAttribute("src", " src=\"", 1896, "\"", 1961, 1);
#nullable restore
#line 40 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
WriteAttributeValue("", 1902, item.GetType().GetProperty("Hinhanh").GetValue(item, null), 1902, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1962, "\"", 1968, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <p class=\"tensach item__name\">");
#nullable restore
#line 41 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                                     Write(item.GetType().GetProperty("Tensach").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col col-price col-numeric align-center\" id=\"giaban\">\r\n                            <span class=\"col-price\" id=\"id_giaban\">");
#nullable restore
#line 44 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                                              Write(item.GetType().GetProperty("Giaban").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"theloai\" hidden>");
#nullable restore
#line 46 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                               Write(item.GetType().GetProperty("Theloai").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                        <div class=\"col-auto col-qty layout-inline\">\r\n                            <a href=\"#\" class=\"qty qty-minus\"><span>-</span></a>\r\n                            <input class=\"soluong input__qty\" id=\"id_soluong\" type=\"numberic\"");
                BeginWriteAttribute("value", " value=\"", 2747, "\"", 2814, 1);
#nullable restore
#line 49 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
WriteAttributeValue("", 2755, item.GetType().GetProperty("Soluong").GetValue(item, null), 2755, 59, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <a href=""#"" class=""qty qty-plus""><span>+</span></a>
                        </div>

                        <div class=""col col-vat col-numeric"" id=""thanhtien"">
                            <p class=""price__item"" id=""id_thanhtien""");
                BeginWriteAttribute("value", " value=\"", 3081, "\"", 3150, 1);
#nullable restore
#line 54 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
WriteAttributeValue("", 3089, item.GetType().GetProperty("Thanhtien").GetValue(item, null), 3089, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 54 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                                                                                                                      Write(item.GetType().GetProperty("Thanhtien").GetValue(item, null));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n\r\n                        <div class=\"col-auto col__bin\">\r\n                            <i class=\"delete trash-icon far fa-trash-alt\" id=\"trash-icon\"></i>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 90 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-3 border\" style=\"padding-top:80px;\">\r\n                    <div class=\"cart-store\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37fbf86a13009046f45b9cc573cea245e4af8e6f15105", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <span class=""cart-label"">DaBook Store</span>
                    </div>
                    <div class=""cart-detail"">
                        <div class=""user__cart-delivery"">
                            <div>
                                <span style=""font-weight: 400;"">Giao h??ng ?????n: </span>
                                <span style=""font-weight: 400;"">");
#nullable restore
#line 102 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                                           Write(ViewBag.Hoten);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <div>\r\n                                <span style=\"font-weight: 400;\">S??? ??i???n tho???i: ");
#nullable restore
#line 105 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                                                          Write(ViewBag.Sodt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"cart_address\">\r\n                                <span style=\"font-weight: 400;\">?????a ch???: ");
#nullable restore
#line 108 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
                                                                    Write(ViewBag.Diachi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            </div>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 5827, "\"", 5871, 2);
                WriteAttributeValue("", 5834, "/Client/taikhoan?tentk=", 5834, 23, true);
#nullable restore
#line 110 "D:\Framework\Framework\WebApplication\WebApplication\Views\Client\cart.cshtml"
WriteAttributeValue("", 5857, ViewBag.Tentk, 5857, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""text-decoration: none; justify-content: space-around;"">Thay ?????i</a>
                        </div>
                        <div class=""cart-delivery"" style=""padding: 5px 0 4px;"">
                            <p style=""font-weight: 400; font-size: 1.8rem; color: #666;"">Th??ng tin ????n h??ng</p>
                        </div>
                        <div class=""cart-delivery"" style=""padding: 2px 0;"">
                            <span style=""color: #666;"">T???m t??nh </span>
                            <span id=""id_soluong_sanpham"" style=""color: #666;"">(0) s???n ph???m </span>
                        </div>
                        <div class=""cart-delivery"" style=""padding: 6px 0 14px;"">
                            <span style=""color: #666;"">Ph?? giao h??ng</span>
                            <span class=""totals-value"" id=""cart-shipping"" style=""color: #666;"">40000 </span>
                        </div>
                        <ul class=""list-cart"">
                            <li class=""list-cart-item"">
");
                WriteLiteral(@"                                <div class=""cart__total"">
                                    <span>T???ng ti???n:</span>
                                    <span class=""totals-value"" id=""tongtien"">0</span>
                                </div>
                            </li>
                           
                        </ul>
                    </div>
                </div>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37fbf86a13009046f45b9cc573cea245e4af8e6f20030", async() => {
                    WriteLiteral("\r\n                    <input class=\'data-send\' name=\"data\" value=\"Hello\" hidden />\r\n                    <button type=\"submit\" class=\"confirm-buy btn__buy-book\" id=\"buy\" style=\"top:540px\">X??c nh???n ?????t s??ch</button>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

            </div>
    </div>

    <script>
        var TongTien = 0
        var TongSoLuong = 0
        var dem = 0
        $('.confirm-buy').attr(""disabled"", true)
        $('.checkbuy').on('click', function ()
        {
            console.log(""Hello"")
            var $this = $(this)
            var soluong = $this.parent().parent().find('#id_soluong').val()
            var giaban = $this.parent().parent().find('#id_giaban').text()
            var thanhtien = $this.parent().parent().find('#id_thanhtien').text()
            //console.log('Hellooooo'+thanhtien)
            if ($this.prop('checked') === true) {
                //console.log('Hello')
                TongTien += parseInt(thanhtien)
                TongSoLuong += parseInt(soluong)
                $('#tongtien').text(TongTien.toString())
                $('#id_soluong_sanpham').text('(' + TongSoLuong.toString() + ') S???n ph???m')

            } else {
                TongTien -= parseInt(thanhtien)
                TongSo");
                WriteLiteral(@"Luong -= parseInt(soluong)
                $('#tongtien').text(TongTien.toString())
                $('#id_soluong_sanpham').text('(' + TongSoLuong.toString() + ') S???n ph???m')
            }

            var list_check = $('.checkbuy')
            dem = 0;
            list_check.each(function () {

                if ($(this).prop('checked') === true)
                {
                    dem=dem+1
                }
            })

            if (dem > 0) {
                $('.confirm-buy').attr(""disabled"", false)
            } else $('.confirm-buy').attr(""disabled"", true)
        })

        $('.visibility-cart').on('click',function(){

       var $btn =  $(this);
       var $cart = $('.cart');
       console.log($btn);

       if ($btn.hasClass('is-open')) {
          $btn.removeClass('is-open');
          $btn.text('O')
          $cart.removeClass('is-open');
          $cart.addClass('is-closed');
          $btn.addClass('is-closed');
       } else {
          $btn.addClass(");
                WriteLiteral(@"'is-open');
          $btn.text('X')
          $cart.addClass('is-open');
          $cart.removeClass('is-closed');
          $btn.removeClass('is-closed');
       }


     });

       // SHOPPING CART PLUS OR MINUS
       $('a.qty-minus').on('click', function(e) {
           e.preventDefault();
           //console.log('a.col-price') 
           var $this = $(this);
           var $input = $this.parent().find('#id_soluong');
           var gia_ban = $this.parent().parent().find('#id_giaban')
           var thanh_tien = $this.parent().parent().find(""#id_thanhtien"")
           var value = parseInt($input.val());
           var checkbox = $this.parent().parent().find('.checkbuy')
           var tensach = $this.parent().parent().find('.tensach').text()
           var soluong = parseInt($this.parent().find('.soluong').val())
           var matk = $('.ten-dang-nhap').text()
           //$('.input__qty').value=6


           if (value > 1) {
               value = value - 1;
            ");
                WriteLiteral(@"   var sum = value * (parseInt(gia_ban.text()))

               $input.val(value.toString());
               var temp = sum.toString()
               thanh_tien.text(temp)

               if (checkbox.prop('checked') === true) {
                   TongTien -= (parseInt(gia_ban.text()))
                   $('#tongtien').text(TongTien.toString())
                   TongSoLuong -= 1;
                   $('#id_soluong_sanpham').text('(' + TongSoLuong.toString() + ') S???n ph???m')
               }
           }
           var temp = soluong
           if (soluong > 1) temp = soluong - 1
           var codetk = $('.ma-tai-khoan').val()
           var codesach = $(this).parent().parent().find('.ma-sach').text()
           var codesl = $(this).parent().find('.soluong').val()

           $.get('/Client/updategiohang?matk=' + codetk + '&masach=' + codesach + '&soluong=' + codesl)
               .done(

               )


       });

        $('.delete').on('click', function ()
        {
       ");
                WriteLiteral(@"     var $this = $(this).parent().parent()
            $this.hide()
            var sl_giohang = parseInt($('.sl_giohang').text())
            $('.sl_giohang').text((sl_giohang - 1).toString())
            $.get(""/Client/xoagiohang?masach="" + $this.find('.ma-sach').text())


        })

       $('a.qty-plus').on('click', function(e) {
           e.preventDefault();
           var $this = $(this);
           var $input = $this.closest('div').find('input')
           var gia_ban = $this.parent().parent().find('#id_giaban')
           var thanh_tien = $this.parent().parent().find(""#id_thanhtien"")
           var checkbox = $this.parent().parent().find('.checkbuy')
           var value = parseInt($input.val());
           var tensach = $this.parent().parent().find('.tensach').text()
           var soluong = parseInt($this.parent().find('.soluong').val())
           var matk = $('.ten-dang-nhap').text()

           if (value < 100) {
               value = value + 1;
               var sum = ");
                WriteLiteral(@"value * (parseInt(gia_ban.text()))
               $input.val(value.toString());
               var temp = sum.toString()
               thanh_tien.text(temp)

               if (checkbox.prop('checked') === true) {
                   TongTien += (parseInt(gia_ban.text()))
                   $('#tongtien').text(TongTien.toString())
                   TongSoLuong += 1
                   $('#id_soluong_sanpham').text('(' + TongSoLuong.toString() + ') S???n ph???m')
               }
           }

           var codetk = $('.ma-tai-khoan').val()
           var codesach = $(this).parent().parent().find('.ma-sach').text()
           var codesl = $(this).parent().find('.soluong').val()

           $.get('/Client/updategiohang?matk=' + codetk + '&masach=' + codesach + '&soluong=' + codesl)
               .done(

               )
       });

        $('.confirm-buy').on('click', function ()
        {
            var sanpham = $('.san_pham')
            var ListBuyed = []
            var index = 0");
                WriteLiteral(@"
            var dem=0
            sanpham.each(function (e) {
                if ($(this).find('.checkbuy').prop('checked') === true) {
                    const Sach = {
                        masach: $(this).find('.ma-sach').text(),
                        tensach: $(this).find('.item__name').text(),
                        giaban: $(this).find('#id_giaban').text(),
                        soluong: $(this).find('#id_soluong').val(),
                        tongtien: $(this).find('#id_thanhtien').text(),
                        hinhanh: $(this).find('.cart__img').attr('src'),
                        theloai: $(this).find('.theloai').text()
                    }
                    dem=dem+1
                    ListBuyed.push(Sach)
                }
            })
            if (dem > 0) {
                var DATA = JSON.stringify(ListBuyed)
                $(this).parent().find('.data-send').val(DATA)
            }
            else alert(""Kh??ng c?? s???n ph???m n??o ???????c ch???n"")
           ");
                WriteLiteral(@" //console.log(ListBuyed[0])

        })

     // RESTRICT INPUTS TO NUMBERS ONLY WITH A MIN OF 0 AND A MAX 100
     $('input').on('blur', function(){

       var input = $(this);
       var value = parseInt($(this).val());

         if (value <= 0 || isNaN(value)) {
           input.val(0);
         } else if
           (value > 100) {
           input.val(100);
         }
     });
    </script>

    <script>

        var shippingRate = 40000;
        var fadeTime = 300;

        /* Assign actions */
        $('.col-qty input').change( function() {
        updateQuantity(this);
        });

        function recalculateCart()
        {
        var subtotal = 0;

        /* Sum up row totals */
        $('.layout-inline').each(function () {
            subtotal += parseInt($(this).children('.col-vat').text());
        });

        console.log(subtotal);

        /* Calculate totals */
        var sale = 0;  // ????? t???m
        var shipping = (subtotal > 0 ? shippingRate ");
                WriteLiteral(@": 0);
        var total = subtotal - sale + shipping;
        console.log(total);

        /* Update totals display */
        $('.totals-value').fadeOut(fadeTime, function() {
            $('#cart-subtotal').html(subtotal.toFixed(2));
            $('#cart-sale').html(sale.toFixed(2));
            $('#cart-shipping').html(shipping.toFixed(2));
            $('#cart-total').html(total.toFixed(2));
            console.log(total);
            if(total == 0){
            $('.btn__buy-book').fadeOut(fadeTime);
            }else{
            $('.btn__buy-book').fadeIn(fadeTime);
            }
            $('.totals-value').fadeIn(fadeTime);
        });
        }

        function updateQuantity(quantityInput)
        {
        /* Calculate line price */
        var productRow = $(quantityInput).parent().parent();
        var price = parseFloat(productRow.children('.col-price').text());
        var quantity = $(quantityInput).val();
        var linePrice = price * quantity;

        /* Upd");
                WriteLiteral(@"ate line price display and recalc cart totals */
        productRow.children('.col-vat').each(function () {
            $(this).fadeOut(fadeTime, function() {
            $(this).text(linePrice.toFixed(2));
            recalculateCart();
            $(this).fadeIn(fadeTime);
            });
        });
        }
    </script>

    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""
            integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj""
            crossorigin=""anonymous"">
    </script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.min.js""
            integrity=""sha384-+YQ4JLhjyBLPDQt//I+STsc9iw4uQqACwlvpslubQzn4u2UU2UFM80nGisd026JF""
            crossorigin=""anonymous"">
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
            WriteLiteral("\r\n</html>\r\n");
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
