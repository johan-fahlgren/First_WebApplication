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
    }
}
