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
            return View();
        }

        [HttpGet]
        [Route("/Client/chitietsach/{name}")]
        public IActionResult chitietsach(String name)
        {
            string Name = "Indian Summer";
            StoreContext context = HttpContext.RequestServices.GetService(typeof(WebApplication.Models.StoreContext)) as StoreContext;
            Book bo = context.ViewBook(Name);
            List<Book> books = context.DsLienQuan(Name);
            dynamic mymodel = new ExpandoObject();
            mymodel.book = bo;
            mymodel.books = books;
            return View(mymodel);
        }
    }
}
