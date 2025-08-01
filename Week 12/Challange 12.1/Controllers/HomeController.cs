using Challange_12._1.Models;
using Challange_12._1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Challange_12._1.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ViewResult PersonalInfo() 
        {
            string? name = "Salah Eldin Mohamed";
            int age = 26;
            string? address = "Sheikh Zayed";
            char? gender = 'M';
            List<string>? skills = new List<string> { "C#", "ASP.NET Core", "Entity Framework", "SQL Server" };

            var PersonalInfoVM = new PersonalInfoVM
            {
                Name = name,
                Age = age,
                Address = address,
                Gender = gender,
                Skills = skills
            };

            return View(PersonalInfoVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
