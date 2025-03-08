using System;
namespace HealthBridge_TechCursaders.Models
{
    public class Provider
    {
        public Guid ProviderId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Organization { get; set; }
        public DateTime Created { get; set; }
    }
}
