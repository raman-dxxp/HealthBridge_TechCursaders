namespace HealthBridge_TechCursaders.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string HealthCardNumber { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
        public virtual ICollection<TestResult> TestResults { get; set; }
    }

}
