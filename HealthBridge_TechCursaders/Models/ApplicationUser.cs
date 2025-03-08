using Microsoft.AspNetCore.Identity;

namespace HealthBridge_TechCursaders.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? Role { get; set; } // Patient or Doctor
    }

}
