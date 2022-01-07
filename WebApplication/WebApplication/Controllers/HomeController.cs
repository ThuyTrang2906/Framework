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

        public IActionResult Index()
        {
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            List<Book> flashsale = context.FlashSales();
            List<Book> listbook = context.GetBook();

            var res = HttpContext.Session.GetString("UserSession");
            if (res != null)
            {
                client_accounts usersession = JsonSerializer.Deserialize<client_accounts>(res);
                ViewBag.infor = usersession;
                ViewBag.status = "Success";
            }

            /*ViewData["FlashSale"] = context.FlashSales();
            ViewData["ListBook"] = context.GetBook();*/
            ViewBag.flashsale = context.FlashSales();
            ViewBag.listbook = context.GetBook();
            /*ViewData.Model = listbook;*/
            return View(listbook);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
