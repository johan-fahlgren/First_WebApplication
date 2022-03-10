using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEmpty.Controllers
{
    public class BirthdayController : Controller
    {
        public IActionResult Index()
        {
            return View("UpAndComing");
        }
    }
}
