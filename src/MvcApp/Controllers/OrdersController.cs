using Microsoft.AspNetCore.Mvc;

namespace MvcApp.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
