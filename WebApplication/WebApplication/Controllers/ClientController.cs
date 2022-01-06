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
            return View();
        }



        public IActionResult taikhoan(string tentk)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            ViewBag.client_account = context.Client_Accounts(tentk);
            ViewBag.danhsach_km = context.User_Voucher(tentk);
            return View();
        }
    }
}
