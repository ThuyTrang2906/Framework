using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication.Models;
using System.Web;

namespace WebApplication.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult khuyenmai()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;

            return View(context.GetVoucher());
        }

        /*public IActionResult chitietsach()
        {
            return View();
        }*/

        public IActionResult chitietsach(String name)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            List<Book> flashsale = context.FlashSales();
            List<Book> listbook = context.GetBook();

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

            if (count > 0)
                ViewData["thongbao"] = "Insert thành công";
            else
                ViewData["thongbao"] = "Insert không thành công";
            return View();
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
                List<object> list = context.Cart(usersession.Matk);
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
            ViewBag.taikhoan = context.Client_Accounts(tentk);
            ViewBag.khuyenmai = context.User_Voucher(tentk);
            return View();
        }

        public IActionResult updategiohang(string matk, string masach, string soluong)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            context.updategiohang(matk, masach, soluong);
            return View();
        }

        public class sach
        {
            public string masach { get; set; }
            public string tensach { get; set; }
            public string giaban { get; set; }
            public string soluong { get; set; }
            public string tongtien { get; set; }
            public string hinhanh { get; set; }
            public string theloai { get; set; }
        }

        public IActionResult payment()
        {
            string data = HttpContext.Request.Form["data"];
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                var temp = JsonSerializer.Deserialize<sach[]>(data);
                int soluong = 0, thanhtien = 0;
                foreach(var item in temp)
                {
                    soluong += Convert.ToInt32(item.soluong);
                    thanhtien += Convert.ToInt32(item.giaban) * Convert.ToInt32(item.soluong);
                }
                List<object> ListVoucher = context.get_voucher(usersession.Matk.ToString());
                ViewBag.ListVoucher = ListVoucher;
                DateTime dateTime = DateTime.Today;
                string date = dateTime.ToString("dd/MM/yyyy");
                ViewBag.Ngaygiao = date;
                ViewBag.Soluong = soluong;
                ViewBag.Thanhtien = thanhtien;
                ViewBag.ListBuyed = temp;
                ViewBag.Hoten = usersession.Hoten;
                ViewBag.Diachi = usersession.Diachi;
                ViewBag.Sodt = usersession.Sodt;
            }
            return View();
        }

        

        public IActionResult thanhyou(string data, string tongtien, string soluong, string hinhthucthanhtoan, string tinhtrangthanhtoan, string tinhtrangdonhang, string list_user)
        {
            /*var data = HttpContext.Request.Form["data"];
            string tongtien = HttpContext.Request.Form["tongtien"];
            string soluong = HttpContext.Request.Form["soluong"];
            string hinhthucthanhtoan = HttpContext.Request.Form["hinhthucthanhtoan"];
            string tinhtrangthanhtoan = HttpContext.Request.Form["tinhtrangdonhang"];
            string tinhtrangdonhang = HttpContext.Request.Form["tinhtrangdonhang"];*/

            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                string AAA = list_user;
                string matk = usersession.Matk;
                context.thanhyou(matk, data, tongtien, soluong, hinhthucthanhtoan, tinhtrangthanhtoan, tinhtrangdonhang);
            }
            
            return View();
        }

        public IActionResult deletevoucher(string data)
        {
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                context.deletevoucher(usersession.Matk,data);
            }
            return View();
        }
    }
}
