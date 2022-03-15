using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEmpty.Controllers
{
    public class BirthdayController : Controller
    {
        public IActionResult Index(DateTime? date)
        {

            return RedirectToAction("UpAndComing",
                new
                {
                    date = DateTime.Today.ToString("yyyy-MM-dd")
                });
        }

        public IActionResult UpAndComing(DateTime date)
        {
            return View(date);
        }

        public IActionResult Overview(int? month)
        {
            return View(month);
        }

    }
}
