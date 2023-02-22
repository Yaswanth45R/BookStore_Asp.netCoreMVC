using Microsoft.AspNetCore.Mvc;

namespace Webgentle.BookStore.Contollers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
