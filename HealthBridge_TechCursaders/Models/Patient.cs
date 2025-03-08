using System;
namespace HealthBridge_TechCursaders.Models
{
    public class Patient
    {
        public Guid PatientId { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string HealthCardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime Created { get; set; }
    }
}
