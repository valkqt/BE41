using esercizio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Xml.Linq;

namespace esercizio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.employees = Db.employees;
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }

        [HttpPost]
        public IActionResult NewPayment(double amount, PaymentType type, string startdate, string enddate, int? id)
        {

            ViewBag.id = id;
            Payment p4 = new Payment(Db.PaymentCount, amount, type, new string[] { startdate, enddate }, Db.employees.Find(elem => elem.id == id));
            Db.AddPayment(p4);
            return RedirectToAction("Index", "Payments");
        }


        [HttpPost]
        public IActionResult Add(string name, string surname, string address, string cf, int children, bool married, Roles role)
        {
            Employee e4 = new Employee(Db.EmployeeCount, name, surname, address, cf, children, married, role);
            Db.AddEmployee(e4);
            return RedirectToAction("Index");
        }
        public IActionResult NewPayment(int? id)
        {
            ViewBag.id = id;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
