using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult khuyenmai()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                string tentk = ViewBag.infor.Tentk;
                ViewBag.ds_voucher = context.User_Voucher(tentk);
                int Matk = Convert.ToInt32(usersession.Matk);
                ViewBag.sl = context.User_Vouchers(Matk);
            }
            else
            {
                ViewBag.Status = "Failed";
            }
            ViewBag.khuyenmai = context.GetVoucher();
            return View();
        }

        /*public IActionResult chitietsach()
        {
            return View();
        }*/

        public IActionResult chitietsach(int name)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            ViewBag.status = "Fail";
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
            }

            //StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            Book book = context.ViewBook(name);
            List<Book> booklist = context.DsLienQuan(name);
            List<comment> listcomments = context.binhluan(book.Masach);
            ViewBag.comments = listcomments;
            ViewBag.book = book;
            ViewBag.books = booklist;
            return View();
        }


        [HttpPost]
        public IActionResult DangKy(client_accounts kh)
        {
            int count;

            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            count = context.DangKy(kh);
            client_accounts res = context.Login(kh.Tentk, kh.Matkhau);
            if (res != null)
            {
                ViewBag.status = "Success";
                ViewBag.infor = res;
                HttpContext.Session.SetString("UserSession", JsonSerializer.Serialize(res));
            }
            else
            {
                ViewBag.status = "Fail";
            }
            return Redirect("/Home/Index");
        }

        public IActionResult cart()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                List<object> list=context.Cart(usersession.Matk);
                ViewBag.ListCart = list;
                ViewBag.Hoten = usersession.Hoten;
                ViewBag.Diachi = usersession.Diachi;
                ViewBag.Sodt = usersession.Sodt;
            }

            return View();
        }



        public IActionResult Login()
        {
            string username = HttpContext.Request.Form["username"];
            string password = HttpContext.Request.Form["password"];

            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            client_accounts res = context.Login(username, password);
            if (res != null)
            {
                ViewBag.status = "Success";
                ViewBag.infor = res;
                HttpContext.Session.SetString("UserSession", JsonSerializer.Serialize(res));
            }
            else
            {
                ViewBag.status = "Fail";
            }
            return Redirect("/Home/Index");
        }

        public IActionResult Logout()
        {
            //StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            HttpContext.Session.Remove("UserSession");
            return Redirect("/Home/Index");
        }



        public IActionResult taikhoan(string tentk)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
            }
            ViewBag.taikhoan = context.Client_Accounts(tentk);
            ViewBag.khuyenmai = context.User_Voucher(tentk);
            int matk = Convert.ToInt32(ViewBag.taikhoan.Matk);
            ViewBag.orders = context.DonHang(matk);
            ViewBag.books = context.BookOfOrder(matk);
            return View();
        }

        public IActionResult capnhattaikhoan(string Matk, string Email, string Sodt, string Gioitinh, string Ngaysinh)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            count = context.capnhattaikhoan(Matk, Email, Sodt, Gioitinh, Ngaysinh);
            if (count > 0)
            {
                return Redirect("/Client/taikhoan?tentk=" + Matk);
            }
            else
            {
                return Redirect("/Home/Index");
            }

        }

        public IActionResult capnhatdiachi(string Matk, string Sodt, string Diachi, string Hoten)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            count = context.capnhatdiachi(Matk, Sodt, Diachi, Hoten);
            if (count > 0)
            {
                return Redirect("/Client/taikhoan?tentk=" + Matk);
            }
            else
            {
                return Redirect("/Home/Index");
            }

        }

        public IActionResult capnhatmatkhau(string Matk, string Matkhau)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            count = context.capnhatmatkhau(Matk, Matkhau);
            if (count > 0)
            {
                return Redirect("/Client/taikhoan?tentk=" + Matk);
            }
            else
            {
                return Redirect("/Home/Index");
            }

        }
        public ActionResult Search_Book(string ten_sach)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
            }
            List<Book> books = new List<Book>();
            books = context.Search_Book(ten_sach);
            return View(books);
        }

        public ActionResult Search_Category(string cate)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
            }
            List<Book> books = new List<Book>();
            books = context.Search_Category(cate);
            return View(books);
        }


        public ActionResult Search_Filter(string ngonngu, string nxb)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            List<Book> books = new List<Book>();
            books = context.Search_Filter(ngonngu, nxb);

            return View(books);
        }

        public ActionResult thembinhluan(comment c)
        {
            int count;
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            count = context.thembinhluan(c);
            int name = Convert.ToInt32(c.Masach);
            if (count > 0) return Redirect("/Client/chitietsach?name=" + c.Masach);
            return Redirect("/Home/Index");
        }

        public ActionResult chitietdonhang(int madh)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                ViewBag.chitietdh = context.chitietdh(madh);
                int Matk = Convert.ToInt32(usersession.Matk);
                ViewBag.tamtinh = context.Tamtinh(madh);
                ViewBag.orders = context.ViewDonHang(Matk);
                ViewBag.slmua = context.SoluongMua(madh);
                int giamgia = ViewBag.tamtinh + ViewBag.orders.Tienship - ViewBag.orders.Tongtien;
                ViewBag.giamgia = giamgia;

            }
            return View();
        }
        public IActionResult Luukhuyenmai( int Makm)
        {
            int count;

            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                int Matk = Convert.ToInt32(usersession.Matk);
                count = context.Save_voucher( Matk, Makm);
            }
            return Redirect("/Client/khuyenmai");
        }


    }
}
