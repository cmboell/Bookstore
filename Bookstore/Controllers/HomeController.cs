using System;
using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Book> data { get; set; }
        public HomeController(BookstoreContext ctx) => data = new Repository<Book>(ctx);



        public ViewResult Index()
        {
           
            return View();
        }

    }
}