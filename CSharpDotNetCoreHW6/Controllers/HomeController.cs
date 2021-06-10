using CSharpDotNetCoreHW6.Models;
using Microsoft.AspNetCore.Mvc;


namespace CSharpDotNetCoreHW6.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BirthdayCardModel());
        }

        [HttpPost]
        public IActionResult Index(Models.BirthdayCardModel birthdayCard)
        {
            if (ModelState.IsValid)
            {
                return View("ThankYou", birthdayCard);
            }
            else
            {
                return View(birthdayCard);
            }
        }
    }
}
