using Microsoft.AspNetCore.Mvc;

namespace WebApplicationEmpty.Controllers
{
    public class BirthdayController : Controller
    {
        public IActionResult Index(DateTime? date)
        {

            if (date == null)
            {
                date = DateTime.Today;
            }

            return View("UpAndComing", date.Value);
        }

        public IActionResult Overview(int month = 0)
        {
            if (0 <= month && month <= 12)
            {
                return View(month);
            }
            else
            {
                return NotFound("404");
            }

        }

    }
}
