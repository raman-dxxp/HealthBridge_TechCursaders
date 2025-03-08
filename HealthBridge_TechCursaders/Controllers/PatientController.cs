using Microsoft.AspNetCore.Mvc;
using HealthBridge_TechCursaders.Data.Repositories;
using System.Threading.Tasks;

namespace HealthBridge_TechCursaders.Controllers
{
    public class PatientController : Controller
    {
        private readonly PatientRepository _repository;

        public PatientController(PatientRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var patients = await _repository.GetAllPatientsAsync();
            return View(patients);
        }
    }
}
