using Microsoft.AspNetCore.Mvc;

namespace esercizio.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult New(int? id)
        {
            ViewBag.id = id;
            return View();

        }
    }
}
