using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

/*using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;
*/

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int page)
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            if (page == -1)
            {
                ViewBag.flashsale = context.FlashSales();
                ViewBag.listbook = context.GetBook(0);
                ViewBag.page = 1;
            }
            else
            {
                ViewBag.flashsale = context.FlashSales();
                ViewBag.listbook = context.GetBook(page-1);
                ViewBag.page = page;
            }
            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                usersession = context.Login(usersession.Tentk, usersession.Matkhau);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
                ViewBag.avatar = HttpContext.Session.GetString("Avatar");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
