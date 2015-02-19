using AspNet5MvcRunningOnUbuntu.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspNet5MvcRunningOnUbuntu.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var child = new Child
            {
                Name = "Sebastian",
                MessageToMom = "Look, Mom! I'm running ASP.NET 5 on Ubuntu!"
            };

            return View(child);
        }
    }
}
