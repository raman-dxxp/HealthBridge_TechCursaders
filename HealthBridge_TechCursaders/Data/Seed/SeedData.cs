using HealthBridge_TechCursaders.Data;
using HealthBridge_TechCursaders.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HealthBridge_TechCursaders.Data.Seed
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            try
            {
                using (var context = new HealthBridgeDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<HealthBridgeDbContext>>()))
                {
                    // Ensure Database is Created
                    context.Database.EnsureCreated();

                    // Check if data already exists
                    if (context.Users.Any() || context.Patients.Any() || context.Providers.Any() || context.HealthRecords.Any())
                    {
                        Console.WriteLine("Seed data already exists. Skipping data insertion.");
                        return;
                    }

                    // Create Sample User
                    var user1 = new User
                    {
                        UserId = Guid.NewGuid(),
                        Email = "john.doe@example.com",
                        PasswordHash = "hashedpassword",
                        UserType = "Patient",
                        Created = DateTime.UtcNow
                    };

                    // Create Sample Patient
                    var patient1 = new Patient
                    {
                        PatientId = Guid.NewGuid(),
                        UserId = user1.UserId,
                        FirstName = "John",
                        LastName = "Doe",
                        DateOfBirth = new DateTime(1990, 1, 1),
                        Gender = "Male",
                        Created = DateTime.UtcNow
                    };

                    // Create Sample Provider
                    var provider1 = new Provider
                    {
                        ProviderId = Guid.NewGuid(),
                        Name = "Dr. Smith",
                        Specialty = "Cardiology",
                        Organization = "HealthCare Inc.",
                        Created = DateTime.UtcNow
                    };

                    // Create Sample Health Record
                    var record1 = new HealthRecord
                    {
                        RecordId = Guid.NewGuid(),
                        PatientId = patient1.PatientId,
                        ProviderId = provider1.ProviderId,
                        RecordType = "Checkup",
                        RecordDate = DateTime.UtcNow,
                        Title = "Annual Checkup",
                        Description = "Routine health checkup",
                        Location = "Clinic A",
                        SourceSystem = "Hospital System",
                        Created = DateTime.UtcNow
                    };

                    // Add and Save Data
                    context.Users.Add(user1);
                    context.Patients.Add(patient1);
                    context.Providers.Add(provider1);
                    context.HealthRecords.Add(record1);

                    context.SaveChanges();
                    Console.WriteLine("Database seeding completed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Seeding failed: {ex.Message}");
            }
        }
    }
}
