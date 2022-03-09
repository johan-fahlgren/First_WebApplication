using Microsoft.AspNetCore.Mvc;

//Som standard så är rutten till en viss action metod i en
//klass [controller namnet]Controller samma som [controller namnet]/[metod namnet].
//Rutten för HomeController.Index blir då alltså home/index.

namespace WebApplicationEmpty.Controllers
{
    public class SnippetController : Controller //namnet innan controller blir ruten.
    {
        public IActionResult Index()
        {
            return Content("Test");
        }

        //ACTION METOD, är sin egna end-point.
        //https://localhost:7138/Snippet/welcome
        public string Welcome()
        {
            return "Hello and welcome!";
        }

        [Route("{controller}/somepage/this")]
        //http://localhost:7138/Snippet/somepage/this
        public string AnotherActionMethod()
        {
            return "jada jada";
        }

        public string Flip()
        {
            var random = new Random();

            string[] coinSides = { "head", "tails" };

            int i = random.Next(coinSides.Length);

            return $"Result: {coinSides[i]}";

        }

        public DateTime Clock()
        {

            return DateTime.Now;

        }

        public IActionResult Missing()
        {

            return NotFound("404");

        }

        public IActionResult Search(string search)
        {

            return Redirect($"http://www.google.se?q={search}");

        }

        public IActionResult Person()
        {

            var newPerson = new Person
            {
                Name = "Olle",
                Age = 12,

            };

            return Json(newPerson);

        }


    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

