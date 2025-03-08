using HealthBridge_TechCursaders.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthBridge_TechCursaders.Data.Repositories
{
    public class PatientRepository
    {
        private readonly HealthBridgeDbContext _context;

        public PatientRepository(HealthBridgeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Patient>> GetAllPatientsAsync()
        {
            return await _context.Patients.ToListAsync();
        }
    }
}
