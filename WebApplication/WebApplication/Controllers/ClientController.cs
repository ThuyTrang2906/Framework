using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
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
    }
}
