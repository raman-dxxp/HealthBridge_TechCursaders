using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HealthBridge_TechCursaders.Models;

namespace HealthBridge_TechCursaders.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HealthBridgeDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<HealthBridgeDbContext>>()))
            {
                if (context.Users.Any()) return; // DB already seeded

                var user = new User
                {
                    UserId = Guid.NewGuid(),
                    Email = "patient@example.com",
                    PasswordHash = "hashedpassword",
                    UserType = "Patient",
                    Created = DateTime.UtcNow
                };
                context.Users.Add(user);

                var patient = new Patient
                {
                    PatientId = Guid.NewGuid(),
                    UserId = user.UserId,
                    HealthCardNumber = "123456789",
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(1990, 5, 1),
                    Gender = "Male",
                    Created = DateTime.UtcNow
                };
                context.Patients.Add(patient);

                var provider = new Provider
                {
                    ProviderId = Guid.NewGuid(),
                    Name = "Dr. Smith",
                    Specialty = "Cardiology",
                    Organization = "HealthBridge Clinic",
                    Created = DateTime.UtcNow
                };
                context.Providers.Add(provider);

                var record = new HealthRecord
                {
                    RecordId = Guid.NewGuid(),
                    PatientId = patient.PatientId,
                    ProviderId = provider.ProviderId,
                    RecordType = "Diagnosis",
                    RecordDate = DateTime.UtcNow,
                    Title = "Heart Checkup",
                    Description = "Routine heart checkup",
                    Location = "HealthBridge Clinic",
                    SourceSystem = "Internal",
                    Created = DateTime.UtcNow
                };
                context.HealthRecords.Add(record);

                context.SaveChanges();
            }
        }
    }
}
