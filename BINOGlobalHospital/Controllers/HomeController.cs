using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BINOGlobalHospital.Models;

namespace BINOGlobalHospital.Controllers;

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
    public ViewResult BookAppointment()
        {
            return View
            (
                new List<DoctorVM>
                {
                    new DoctorVM { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg" },
                    new DoctorVM { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" },
                    new DoctorVM { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" },
                    new DoctorVM { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" },
                    new DoctorVM { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" },
                }
            );
        }
    public ViewResult CompleteAppointment()
    {
        
        return View();
    }
    public ViewResult ReservationsManagement()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
