using HealthBridge_TechCursaders.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthBridge_TechCursaders.Data
{
    public class HealthBridgeDbContext : DbContext
    {
        public HealthBridgeDbContext(DbContextOptions<HealthBridgeDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.User)
                .WithOne()
                .HasForeignKey<Patient>(p => p.UserId);

            modelBuilder.Entity<HealthRecord>()
                .HasOne(hr => hr.Patient)
                .WithMany()
                .HasForeignKey(hr => hr.PatientId);

            modelBuilder.Entity<HealthRecord>()
                .HasOne(hr => hr.Provider)
                .WithMany()
                .HasForeignKey(hr => hr.ProviderId);
        }
    }
}
