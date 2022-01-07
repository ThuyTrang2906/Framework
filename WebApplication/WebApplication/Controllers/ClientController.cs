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
             
            return View(context.GetVoucher());
        }

        /*public IActionResult chitietsach()
        {
            return View();
        }*/

        public IActionResult chitietsach(String name)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
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

            return View();
        }


       
        public IActionResult Login()
        {
            string username = HttpContext.Request.Form["username"];
            string password = HttpContext.Request.Form["password"];

            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            client_accounts res = context.Login(username, password);
            if (res!= null)
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



        public IActionResult taikhoan(string tentk)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            ViewBag.taikhoan = context.Client_Accounts(tentk);
            ViewBag.khuyenmai = context.User_Voucher(tentk);
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
            }
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
    }
}
