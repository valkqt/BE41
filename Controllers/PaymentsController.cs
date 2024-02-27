using esercizio.Models;
using Microsoft.AspNetCore.Mvc;

namespace esercizio.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.payments = Db.payments;

            return View();
        }


    }
}
