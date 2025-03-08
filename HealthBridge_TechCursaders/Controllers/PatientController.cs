using Microsoft.AspNetCore.Mvc;
using HealthBridge_TechCursaders.Data.Repositories;
using System.Threading.Tasks;

namespace HealthBridge_TechCursaders.Controllers
{
    public class PatientController : Controller
    {
        


            public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
