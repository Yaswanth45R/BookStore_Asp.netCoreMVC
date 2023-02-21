using Microsoft.AspNetCore.Mvc;

namespace Webgentle.BookStore.Contollers
{
    public class HomeController:Controller
    {
        public string Index()
        {
            return "Hello from WebGentle";
        }
    }
}
