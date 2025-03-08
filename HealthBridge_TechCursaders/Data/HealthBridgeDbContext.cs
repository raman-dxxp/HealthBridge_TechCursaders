using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HealthBridge_TechCursaders.Data
{
    public class HealthBridgeDbContextFactory : IDesignTimeDbContextFactory<HealthBridgeDbContext>
    {
        public HealthBridgeDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HealthBridgeDbContext>();

            // ✅ Directly specify LocalDB connection string
            string connectionString = "Server=(localdb)\\ProjectModels;Database=HealthBridgeDB;Trusted_Connection=True;TrustServerCertificate=True;";

            optionsBuilder.UseSqlServer(connectionString);

            return new HealthBridgeDbContext(optionsBuilder.Options);
        }
    }
}
