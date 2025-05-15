using System.Diagnostics;
using AgriEnergyConnect.Data;
using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace AgriEnergyConnect.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login() => View();

        /// <summary>
        /// This method handles the login process for both farmers and employees. 
        /// It checks the credentials against the database and sets the session variable accordingly. 
        /// If the login fails, it returns an error message.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            // Check Farmer Table
            var farmer = _context.Farmers.FirstOrDefault(f => f.Username == model.Username);
            if (farmer != null)
            {
                HttpContext.Session.SetString("UserType", "Farmer");
            }
            else
            {
                // Check Employee Table
                var employee = _context.Employees.FirstOrDefault(e => e.Username == model.Username);
                if (employee != null)
                {
                    var userType = (employee.Position == "Admin") ? "Admin" : "Employee";
                    HttpContext.Session.SetString("UserType", userType);
                }
                else
                {
                    // Login Failed
                    ViewBag.Error = "Invalid credentials. Please try again.";
                    return View(model);
                }
            }
            return RedirectToAction("Index", "Home"); 
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); // Clears session data
            return RedirectToAction("Index", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
