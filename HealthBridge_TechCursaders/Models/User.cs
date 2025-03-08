using System;

namespace HealthBridge_TechCursaders.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string UserType { get; set; }
        public DateTime Created { get; set; }
    }
}
